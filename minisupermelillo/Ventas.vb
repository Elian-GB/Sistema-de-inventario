Imports System.Data.SqlClient
Imports System.Runtime.InteropServices

Public Class Ventas
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Application.Exit()
    End Sub

    Private Sub BtnMinimizar_Click(sender As Object, e As EventArgs) Handles BtnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

#Region "funcion para guardar en historial"

    Private Sub GuardarHistorialDeCompra(total As Double)
        Try
            ' Establecer la conexión con la base de datos
            Dim conexion As New SqlConnection("server=ELIAN\SQLEXPRESS;database=bd1;integrated security=true")
            conexion.Open()

            ' Insertar un nuevo registro en la tabla HistorialCompras
            Dim comando As New SqlCommand("INSERT INTO HistorialCompras (Fecha, Hora, Total, Productos, Cantidades) " &
                                      "VALUES (@Fecha, @Hora, @Total, @Productos, @Cantidades)", conexion)

            Dim fechaActual As String = DateTime.Now.ToString("yyyy-MM-dd")   ' Fecha sin la parte de la hora
            Dim horaActual As String = DateTime.Now.ToString("HH:mm") ' Solo la hora

            ' Definir los parámetros
            comando.Parameters.AddWithValue("@Fecha", fechaActual)  ' Fecha y hora de la compra
            comando.Parameters.AddWithValue("@Hora", horaActual)
            comando.Parameters.AddWithValue("@Total", total)         ' El monto total gastado
            comando.Parameters.AddWithValue("@Productos", ObtenerProductosDelCarrito()) ' Función para obtener los productos del carrito
            comando.Parameters.AddWithValue("@Cantidades", ObtenerCantidadesDelCarrito()) ' Función para obtener las cantidades de los productos

            ' Ejecutar la sentencia SQL
            comando.ExecuteNonQuery()

        Catch ex As Exception
            ' Manejar errores en la inserción
            MsgBox("Error al guardar el historial de la compra: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    ' Función para obtener los productos del carrito como una cadena
    Private Function ObtenerProductosDelCarrito() As String
        Dim productos As String = ""
        For Each item As String In ListBox1.Items
            productos &= item & ", "
        Next
        Return productos.TrimEnd(","c) ' Elimina la coma final
    End Function

    ' Función para obtener las cantidades de los productos en el carrito
    Private Function ObtenerCantidadesDelCarrito() As String
        Dim cantidades As String = ""
        For Each item As String In ListBox2.Items
            cantidades &= item & ", "
        Next
        Return cantidades.TrimEnd(","c) ' Elimina la coma final
    End Function


#End Region

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


    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        ' Aplica filtro según el radio seleccionado
        If RadioButton1.Checked = True Then
            Me.ProductosBindingSource.Filter = "codigo LIKE '%" & TextBox1.Text & "%'"
        Else
            Me.ProductosBindingSource.Filter = "producto LIKE '%" & TextBox1.Text & "%'"
            Exit Sub ' Salimos si no es por código
        End If

        ' Solo continúa si se presiona Enter
        If e.KeyChar = ChrW(Keys.Enter) Then
            Dim inputCantidad As String = InputBox("Agregar la cantidad del producto", "Cantidad", "1")

            ' Validación: ¿es un número?
            If Not IsNumeric(inputCantidad) Then
                MsgBox("Error, este campo solo acepta números", MsgBoxStyle.Critical, "Error de captura")
                Exit Sub
            End If

            ' Conversión segura de strings a números
            Dim cantidad As Double = CDbl(inputCantidad)
            Dim existencia As Double = 0
            Dim precio As Double = 0

            ' Validamos que existan datos numéricos válidos
            If Not Double.TryParse(ExistenciaTextBox.Text, existencia) Then
                MsgBox("Error al leer la existencia del producto.", MsgBoxStyle.Critical, "Error de datos")
                Exit Sub
            End If

            If Not Double.TryParse(PrecioTextBox.Text, precio) Then
                MsgBox("Error al leer el precio del producto.", MsgBoxStyle.Critical, "Error de datos")
                Exit Sub
            End If

            ' Validación: cantidad no debe superar la existencia
            If cantidad > existencia Then
                MsgBox("Error: la cantidad agregada es mayor que la existente.", MsgBoxStyle.Critical, "Error de cantidad")
                TextBox1.Text = ""
                TextBox1.Focus()
                ProductosDataGridView.Refresh()
                Exit Sub
            End If
            ' Cálculo y actualización de datos
            Dim costoTotal As Double = cantidad * precio

            ListBox1.Items.Add(ProductoTextBox.Text)
            ListBox2.Items.Add(precio.ToString("0.00") & " X " & cantidad)
            ListBox3.Items.Add(costoTotal.ToString("0.00"))

            ' Actualizar el total parcial
            Dim totalParcial As Double = 0
            For Each item In ListBox3.Items
                totalParcial += CDbl(item)
            Next

            TextBox2.Text = totalParcial.ToString("0.00")


            ' Actualiza existencia
            Dim nuevaExistencia As Double = existencia - cantidad
            ExistenciaTextBox.Text = nuevaExistencia.ToString()

            ' Guarda cambios
            Validate()
            Me.ProductosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Bd1DataSet)
            Me.ProductosTableAdapter.Fill(bd1DataSet.Productos)
            ProductosDataGridView.Refresh()
            Me.ProductosBindingSource.ResetBindings(False)


            ' Limpia búsqueda
            TextBox1.Text = ""
            TextBox1.Focus()
        End If
    End Sub




    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim pagoInput As String = InputBox("Ingrese el pago")

        ' Si el usuario cancela o deja vacío, salimos
        If String.IsNullOrEmpty(pagoInput) Then
            MsgBox("Operación cancelada.", MsgBoxStyle.Information, "Cancelar")
            Exit Sub
        End If

        ' Intentamos convertir el pago a número
        Dim pago As Double
        If Not Double.TryParse(pagoInput, pago) Then
            MsgBox("Error: solo se aceptan números como pago.", MsgBoxStyle.Critical, "Error de entrada")
            Exit Sub
        End If

        Dim suma As Double = 0
        For Each elemento In ListBox3.Items
            Dim valor As Double
            If Double.TryParse(elemento.ToString, valor) Then
                suma += valor
            Else
                MsgBox("Advertencia: se encontró un valor no numérico en el carrito y fue ignorado.", MsgBoxStyle.Exclamation)
            End If
        Next

        Dim cambio As Double = pago - suma
        TextBox2.Text = suma.ToString("0.00")
        TextBox3.Text = pago.ToString("0.00")
        TextBox4.Text = cambio.ToString("0.00")
    End Sub

#Region "Guardar en historial"
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        ' Obtener el total de la compra antes de limpiar los campos
        Dim suma As Double = 0
        For Each elemento In ListBox3.Items
            Dim valor As Double
            If Double.TryParse(elemento.ToString, valor) Then
                suma += valor
            Else
                MsgBox("Advertencia: se encontró un valor no numérico en el carrito y fue ignorado.", MsgBoxStyle.Exclamation)
            End If
        Next

        ' Si no hay productos en el carrito, mostrar un mensaje y no continuar
        If suma = 0 Then
            MsgBox("No hay productos en la venta para guardar en el historial.", MsgBoxStyle.Critical, "Venta vacía")
            Exit Sub
        End If

        ' Llamar a la función para guardar el historial de la compra
        GuardarHistorialDeCompra(suma)

        ' Limpiar los ListBox y los TextBox para preparar una nueva venta
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""

        ' Reiniciar el enfoque para el próximo código de producto
        TextBox1.Focus()
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
    Private Sub ProductosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Bd1DataSet)

    End Sub

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Bd1DataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.Bd1DataSet.Productos)
        Me.KeyPreview = True
        TextBox1.Focus()
        Hra.Start()
        fcha.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Menu1.Show()
    End Sub
    Private Sub Ventas_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F12
                Button10.PerformClick() ' Simula click en el botón 10 (Cobrar)
            Case Keys.F11
                Button11.PerformClick() ' Simula click en el botón 11 (Limpiar)
        End Select
    End Sub


#Region "Hora y fecha"
    Private Sub Hra_Tick(sender As Object, e As EventArgs) Handles Hra.Tick
        hora.Text = TimeOfDay.TimeOfDay.ToString
    End Sub
    Private Sub fcha_Tick_1(sender As Object, e As EventArgs) Handles fcha.Tick
        fecha.Text = DateString
    End Sub
#End Region

#Region "guardar en el historial"



#End Region
End Class