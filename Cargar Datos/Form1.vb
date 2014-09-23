Imports MySql.Data.MySqlClient

Public Class Form1

    Dim conexion As New MySqlConnection
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Process.Start("cmd.exe")

    End Sub
    Public Sub varconecion()
        conexion.ConnectionString = "server=" & Trim(SERVIDOR.Text) & ";userid=" & Trim(USUARIO.Text) & ";password=" & Trim(PASS.Text) & ";database=" & Trim(BASE.Text) & ";port=" & Trim(puerto.Text) & ""
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName.Length > 0 Then
            gridtabla.Columns.Clear()
         
            Try
                Dim workbook1 = New ClosedXML.Excel.XLWorkbook(OpenFileDialog1.FileName)
                Dim worksheet = workbook1.Worksheet(1)
                Dim x As Integer = 1
                Dim texto2 As String = worksheet.Cell(1, 1).Value
                While (texto2.Length > 0)
                    gridtabla.Columns.Add(texto2, texto2)
                    x = x + 1
                    texto2 = Trim(worksheet.Cell(1, x).Value)
                End While
                Dim columnas As Integer = x
                Dim vector(columnas) As String
                x = 2
                Dim texto As String = worksheet.Cell(2, 1).Value

                While (texto.Length > 0)
                    For y As Integer = 1 To columnas
                        vector(y - 1) = Trim(worksheet.Cell(x, y).Value)
                    Next
                    gridtabla.Rows.Add(vector)
                    ' gridtabla.Rows.Add(Trim(worksheet.Cell(x, 1).Value), Trim(worksheet.Cell(x, 2).Value), Trim(worksheet.Cell(x, 3).Value), Trim(worksheet.Cell(x, 4).Value), Trim(worksheet.Cell(x, 5).Value), Trim(worksheet.Cell(x, 6).Value))
                    x = x + 1
                    texto = Trim(worksheet.Cell(x, 1).Value)
                End While
                MsgBox("Termino la Importación de datos", MsgBoxStyle.Information, "Datos de Excel")
            Catch ex As Exception
                MsgBox("Error al abrir el archivo", MsgBoxStyle.Critical, "Error al Importar")
            End Try
        Else
            MsgBox("Eligue el Origen de datos", MsgBoxStyle.Critical, "Error al Importar")
        End If

    End Sub
    Public Sub consultar(ByVal consulta As String)
        Try
            varconecion()

            conexion.Open()

            Dim dset As New DataSet
            Dim dadaptador As New MySqlDataAdapter

            dadaptador.SelectCommand = New MySqlCommand(consulta, conexion)
            dadaptador.Fill(dset)
            conexion.Close()
            Dim dtable As DataTable = dset.Tables(0)
            gridtabla.DataSource = dtable
        Catch ex As Exception
            conexion.Close()
        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Trim(SERVIDOR.Text).Length < 1 Then
            MsgBox("Sevidor no puede ser vacio", MsgBoxStyle.Information, "Validando")
            SERVIDOR.Focus()
            Exit Sub
        End If

        If Trim(BASE.Text).Length < 1 Then
            MsgBox("Base de datos no puede ser vacio")
            BASE.Focus()
            Exit Sub
        End If

        If Trim(TABLA.Text).Length < 1 Then
            MsgBox("tabla no puede ser vacio")
            TABLA.Focus()
            Exit Sub
        End If

        If Trim(USUARIO.Text).Length < 1 Then
            MsgBox("usuario no puede ser vacion")
            USUARIO.Focus()
            Exit Sub
        End If

        If Trim(PASS.Text).Length < 1 Then
            MsgBox("Password no puede ser vacio")
            PASS.Focus()
        End If

        If gridtabla.Rows.Count < 1 Then
            MsgBox("no existen datos para exportar en la grilla", MsgBoxStyle.Exclamation, "Datos Vacios")
            Exit Sub
        End If
        guardar()


    End Sub

    Public Sub guardar()


        varconecion()
       
        '  MsgBox(gridtabla.Columns.Count)

        If CheckBox1.Checked Then
            Try
                conexion.Open()
                Dim coman As New MySqlCommand("delete from " & Trim(TABLA.Text), conexion)
                coman.CommandType = CommandType.Text
                coman.ExecuteNonQuery()
                conexion.Close()
            Catch ex As Exception
                conexion.Close()
                MsgBox("fallo la eliminacion de datos")
                Exit Sub
            End Try
        End If


        Dim agrega As String = "call insertarfactura(" '" & Trim(TABLA.Text) & " values("
        For x As Integer = 1 To gridtabla.Columns.Count
            agrega = agrega & "@v" & x
            If x < gridtabla.Columns.Count Then
                agrega = agrega & ","
            End If
        Next
        agrega = agrega & ")"

        For x As Integer = 0 To gridtabla.RowCount - 1
            Try
                conexion.Open()
                Dim comando As New MySqlCommand(agrega, conexion)
                comando.CommandType = CommandType.Text
                For y As Integer = 0 To gridtabla.Columns.Count - 1
                    If y = 6 Or y = 9 Then
                        comando.Parameters.AddWithValue("@v" & (y + 1), Convert.ToDateTime(gridtabla.Item(y, x).Value))
                    Else
                        If y = 12 Or y = 14 Then
                            If Trim(gridtabla.Item(y, x).Value).Length < 1 Then
                                comando.Parameters.AddWithValue("@v" & (y + 1), 0)
                            Else
                                comando.Parameters.AddWithValue("@v" & (y + 1), Convert.ToDateTime(gridtabla.Item(y, x).Value))
                            End If

                        Else
                            If y = 11 Then
                                comando.Parameters.AddWithValue("@v" & (y + 1), Convert.ToDouble(gridtabla.Item(y, x).Value))
                            Else
                                comando.Parameters.AddWithValue("@v" & (y + 1), gridtabla.Item(y, x).Value)
                            End If

                        End If


                    End If


                Next

                comando.ExecuteNonQuery()
                conexion.Close()

            Catch ex As Exception
                conexion.Close()
            End Try
        Next

        MsgBox("Datos guardados...", MsgBoxStyle.Information, "Trabajo Terminado")

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If gridtabla.Rows.Count < 1 Then
            MsgBox("La grilla No contiene datos", MsgBoxStyle.Exclamation, "Datos Vacios")
            Exit Sub
        End If


        SaveFileDialog1.FileName = ""
        SaveFileDialog1.Filter = "Excel 2007 y Superior|*.xlsx|Excel 2003|.xls"
        SaveFileDialog1.Title = "Exportar a Excel"
        SaveFileDialog1.ShowDialog()
        Try
            If SaveFileDialog1.FileName.Length > 0 Then
                Dim workbook1 = New ClosedXML.Excel.XLWorkbook()
                Dim worksheet = workbook1.Worksheets.Add("Datos")

                For x1 As Integer = 0 To gridtabla.ColumnCount - 1
                    worksheet.Cell(1, x1 + 1).Value = gridtabla.Columns(x1).HeaderText
                Next

                For X As Integer = 0 To gridtabla.RowCount - 1
                    For y As Integer = 0 To gridtabla.ColumnCount - 1
                        worksheet.Cell(X + 2, y + 1).Value = gridtabla.Item(y, X).Value
                    Next
                Next
                SaveFileDialog1.FileName = SaveFileDialog1.FileName & ".xlsx"
                workbook1.SaveAs(SaveFileDialog1.FileName)
                MsgBox("Exportacion exitosa: " & Chr(13) & SaveFileDialog1.FileName & "", MsgBoxStyle.Information, "Exportación Finalizada")
            End If

        Catch ex As Exception
            MsgBox("La Exportación Fallo", MsgBoxStyle.Exclamation, "Exportacion")
        End Try
       

    End Sub

    Private Sub gridtabla_RowsAdded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles gridtabla.RowsAdded
        REGISTROS.Text = "Registros: " & gridtabla.Rows.Count
    End Sub

    Private Sub gridtabla_RowsRemoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles gridtabla.RowsRemoved
        REGISTROS.Text = "Registros: " & gridtabla.Rows.Count
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        gridtabla.Columns.Clear()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        gridtabla.Columns.Clear()
        consultar("select * from " & Trim(TABLA.Text))
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        gridtabla.Columns.Clear()
        Try
            varconecion()
            conexion.Open()
            conexion.Close()
            MsgBox("Conexion exitosa", MsgBoxStyle.Information, "Coneccion")
        Catch ex As Exception
            conexion.Close()
            MsgBox("Error de Conexion", MsgBoxStyle.Information, "Coneccion")
            Exit Sub
        End Try

        Try

            consultar("show tables")

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        gridtabla.Columns.Clear()
        Try
            consultar("describe " & Trim(TABLA.Text))
        Catch ex As Exception

        End Try

    End Sub
End Class
