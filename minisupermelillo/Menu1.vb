Imports System.Runtime.InteropServices

Public Class Menu1

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Ventas.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Inventario.Show()
    End Sub

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Historial.Show()
    End Sub

#End Region
End Class