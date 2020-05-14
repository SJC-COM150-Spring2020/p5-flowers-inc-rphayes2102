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
        Me.lblOr = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnQuiz = New System.Windows.Forms.Button()
        Me.btnBouquet = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblOr
        '
        Me.lblOr.AutoSize = True
        Me.lblOr.Location = New System.Drawing.Point(155, 132)
        Me.lblOr.Name = "lblOr"
        Me.lblOr.Size = New System.Drawing.Size(18, 13)
        Me.lblOr.TabIndex = 2
        Me.lblOr.Text = "Or"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(127, 257)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnQuiz
        '
        Me.btnQuiz.Location = New System.Drawing.Point(109, 51)
        Me.btnQuiz.Name = "btnQuiz"
        Me.btnQuiz.Size = New System.Drawing.Size(123, 22)
        Me.btnQuiz.TabIndex = 6
        Me.btnQuiz.Text = "Take the Quiz"
        Me.btnQuiz.UseVisualStyleBackColor = True
        '
        'btnBouquet
        '
        Me.btnBouquet.Location = New System.Drawing.Point(109, 182)
        Me.btnBouquet.Name = "btnBouquet"
        Me.btnBouquet.Size = New System.Drawing.Size(123, 23)
        Me.btnBouquet.TabIndex = 7
        Me.btnBouquet.Text = "Build your Bouquet "
        Me.btnBouquet.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 309)
        Me.Controls.Add(Me.btnBouquet)
        Me.Controls.Add(Me.btnQuiz)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblOr)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblOr As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnQuiz As Button
    Friend WithEvents btnBouquet As Button
End Class
