Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices


Public Class inicio
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

#Region "Conexion SQL"
    Dim conexion As New SqlConnection
    Dim comando As New SqlCommand

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Leer la cadena de conexión desde la variable de entorno
        Dim connectionString As String = Environment.GetEnvironmentVariable("BD_MiniSuperMelillo")

        ' Verificar si la variable de entorno tiene un valor
        If String.IsNullOrEmpty(connectionString) Then
            MsgBox("La cadena de conexión no está configurada correctamente.", MsgBoxStyle.Critical, "Error de conexión")
            Exit Sub
        End If

        ' Establecer la conexión utilizando la cadena de conexión
        conexion = New SqlConnection(connectionString)

    End Sub
#End Region

    Private Sub Btningresar_Click(sender As Object, e As EventArgs) Handles Btningresar.Click

        conexion.Open()

        Dim consulta As String = "Select * FROM Usuarios where Username = '" & User.Text & "' and PasswordHash = '" & pass.Text & "'"

        comando = New SqlCommand(consulta, conexion)
        Dim lector As SqlDataReader

        lector = comando.ExecuteReader

        If lector.HasRows Then
            MsgBox("Bienvenido " & User.Text & " :)", MsgBoxStyle.Information, "Login Correcto")
            Me.Hide()
            Menu1.ShowDialog()

        Else

            MsgBox("Error al iniciar sesión", MsgBoxStyle.Critical, "¡Error!")
            User.Clear()
            pass.Clear()

        End If

        conexion.Close()

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
#End Region

End Class


