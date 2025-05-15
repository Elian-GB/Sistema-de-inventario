<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ventas
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
        Dim ImagenLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ventas))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnMinimizar = New System.Windows.Forms.PictureBox()
        Me.BtnSalir = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.ProductosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Bd1DataSet = New minisupermelillo.bd1DataSet()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.ProductosTableAdapter = New minisupermelillo.bd1DataSetTableAdapters.ProductosTableAdapter()
        Me.TableAdapterManager = New minisupermelillo.bd1DataSetTableAdapters.TableAdapterManager()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.CodigoTextBox = New System.Windows.Forms.TextBox()
        Me.ProductoTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioTextBox = New System.Windows.Forms.TextBox()
        Me.ExistenciaTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ImagenPictureBox = New System.Windows.Forms.PictureBox()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        IdLabel = New System.Windows.Forms.Label()
        CodigoLabel = New System.Windows.Forms.Label()
        ProductoLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        PrecioLabel = New System.Windows.Forms.Label()
        ExistenciaLabel = New System.Windows.Forms.Label()
        ImagenLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.BtnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bd1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagenPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(780, 246)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(18, 13)
        IdLabel.TabIndex = 37
        IdLabel.Text = "id:"
        IdLabel.Visible = False
        '
        'CodigoLabel
        '
        CodigoLabel.AutoSize = True
        CodigoLabel.Location = New System.Drawing.Point(780, 272)
        CodigoLabel.Name = "CodigoLabel"
        CodigoLabel.Size = New System.Drawing.Size(42, 13)
        CodigoLabel.TabIndex = 39
        CodigoLabel.Text = "codigo:"
        CodigoLabel.Visible = False
        '
        'ProductoLabel
        '
        ProductoLabel.AutoSize = True
        ProductoLabel.Location = New System.Drawing.Point(780, 298)
        ProductoLabel.Name = "ProductoLabel"
        ProductoLabel.Size = New System.Drawing.Size(52, 13)
        ProductoLabel.TabIndex = 41
        ProductoLabel.Text = "producto:"
        ProductoLabel.Visible = False
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(780, 324)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(64, 13)
        DescripcionLabel.TabIndex = 43
        DescripcionLabel.Text = "descripcion:"
        DescripcionLabel.Visible = False
        '
        'PrecioLabel
        '
        PrecioLabel.AutoSize = True
        PrecioLabel.Location = New System.Drawing.Point(780, 350)
        PrecioLabel.Name = "PrecioLabel"
        PrecioLabel.Size = New System.Drawing.Size(39, 13)
        PrecioLabel.TabIndex = 45
        PrecioLabel.Text = "precio:"
        PrecioLabel.Visible = False
        '
        'ExistenciaLabel
        '
        ExistenciaLabel.AutoSize = True
        ExistenciaLabel.Location = New System.Drawing.Point(780, 376)
        ExistenciaLabel.Name = "ExistenciaLabel"
        ExistenciaLabel.Size = New System.Drawing.Size(57, 13)
        ExistenciaLabel.TabIndex = 47
        ExistenciaLabel.Text = "existencia:"
        ExistenciaLabel.Visible = False
        '
        'ImagenLabel
        '
        ImagenLabel.AutoSize = True
        ImagenLabel.Location = New System.Drawing.Point(780, 399)
        ImagenLabel.Name = "ImagenLabel"
        ImagenLabel.Size = New System.Drawing.Size(44, 13)
        ImagenLabel.TabIndex = 49
        ImagenLabel.Text = "imagen:"
        ImagenLabel.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.BtnMinimizar)
        Me.Panel1.Controls.Add(Me.BtnSalir)
        Me.Panel1.Location = New System.Drawing.Point(-1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(801, 40)
        Me.Panel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Maiandra GD", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(13, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 25)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "VENTAS"
        '
        'BtnMinimizar
        '
        Me.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMinimizar.Image = Global.minisupermelillo.My.Resources.Resources.Minimizar
        Me.BtnMinimizar.Location = New System.Drawing.Point(722, 3)
        Me.BtnMinimizar.Name = "BtnMinimizar"
        Me.BtnMinimizar.Size = New System.Drawing.Size(30, 31)
        Me.BtnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnMinimizar.TabIndex = 5
        Me.BtnMinimizar.TabStop = False
        '
        'BtnSalir
        '
        Me.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalir.Image = Global.minisupermelillo.My.Resources.Resources.Cerrar
        Me.BtnSalir.Location = New System.Drawing.Point(758, 3)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(31, 31)
        Me.BtnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnSalir.TabIndex = 4
        Me.BtnSalir.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel2.Controls.Add(Me.RadioButton2)
        Me.Panel2.Controls.Add(Me.RadioButton1)
        Me.Panel2.Controls.Add(Me.ProductosDataGridView)
        Me.Panel2.Location = New System.Drawing.Point(2, 392)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(801, 14)
        Me.Panel2.TabIndex = 1
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Maiandra GD", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(403, -7)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(82, 18)
        Me.RadioButton2.TabIndex = 25
        Me.RadioButton2.Text = "Por nombre"
        Me.RadioButton2.UseVisualStyleBackColor = True
        Me.RadioButton2.Visible = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Maiandra GD", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(265, -7)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(81, 18)
        Me.RadioButton1.TabIndex = 24
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Por Codigo"
        Me.RadioButton1.UseVisualStyleBackColor = True
        Me.RadioButton1.Visible = False
        '
        'ProductosDataGridView
        '
        Me.ProductosDataGridView.AutoGenerateColumns = False
        Me.ProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewImageColumn1})
        Me.ProductosDataGridView.DataSource = Me.ProductosBindingSource
        Me.ProductosDataGridView.Location = New System.Drawing.Point(0, -9)
        Me.ProductosDataGridView.Name = "ProductosDataGridView"
        Me.ProductosDataGridView.Size = New System.Drawing.Size(112, 93)
        Me.ProductosDataGridView.TabIndex = 37
        Me.ProductosDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
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
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "imagen"
        Me.DataGridViewImageColumn1.HeaderText = "imagen"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
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
        'ListBox3
        '
        Me.ListBox3.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 16
        Me.ListBox3.Location = New System.Drawing.Point(258, 85)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(120, 292)
        Me.ListBox3.TabIndex = 23
        '
        'ListBox2
        '
        Me.ListBox2.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 16
        Me.ListBox2.Location = New System.Drawing.Point(132, 85)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(120, 292)
        Me.ListBox2.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(15, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 18)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Productos"
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(6, 85)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 292)
        Me.ListBox1.TabIndex = 21
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Maiandra GD", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(456, 94)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(327, 21)
        Me.TextBox1.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(146, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 18)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Cantidad"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(255, 55)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 18)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Total producto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(396, 293)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 16)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Total:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(396, 324)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 16)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Pago:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(391, 358)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 16)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Vuelto: "
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(456, 293)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(120, 23)
        Me.TextBox2.TabIndex = 34
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(456, 323)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(120, 23)
        Me.TextBox3.TabIndex = 35
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(456, 354)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(120, 23)
        Me.TextBox4.TabIndex = 36
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
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(850, 243)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdTextBox.TabIndex = 38
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "codigo", True))
        Me.CodigoTextBox.Location = New System.Drawing.Point(850, 269)
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodigoTextBox.TabIndex = 40
        '
        'ProductoTextBox
        '
        Me.ProductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "producto", True))
        Me.ProductoTextBox.Location = New System.Drawing.Point(850, 295)
        Me.ProductoTextBox.Name = "ProductoTextBox"
        Me.ProductoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ProductoTextBox.TabIndex = 42
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(850, 321)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DescripcionTextBox.TabIndex = 44
        '
        'PrecioTextBox
        '
        Me.PrecioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "precio", True))
        Me.PrecioTextBox.Location = New System.Drawing.Point(850, 347)
        Me.PrecioTextBox.Name = "PrecioTextBox"
        Me.PrecioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PrecioTextBox.TabIndex = 46
        '
        'ExistenciaTextBox
        '
        Me.ExistenciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "existencia", True))
        Me.ExistenciaTextBox.Location = New System.Drawing.Point(850, 373)
        Me.ExistenciaTextBox.Name = "ExistenciaTextBox"
        Me.ExistenciaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ExistenciaTextBox.TabIndex = 48
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Maiandra GD", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(446, 198)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 14)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "(F11)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Maiandra GD", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(446, 272)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 14)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "(F12)"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(388, 85)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 52
        Me.PictureBox1.TabStop = False
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
        Me.Button1.Location = New System.Drawing.Point(669, 331)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 48)
        Me.Button1.TabIndex = 51
        Me.Button1.Text = "Volver"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ImagenPictureBox
        '
        Me.ImagenPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ProductosBindingSource, "imagen", True))
        Me.ImagenPictureBox.Location = New System.Drawing.Point(593, 141)
        Me.ImagenPictureBox.Name = "ImagenPictureBox"
        Me.ImagenPictureBox.Size = New System.Drawing.Size(128, 129)
        Me.ImagenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImagenPictureBox.TabIndex = 50
        Me.ImagenPictureBox.TabStop = False
        '
        'Button11
        '
        Me.Button11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button11.FlatAppearance.BorderSize = 2
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.ForeColor = System.Drawing.Color.AliceBlue
        Me.Button11.Image = CType(resources.GetObject("Button11.Image"), System.Drawing.Image)
        Me.Button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button11.Location = New System.Drawing.Point(405, 141)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(119, 54)
        Me.Button11.TabIndex = 30
        Me.Button11.Text = "Nueva Venta "
        Me.Button11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button10.FlatAppearance.BorderSize = 2
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.BurlyWood
        Me.Button10.Image = CType(resources.GetObject("Button10.Image"), System.Drawing.Image)
        Me.Button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button10.Location = New System.Drawing.Point(405, 213)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(119, 57)
        Me.Button10.TabIndex = 29
        Me.Button10.Text = "Cobrar"
        Me.Button10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(794, 406)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
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
        Me.Controls.Add(ImagenLabel)
        Me.Controls.Add(Me.ImagenPictureBox)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BtnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bd1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagenPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnMinimizar As PictureBox
    Friend WithEvents BtnSalir As PictureBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Bd1DataSet As bd1DataSet
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents ProductosTableAdapter As bd1DataSetTableAdapters.ProductosTableAdapter
    Friend WithEvents TableAdapterManager As bd1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents CodigoTextBox As TextBox
    Friend WithEvents ProductoTextBox As TextBox
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents PrecioTextBox As TextBox
    Friend WithEvents ExistenciaTextBox As TextBox
    Friend WithEvents ImagenPictureBox As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
