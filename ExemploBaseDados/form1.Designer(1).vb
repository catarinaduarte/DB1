<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ISBNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TítuloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PreçoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResumoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CódigoEditoraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantidadeStockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LivroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LivrosDataSet = New ExemploBaseDados.LivrosDataSet()
        Me.LivroTableAdapter = New ExemploBaseDados.LivrosDataSetTableAdapters.LivroTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LivroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LivrosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Exemplo Base de Dados- Biblioteca"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ISBNDataGridViewTextBoxColumn, Me.TítuloDataGridViewTextBoxColumn, Me.PreçoDataGridViewTextBoxColumn, Me.ResumoDataGridViewTextBoxColumn, Me.CódigoEditoraDataGridViewTextBoxColumn, Me.QuantidadeStockDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.LivroBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(56, 88)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(715, 312)
        Me.DataGridView1.TabIndex = 1
        '
        'ISBNDataGridViewTextBoxColumn
        '
        Me.ISBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN"
        Me.ISBNDataGridViewTextBoxColumn.HeaderText = "ISBN"
        Me.ISBNDataGridViewTextBoxColumn.Name = "ISBNDataGridViewTextBoxColumn"
        '
        'TítuloDataGridViewTextBoxColumn
        '
        Me.TítuloDataGridViewTextBoxColumn.DataPropertyName = "Título"
        Me.TítuloDataGridViewTextBoxColumn.HeaderText = "Título"
        Me.TítuloDataGridViewTextBoxColumn.Name = "TítuloDataGridViewTextBoxColumn"
        '
        'PreçoDataGridViewTextBoxColumn
        '
        Me.PreçoDataGridViewTextBoxColumn.DataPropertyName = "Preço"
        Me.PreçoDataGridViewTextBoxColumn.HeaderText = "Preço"
        Me.PreçoDataGridViewTextBoxColumn.Name = "PreçoDataGridViewTextBoxColumn"
        '
        'ResumoDataGridViewTextBoxColumn
        '
        Me.ResumoDataGridViewTextBoxColumn.DataPropertyName = "Resumo"
        Me.ResumoDataGridViewTextBoxColumn.HeaderText = "Resumo"
        Me.ResumoDataGridViewTextBoxColumn.Name = "ResumoDataGridViewTextBoxColumn"
        '
        'CódigoEditoraDataGridViewTextBoxColumn
        '
        Me.CódigoEditoraDataGridViewTextBoxColumn.DataPropertyName = "Código Editora"
        Me.CódigoEditoraDataGridViewTextBoxColumn.HeaderText = "Código Editora"
        Me.CódigoEditoraDataGridViewTextBoxColumn.Name = "CódigoEditoraDataGridViewTextBoxColumn"
        '
        'QuantidadeStockDataGridViewTextBoxColumn
        '
        Me.QuantidadeStockDataGridViewTextBoxColumn.DataPropertyName = "Quantidade Stock"
        Me.QuantidadeStockDataGridViewTextBoxColumn.HeaderText = "Quantidade Stock"
        Me.QuantidadeStockDataGridViewTextBoxColumn.Name = "QuantidadeStockDataGridViewTextBoxColumn"
        '
        'LivroBindingSource
        '
        Me.LivroBindingSource.DataMember = "Livro"
        Me.LivroBindingSource.DataSource = Me.LivrosDataSet
        '
        'LivrosDataSet
        '
        Me.LivrosDataSet.DataSetName = "LivrosDataSet"
        Me.LivrosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LivroTableAdapter
        '
        Me.LivroTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(677, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(696, 41)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LivroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LivrosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LivrosDataSet As LivrosDataSet
    Friend WithEvents LivroBindingSource As BindingSource
    Friend WithEvents LivroTableAdapter As LivrosDataSetTableAdapters.LivroTableAdapter
    Friend WithEvents ISBNDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TítuloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PreçoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ResumoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CódigoEditoraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantidadeStockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
