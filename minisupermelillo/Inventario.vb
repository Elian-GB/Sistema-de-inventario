Imports System.Runtime.InteropServices

Public Class Inventario
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Application.Exit()
    End Sub

    Private Sub BtnMinimizar_Click(sender As Object, e As EventArgs) Handles BtnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

#Region "Animacion de botones"
    Private Sub BtnSalir_MouseEnter(sender As Object, e As EventArgs) Handles BtnSalir.MouseEnter
        ' Cambiar a una imagen más oscura
        BtnSalir.Image = My.Resources.Cerrar___Editado
    End Sub

    Private Sub BtnSalir_MouseLeave(sender As Object, e As EventArgs) Handles BtnSalir.MouseLeave
        ' Restaurar la imagen original
        BtnSalir.Image = My.Resources.Cerrar
    End Sub

    Private Sub BtnMinimizar_MouseEnter(sender As Object, e As EventArgs) Handles BtnMinimizar.MouseEnter
        ' Cambiar a una imagen más oscura
        BtnMinimizar.Image = My.Resources.Minimizar____Editado ' Reemplaza con tu imagen oscura
    End Sub

    Private Sub BtnMinimizar_MouseLeave(sender As Object, e As EventArgs) Handles BtnMinimizar.MouseLeave
        ' Restaurar la imagen original
        BtnMinimizar.Image = My.Resources.Minimizar
    End Sub
#End Region
#Region "Informacion de Productos"
    Private Sub cerrado()
        CodigoTextBox.Enabled = False
        ProductoTextBox.Enabled = False
        DescripcionTextBox.Enabled = False
        PrecioTextBox.Enabled = False
        ExistenciaTextBox.Enabled = False
        Button4.Enabled = False
        ImagenPictureBox.Enabled = False
    End Sub


    Private Sub abierto()
        CodigoTextBox.Enabled = True
        ProductoTextBox.Enabled = True
        DescripcionTextBox.Enabled = True
        PrecioTextBox.Enabled = True
        ExistenciaTextBox.Enabled = True
        Button4.Enabled = True
        ImagenPictureBox.Enabled = True
    End Sub
#End Region
#Region "Inserter imagen"
    Private Sub ImagenPictureBox_Click(sender As Object, e As EventArgs) Handles ImagenPictureBox.Click

        Try
            Dim ofd As New OpenFileDialog()
            ofd.Title = "Abrir Imagen"
            ofd.FileName = ""
            ofd.Filter = "Imágenes (*.jpg;*.png;*.bmp)|*.jpg;*.png;*.bmp|Todos los archivos (*.*)|*.*"

            If ofd.ShowDialog() = DialogResult.OK Then
                ImagenPictureBox.Image = System.Drawing.Image.FromFile(ofd.FileName)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al abrir la imagen: " & ex.Message)
        End Try
    End Sub
#End Region

#Region "movimiento de la ventana"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, IParam As Integer)
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
#End Region


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Menu1.Show()
    End Sub
    Private Sub ProductosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Bd1DataSet)

    End Sub
#Region "Cargar Ventana"
    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Bd1DataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.Bd1DataSet.Productos)
        Me.KeyPreview = True
        cerrado()
    End Sub
#End Region
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If RadioButton1.Checked = True Then
            Me.ProductosBindingSource.Filter = "codigo LIKE '%" & TextBox1.Text & "%'"
        Else
            Me.ProductosBindingSource.Filter = "producto LIKE '%" & TextBox1.Text & "%'"
            Exit Sub ' Salimos si no es por código
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        abierto()
        Me.Validate()
        Me.ProductosBindingSource.AddNew()
        CodigoTextBox.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If CodigoTextBox.Enabled = False Then
            abierto()
            Button4.Enabled = False
        Else
            Me.Validate()
            Me.ProductosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Bd1DataSet)
            Me.ProductosTableAdapter.Fill(Me.Bd1DataSet.Productos)
            MsgBox("El producto ha sido editado con exito :)", MsgBoxStyle.Information, "Producto editado")
            cerrado()
            TextBox1.Focus()
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ImagenPictureBox.Image Is Nothing Or CodigoTextBox.Text = "" Or ProductoTextBox.Text = "" Or DescripcionTextBox.Text = "" Or PrecioTextBox.Text = "" Or ExistenciaTextBox.Text = "" Then
            MsgBox("Error! Debes Rellenar todos los campos (Incluyendo la imagen)", MsgBoxStyle.Critical, "Error")
        Else
            ' Verifica si el producto ya existe
            If ProductosBindingSource.Find("codigo", CodigoTextBox.Text) = -1 Then
                ' Validar antes de guardar
                Me.Validate()
                Me.ProductosBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.Bd1DataSet)

                ' Recargar los productos después de guardar
                Me.ProductosTableAdapter.Fill(Me.Bd1DataSet.Productos)

                ' Actualizar la vista
                ProductosDataGridView.Refresh()

                MsgBox("Se ha guardado el producto", MsgBoxStyle.Information, "Guardado con éxito")
                cerrado()
            Else
                ' Si el producto ya existe, mostrar un mensaje
                CodigoTextBox.Text = ""
                CodigoTextBox.Focus()
                MsgBox("Error! Ya existe este producto", MsgBoxStyle.Information, "Ya existe!")
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If CodigoTextBox.Text = "" Then
            MsgBox("Error no existe producto para eliminar", MsgBoxStyle.Critical, "Erorr")
        Else
            Dim eliminar As String = MsgBox("¿Desea elimiar este producto?", vbYesNo, "¿Eliminar?")
            If eliminar = vbYes Then
                Me.Validate()
                Me.ProductosBindingSource.RemoveCurrent()
                Me.TableAdapterManager.UpdateAll(Me.Bd1DataSet)
                Me.ProductosTableAdapter.Fill(Me.Bd1DataSet.Productos)
                MsgBox("Se ha eliminado un producto satisfactoriamente", MsgBoxStyle.Information, "Registro eliminado")
            Else
                MsgBox("Se ha cancelado la eliminacion del producto", MsgBoxStyle.Information, "Accion cancelada")

            End If
        End If
    End Sub
#Region "Flechas de navegacion"
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.ProductosBindingSource.MoveNext()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.ProductosBindingSource.MovePrevious()
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        Select Case keyData
            Case Keys.Down
                Me.ProductosBindingSource.MoveNext()
                Return True
            Case Keys.Up
                Me.ProductosBindingSource.MovePrevious()
                Return True
        End Select
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        cerrado()
        Me.ProductosTableAdapter.Fill(Me.Bd1DataSet.Productos)
    End Sub


#End Region

End Class