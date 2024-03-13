<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.btnAgregarRegistro = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdcuentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUENTASBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BancoDataSet2 = New proyectoBanco2._0.BancoDataSet2()
        Me.CUENTASBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BancoDataSet1 = New proyectoBanco2._0.BancoDataSet1()
        Me.CuentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BancoDataSet = New proyectoBanco2._0.BancoDataSet()
        Me.CuentasTableAdapter = New proyectoBanco2._0.BancoDataSetTableAdapters.cuentasTableAdapter()
        Me.CUENTASTableAdapter1 = New proyectoBanco2._0.BancoDataSet1TableAdapters.CUENTASTableAdapter()
        Me.CUENTASTableAdapter2 = New proyectoBanco2._0.BancoDataSet2TableAdapters.CUENTASTableAdapter()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.BANCODataSet3 = New proyectoBanco2._0.BANCODataSet3()
        Me.CUENTASBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CUENTASTableAdapter3 = New proyectoBanco2._0.BANCODataSet3TableAdapters.CUENTASTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CUENTASBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BancoDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CUENTASBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BancoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BancoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BANCODataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CUENTASBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Apellidos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombres"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Saldo"
        '
        'txtApellidos
        '
        Me.txtApellidos.Location = New System.Drawing.Point(120, 66)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(359, 20)
        Me.txtApellidos.TabIndex = 3
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(120, 100)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(359, 20)
        Me.txtNombre.TabIndex = 4
        '
        'txtSaldo
        '
        Me.txtSaldo.Location = New System.Drawing.Point(120, 136)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(175, 20)
        Me.txtSaldo.TabIndex = 5
        '
        'btnAgregarRegistro
        '
        Me.btnAgregarRegistro.Location = New System.Drawing.Point(120, 179)
        Me.btnAgregarRegistro.Name = "btnAgregarRegistro"
        Me.btnAgregarRegistro.Size = New System.Drawing.Size(100, 23)
        Me.btnAgregarRegistro.TabIndex = 6
        Me.btnAgregarRegistro.Text = "Agregar Registro"
        Me.btnAgregarRegistro.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdcuentaDataGridViewTextBoxColumn, Me.ApellidosDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.SaldoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CUENTASBindingSource3
        Me.DataGridView1.Location = New System.Drawing.Point(10, 225)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(562, 250)
        Me.DataGridView1.TabIndex = 7
        '
        'IdcuentaDataGridViewTextBoxColumn
        '
        Me.IdcuentaDataGridViewTextBoxColumn.DataPropertyName = "idcuenta"
        Me.IdcuentaDataGridViewTextBoxColumn.HeaderText = "idcuenta"
        Me.IdcuentaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdcuentaDataGridViewTextBoxColumn.Name = "IdcuentaDataGridViewTextBoxColumn"
        Me.IdcuentaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdcuentaDataGridViewTextBoxColumn.Width = 125
        '
        'ApellidosDataGridViewTextBoxColumn
        '
        Me.ApellidosDataGridViewTextBoxColumn.DataPropertyName = "apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.HeaderText = "apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ApellidosDataGridViewTextBoxColumn.Name = "ApellidosDataGridViewTextBoxColumn"
        Me.ApellidosDataGridViewTextBoxColumn.Width = 125
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.Width = 125
        '
        'SaldoDataGridViewTextBoxColumn
        '
        Me.SaldoDataGridViewTextBoxColumn.DataPropertyName = "saldo"
        Me.SaldoDataGridViewTextBoxColumn.HeaderText = "saldo"
        Me.SaldoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SaldoDataGridViewTextBoxColumn.Name = "SaldoDataGridViewTextBoxColumn"
        Me.SaldoDataGridViewTextBoxColumn.Width = 125
        '
        'CUENTASBindingSource2
        '
        Me.CUENTASBindingSource2.DataMember = "CUENTAS"
        Me.CUENTASBindingSource2.DataSource = Me.BancoDataSet2
        '
        'BancoDataSet2
        '
        Me.BancoDataSet2.DataSetName = "BancoDataSet2"
        Me.BancoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CUENTASBindingSource1
        '
        Me.CUENTASBindingSource1.DataMember = "CUENTAS"
        Me.CUENTASBindingSource1.DataSource = Me.BancoDataSet1
        '
        'BancoDataSet1
        '
        Me.BancoDataSet1.DataSetName = "BancoDataSet1"
        Me.BancoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CuentasBindingSource
        '
        Me.CuentasBindingSource.DataMember = "cuentas"
        Me.CuentasBindingSource.DataSource = Me.BancoDataSet
        '
        'BancoDataSet
        '
        Me.BancoDataSet.DataSetName = "BancoDataSet"
        Me.BancoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CuentasTableAdapter
        '
        Me.CuentasTableAdapter.ClearBeforeFill = True
        '
        'CUENTASTableAdapter1
        '
        Me.CUENTASTableAdapter1.ClearBeforeFill = True
        '
        'CUENTASTableAdapter2
        '
        Me.CUENTASTableAdapter2.ClearBeforeFill = True
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(238, 179)
        Me.btnIngresar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(95, 23)
        Me.btnIngresar.TabIndex = 8
        Me.btnIngresar.Text = "Ingresar cuentas"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'BANCODataSet3
        '
        Me.BANCODataSet3.DataSetName = "BANCODataSet3"
        Me.BANCODataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CUENTASBindingSource3
        '
        Me.CUENTASBindingSource3.DataMember = "CUENTAS"
        Me.CUENTASBindingSource3.DataSource = Me.BANCODataSet3
        '
        'CUENTASTableAdapter3
        '
        Me.CUENTASTableAdapter3.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 487)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnAgregarRegistro)
        Me.Controls.Add(Me.txtSaldo)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtApellidos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CUENTASBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BancoDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CUENTASBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BancoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BancoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BANCODataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CUENTASBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents btnAgregarRegistro As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BancoDataSet As BancoDataSet
    Friend WithEvents CuentasBindingSource As BindingSource
    Friend WithEvents CuentasTableAdapter As BancoDataSetTableAdapters.cuentasTableAdapter
    Friend WithEvents IdcuentaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaldoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BancoDataSet1 As BancoDataSet1
    Friend WithEvents CUENTASBindingSource1 As BindingSource
    Friend WithEvents CUENTASTableAdapter1 As BancoDataSet1TableAdapters.CUENTASTableAdapter
    Friend WithEvents BancoDataSet2 As BancoDataSet2
    Friend WithEvents CUENTASBindingSource2 As BindingSource
    Friend WithEvents CUENTASTableAdapter2 As BancoDataSet2TableAdapters.CUENTASTableAdapter
    Friend WithEvents btnIngresar As Button
    Friend WithEvents BANCODataSet3 As BANCODataSet3
    Friend WithEvents CUENTASBindingSource3 As BindingSource
    Friend WithEvents CUENTASTableAdapter3 As BANCODataSet3TableAdapters.CUENTASTableAdapter
End Class
