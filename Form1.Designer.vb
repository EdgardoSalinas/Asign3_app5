<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.txt_costo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_pctganancia = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_impuesto = New System.Windows.Forms.TextBox()
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_costototalauto = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 12)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(758, 180)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'txt_costo
        '
        Me.txt_costo.Location = New System.Drawing.Point(354, 218)
        Me.txt_costo.Name = "txt_costo"
        Me.txt_costo.Size = New System.Drawing.Size(208, 26)
        Me.txt_costo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(138, 221)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Costo del automovil:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(138, 261)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Porcentaje Vendedor:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_pctganancia
        '
        Me.txt_pctganancia.Location = New System.Drawing.Point(354, 255)
        Me.txt_pctganancia.Name = "txt_pctganancia"
        Me.txt_pctganancia.Size = New System.Drawing.Size(208, 26)
        Me.txt_pctganancia.TabIndex = 4
        Me.txt_pctganancia.Text = "12"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(138, 299)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Impuesto:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_impuesto
        '
        Me.txt_impuesto.Location = New System.Drawing.Point(354, 299)
        Me.txt_impuesto.Name = "txt_impuesto"
        Me.txt_impuesto.Size = New System.Drawing.Size(208, 26)
        Me.txt_impuesto.TabIndex = 6
        Me.txt_impuesto.Text = "6"
        '
        'btn_calcular
        '
        Me.btn_calcular.Location = New System.Drawing.Point(354, 389)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(208, 49)
        Me.btn_calcular.TabIndex = 7
        Me.btn_calcular.Text = "Calcular"
        Me.btn_calcular.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(138, 348)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Costo Total del Auto:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt_costototalauto
        '
        Me.txt_costototalauto.Location = New System.Drawing.Point(354, 342)
        Me.txt_costototalauto.Name = "txt_costototalauto"
        Me.txt_costototalauto.Size = New System.Drawing.Size(208, 26)
        Me.txt_costototalauto.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txt_costototalauto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_calcular)
        Me.Controls.Add(Me.txt_impuesto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_pctganancia)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_costo)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Name = "Form1"
        Me.Text = "Asignacion3_app5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents txt_costo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_pctganancia As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_impuesto As TextBox
    Friend WithEvents btn_calcular As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_costototalauto As TextBox
End Class
