<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.radRoses = New System.Windows.Forms.RadioButton()
        Me.radTulips = New System.Windows.Forms.RadioButton()
        Me.radDaisies = New System.Windows.Forms.RadioButton()
        Me.radDaffodils = New System.Windows.Forms.RadioButton()
        Me.radSunflowers = New System.Windows.Forms.RadioButton()
        Me.radLilies = New System.Windows.Forms.RadioButton()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'radRoses
        '
        Me.radRoses.AutoSize = True
        Me.radRoses.Location = New System.Drawing.Point(26, 43)
        Me.radRoses.Name = "radRoses"
        Me.radRoses.Size = New System.Drawing.Size(55, 17)
        Me.radRoses.TabIndex = 0
        Me.radRoses.TabStop = True
        Me.radRoses.Text = "Roses"
        Me.radRoses.UseVisualStyleBackColor = True
        '
        'radTulips
        '
        Me.radTulips.AutoSize = True
        Me.radTulips.Location = New System.Drawing.Point(26, 81)
        Me.radTulips.Name = "radTulips"
        Me.radTulips.Size = New System.Drawing.Size(56, 17)
        Me.radTulips.TabIndex = 1
        Me.radTulips.TabStop = True
        Me.radTulips.Text = "Tulips "
        Me.radTulips.UseVisualStyleBackColor = True
        '
        'radDaisies
        '
        Me.radDaisies.AutoSize = True
        Me.radDaisies.Location = New System.Drawing.Point(26, 115)
        Me.radDaisies.Name = "radDaisies"
        Me.radDaisies.Size = New System.Drawing.Size(62, 17)
        Me.radDaisies.TabIndex = 2
        Me.radDaisies.TabStop = True
        Me.radDaisies.Text = "Daisies "
        Me.radDaisies.UseVisualStyleBackColor = True
        '
        'radDaffodils
        '
        Me.radDaffodils.AutoSize = True
        Me.radDaffodils.Location = New System.Drawing.Point(26, 150)
        Me.radDaffodils.Name = "radDaffodils"
        Me.radDaffodils.Size = New System.Drawing.Size(69, 17)
        Me.radDaffodils.TabIndex = 3
        Me.radDaffodils.TabStop = True
        Me.radDaffodils.Text = "Daffodils "
        Me.radDaffodils.UseVisualStyleBackColor = True
        '
        'radSunflowers
        '
        Me.radSunflowers.AutoSize = True
        Me.radSunflowers.Location = New System.Drawing.Point(26, 187)
        Me.radSunflowers.Name = "radSunflowers"
        Me.radSunflowers.Size = New System.Drawing.Size(80, 17)
        Me.radSunflowers.TabIndex = 4
        Me.radSunflowers.TabStop = True
        Me.radSunflowers.Text = "Sunflowers "
        Me.radSunflowers.UseVisualStyleBackColor = True
        '
        'radLilies
        '
        Me.radLilies.AutoSize = True
        Me.radLilies.Location = New System.Drawing.Point(26, 221)
        Me.radLilies.Name = "radLilies"
        Me.radLilies.Size = New System.Drawing.Size(48, 17)
        Me.radLilies.TabIndex = 5
        Me.radLilies.TabStop = True
        Me.radLilies.Text = "Lilies"
        Me.radLilies.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(89, 291)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(258, 290)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(104, 23)
        Me.btnBack.TabIndex = 7
        Me.btnBack.Text = "Back to Menu"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(297, 43)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 8
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 339)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.radLilies)
        Me.Controls.Add(Me.radSunflowers)
        Me.Controls.Add(Me.radDaffodils)
        Me.Controls.Add(Me.radDaisies)
        Me.Controls.Add(Me.radTulips)
        Me.Controls.Add(Me.radRoses)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents radRoses As RadioButton
    Friend WithEvents radTulips As RadioButton
    Friend WithEvents radDaisies As RadioButton
    Friend WithEvents radDaffodils As RadioButton
    Friend WithEvents radSunflowers As RadioButton
    Friend WithEvents radLilies As RadioButton
    Friend WithEvents btnClear As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents TextBox1 As TextBox
End Class
