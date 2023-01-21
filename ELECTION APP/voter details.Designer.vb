<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class voter_details
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(voter_details))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegDataSet2 = New election_app.regDataSet2()
        Me.DataTableAdapter = New election_app.regDataSet2TableAdapters.dataTableAdapter()
        Me.SnamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FnamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MdnmDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HallDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdxDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SnamDataGridViewTextBoxColumn, Me.FnamDataGridViewTextBoxColumn, Me.MdnmDataGridViewTextBoxColumn, Me.ClsDataGridViewTextBoxColumn, Me.HallDataGridViewTextBoxColumn, Me.IdxDataGridViewTextBoxColumn, Me.CosDataGridViewTextBoxColumn, Me.IdDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DataBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(894, 509)
        Me.DataGridView1.TabIndex = 0
        '
        'DataBindingSource
        '
        Me.DataBindingSource.DataMember = "data"
        Me.DataBindingSource.DataSource = Me.RegDataSet2
        '
        'RegDataSet2
        '
        Me.RegDataSet2.DataSetName = "regDataSet2"
        Me.RegDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataTableAdapter
        '
        Me.DataTableAdapter.ClearBeforeFill = True
        '
        'SnamDataGridViewTextBoxColumn
        '
        Me.SnamDataGridViewTextBoxColumn.DataPropertyName = "snam"
        Me.SnamDataGridViewTextBoxColumn.HeaderText = "Surname"
        Me.SnamDataGridViewTextBoxColumn.Name = "SnamDataGridViewTextBoxColumn"
        Me.SnamDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FnamDataGridViewTextBoxColumn
        '
        Me.FnamDataGridViewTextBoxColumn.DataPropertyName = "fnam"
        Me.FnamDataGridViewTextBoxColumn.HeaderText = "Firstname"
        Me.FnamDataGridViewTextBoxColumn.Name = "FnamDataGridViewTextBoxColumn"
        Me.FnamDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MdnmDataGridViewTextBoxColumn
        '
        Me.MdnmDataGridViewTextBoxColumn.DataPropertyName = "mdnm"
        Me.MdnmDataGridViewTextBoxColumn.HeaderText = "Middlename"
        Me.MdnmDataGridViewTextBoxColumn.Name = "MdnmDataGridViewTextBoxColumn"
        Me.MdnmDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClsDataGridViewTextBoxColumn
        '
        Me.ClsDataGridViewTextBoxColumn.DataPropertyName = "cls"
        Me.ClsDataGridViewTextBoxColumn.HeaderText = "Class"
        Me.ClsDataGridViewTextBoxColumn.Name = "ClsDataGridViewTextBoxColumn"
        Me.ClsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HallDataGridViewTextBoxColumn
        '
        Me.HallDataGridViewTextBoxColumn.DataPropertyName = "hall"
        Me.HallDataGridViewTextBoxColumn.HeaderText = "Hall"
        Me.HallDataGridViewTextBoxColumn.Name = "HallDataGridViewTextBoxColumn"
        Me.HallDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdxDataGridViewTextBoxColumn
        '
        Me.IdxDataGridViewTextBoxColumn.DataPropertyName = "idx"
        Me.IdxDataGridViewTextBoxColumn.HeaderText = "Index No."
        Me.IdxDataGridViewTextBoxColumn.Name = "IdxDataGridViewTextBoxColumn"
        Me.IdxDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CosDataGridViewTextBoxColumn
        '
        Me.CosDataGridViewTextBoxColumn.DataPropertyName = "cos"
        Me.CosDataGridViewTextBoxColumn.HeaderText = "Course"
        Me.CosDataGridViewTextBoxColumn.Name = "CosDataGridViewTextBoxColumn"
        Me.CosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'voter_details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 509)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "voter_details"
        Me.Text = "VOTER DETAILS"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents RegDataSet2 As election_app.regDataSet2
    Friend WithEvents DataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataTableAdapter As election_app.regDataSet2TableAdapters.dataTableAdapter
    Friend WithEvents SnamDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FnamDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MdnmDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HallDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdxDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
