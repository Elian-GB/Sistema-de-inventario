<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inventario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IdLabel As System.Windows.Forms.Label
        Dim CodigoLabel As System.Windows.Forms.Label
        Dim ProductoLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim PrecioLabel As System.Windows.Forms.Label
        Dim ExistenciaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventario))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnMinimizar = New System.Windows.Forms.PictureBox()
        Me.BtnSalir = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Bd1DataSet = New minisupermelillo.bd1DataSet()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ProductosTableAdapter = New minisupermelillo.bd1DataSetTableAdapters.ProductosTableAdapter()
        Me.TableAdapterManager = New minisupermelillo.bd1DataSetTableAdapters.TableAdapterManager()
        Me.ProductosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.CodigoTextBox = New System.Windows.Forms.TextBox()
        Me.ProductoTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioTextBox = New System.Windows.Forms.TextBox()
        Me.ExistenciaTextBox = New System.Windows.Forms.TextBox()
        Me.ImagenPictureBox = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Button6 = New System.Windows.Forms.Button()
        IdLabel = New System.Windows.Forms.Label()
        CodigoLabel = New System.Windows.Forms.Label()
        ProductoLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        PrecioLabel = New System.Windows.Forms.Label()
        ExistenciaLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.BtnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bd1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagenPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(-70, 3)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(19, 14)
        IdLabel.TabIndex = 57
        IdLabel.Text = "id:"
        IdLabel.Visible = False
        '
        'CodigoLabel
        '
        CodigoLabel.AutoSize = True
        CodigoLabel.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CodigoLabel.Location = New System.Drawing.Point(16, 65)
        CodigoLabel.Name = "CodigoLabel"
        CodigoLabel.Size = New System.Drawing.Size(54, 16)
        CodigoLabel.TabIndex = 59
        CodigoLabel.Text = "Codigo:"
        '
        'ProductoLabel
        '
        ProductoLabel.AutoSize = True
        ProductoLabel.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ProductoLabel.Location = New System.Drawing.Point(16, 93)
        ProductoLabel.Name = "ProductoLabel"
        ProductoLabel.Size = New System.Drawing.Size(64, 16)
        ProductoLabel.TabIndex = 61
        ProductoLabel.Text = "Producto:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescripcionLabel.Location = New System.Drawing.Point(16, 124)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(76, 16)
        DescripcionLabel.TabIndex = 63
        DescripcionLabel.Text = "Descripcion:"
        '
        'PrecioLabel
        '
        PrecioLabel.AutoSize = True
        PrecioLabel.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PrecioLabel.Location = New System.Drawing.Point(16, 187)
        PrecioLabel.Name = "PrecioLabel"
        PrecioLabel.Size = New System.Drawing.Size(46, 16)
        PrecioLabel.TabIndex = 65
        PrecioLabel.Text = "Precio:"
        '
        'ExistenciaLabel
        '
        ExistenciaLabel.AutoSize = True
        ExistenciaLabel.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ExistenciaLabel.Location = New System.Drawing.Point(16, 215)
        ExistenciaLabel.Name = "ExistenciaLabel"
        ExistenciaLabel.Size = New System.Drawing.Size(64, 16)
        ExistenciaLabel.TabIndex = 67
        ExistenciaLabel.Text = "Existencia:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.BtnMinimizar)
        Me.Panel1.Controls.Add(Me.BtnSalir)
        Me.Panel1.Controls.Add(IdLabel)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(876, 42)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Maiandra GD", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 25)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "INVENTARIO"
        '
        'BtnMinimizar
        '
        Me.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMinimizar.Image = Global.minisupermelillo.My.Resources.Resources.Minimizar
        Me.BtnMinimizar.Location = New System.Drawing.Point(806, 3)
        Me.BtnMinimizar.Name = "BtnMinimizar"
        Me.BtnMinimizar.Size = New System.Drawing.Size(30, 33)
        Me.BtnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnMinimizar.TabIndex = 5
        Me.BtnMinimizar.TabStop = False
        '
        'BtnSalir
        '
        Me.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalir.Image = Global.minisupermelillo.My.Resources.Resources.Cerrar
        Me.BtnSalir.Location = New System.Drawing.Point(842, 3)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(31, 33)
        Me.BtnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnSalir.TabIndex = 4
        Me.BtnSalir.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel2.Controls.Add(Me.IdTextBox)
        Me.Panel2.Location = New System.Drawing.Point(0, 379)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(876, 11)
        Me.Panel2.TabIndex = 1
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(0, 0)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(100, 21)
        Me.IdTextBox.TabIndex = 58
        Me.IdTextBox.Visible = False
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.Bd1DataSet
        '
        'Bd1DataSet
        '
        Me.Bd1DataSet.DataSetName = "bd1DataSet"
        Me.Bd1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(744, 309)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 52)
        Me.Button1.TabIndex = 52
        Me.Button1.Text = "Volver"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ProductosTableAdapter = Me.ProductosTableAdapter
        Me.TableAdapterManager.UpdateOrder = minisupermelillo.bd1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'ProductosDataGridView
        '
        Me.ProductosDataGridView.AutoGenerateColumns = False
        Me.ProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.ProductosDataGridView.DataSource = Me.ProductosBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Maiandra GD", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GrayText
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ProductosDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.ProductosDataGridView.Location = New System.Drawing.Point(357, 112)
        Me.ProductosDataGridView.Name = "ProductosDataGridView"
        Me.ProductosDataGridView.Size = New System.Drawing.Size(506, 164)
        Me.ProductosDataGridView.TabIndex = 53
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "codigo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "codigo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "producto"
        Me.DataGridViewTextBoxColumn3.HeaderText = "producto"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn4.HeaderText = "descripcion"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "precio"
        Me.DataGridViewTextBoxColumn5.HeaderText = "precio"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "existencia"
        Me.DataGridViewTextBoxColumn6.HeaderText = "existencia"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(357, 60)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(401, 21)
        Me.TextBox1.TabIndex = 54
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(764, 62)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(29, 19)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 55
        Me.PictureBox1.TabStop = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(460, 88)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(93, 20)
        Me.RadioButton2.TabIndex = 57
        Me.RadioButton2.Text = "Por nombre"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(364, 88)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(92, 20)
        Me.RadioButton1.TabIndex = 56
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Por Codigo"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "codigo", True))
        Me.CodigoTextBox.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoTextBox.Location = New System.Drawing.Point(96, 62)
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.Size = New System.Drawing.Size(130, 23)
        Me.CodigoTextBox.TabIndex = 60
        '
        'ProductoTextBox
        '
        Me.ProductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "producto", True))
        Me.ProductoTextBox.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductoTextBox.Location = New System.Drawing.Point(96, 90)
        Me.ProductoTextBox.Name = "ProductoTextBox"
        Me.ProductoTextBox.Size = New System.Drawing.Size(130, 23)
        Me.ProductoTextBox.TabIndex = 62
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "descripcion", True))
        Me.DescripcionTextBox.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(96, 121)
        Me.DescripcionTextBox.Multiline = True
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(130, 57)
        Me.DescripcionTextBox.TabIndex = 64
        '
        'PrecioTextBox
        '
        Me.PrecioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "precio", True))
        Me.PrecioTextBox.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrecioTextBox.Location = New System.Drawing.Point(96, 184)
        Me.PrecioTextBox.Name = "PrecioTextBox"
        Me.PrecioTextBox.Size = New System.Drawing.Size(130, 23)
        Me.PrecioTextBox.TabIndex = 66
        '
        'ExistenciaTextBox
        '
        Me.ExistenciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "existencia", True))
        Me.ExistenciaTextBox.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExistenciaTextBox.Location = New System.Drawing.Point(96, 212)
        Me.ExistenciaTextBox.Name = "ExistenciaTextBox"
        Me.ExistenciaTextBox.Size = New System.Drawing.Size(130, 23)
        Me.ExistenciaTextBox.TabIndex = 68
        '
        'ImagenPictureBox
        '
        Me.ImagenPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ImagenPictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImagenPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ProductosBindingSource, "imagen", True))
        Me.ImagenPictureBox.Location = New System.Drawing.Point(242, 124)
        Me.ImagenPictureBox.Name = "ImagenPictureBox"
        Me.ImagenPictureBox.Size = New System.Drawing.Size(100, 90)
        Me.ImagenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImagenPictureBox.TabIndex = 70
        Me.ImagenPictureBox.TabStop = False
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 2
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.LawnGreen
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(70, 262)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(119, 53)
        Me.Button2.TabIndex = 71
        Me.Button2.Text = "Editar Producto"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 2
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Red
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(253, 321)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(107, 52)
        Me.Button3.TabIndex = 72
        Me.Button3.Text = "Eliminar"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 2
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.OrangeRed
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(135, 321)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(112, 52)
        Me.Button4.TabIndex = 73
        Me.Button4.Text = "Guardar "
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderSize = 2
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Khaki
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(195, 262)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(119, 53)
        Me.Button5.TabIndex = 74
        Me.Button5.Text = "Agregar Producto"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(272, 90)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(42, 28)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 75
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(253, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 14)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Insertar imagen"
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(456, 298)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(71, 63)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 77
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(533, 298)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(70, 63)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 78
        Me.PictureBox4.TabStop = False
        '
        'Button6
        '
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.FlatAppearance.BorderSize = 2
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(19, 321)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(110, 52)
        Me.Button6.TabIndex = 80
        Me.Button6.Text = "Cancelar"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(875, 392)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(CodigoLabel)
        Me.Controls.Add(Me.CodigoTextBox)
        Me.Controls.Add(ProductoLabel)
        Me.Controls.Add(Me.ProductoTextBox)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(PrecioLabel)
        Me.Controls.Add(Me.PrecioTextBox)
        Me.Controls.Add(ExistenciaLabel)
        Me.Controls.Add(Me.ExistenciaTextBox)
        Me.Controls.Add(Me.ImagenPictureBox)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ProductosDataGridView)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Maiandra GD", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Inventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventario"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BtnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bd1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagenPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnMinimizar As PictureBox
    Friend WithEvents BtnSalir As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Bd1DataSet As bd1DataSet
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents ProductosTableAdapter As bd1DataSetTableAdapters.ProductosTableAdapter
    Friend WithEvents TableAdapterManager As bd1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents CodigoTextBox As TextBox
    Friend WithEvents ProductoTextBox As TextBox
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents PrecioTextBox As TextBox
    Friend WithEvents ExistenciaTextBox As TextBox
    Friend WithEvents ImagenPictureBox As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Button6 As Button
End Class
