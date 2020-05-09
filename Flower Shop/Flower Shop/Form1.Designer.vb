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
        Me.txtQuiz = New System.Windows.Forms.TextBox()
        Me.txtBouquet = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
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
        'txtQuiz
        '
        Me.txtQuiz.Location = New System.Drawing.Point(99, 56)
        Me.txtQuiz.Name = "txtQuiz"
        Me.txtQuiz.Size = New System.Drawing.Size(142, 20)
        Me.txtQuiz.TabIndex = 3
        Me.txtQuiz.Text = "Take The Quiz "
        '
        'txtBouquet
        '
        Me.txtBouquet.Location = New System.Drawing.Point(99, 179)
        Me.txtBouquet.Name = "txtBouquet"
        Me.txtBouquet.Size = New System.Drawing.Size(156, 20)
        Me.txtBouquet.TabIndex = 4
        Me.txtBouquet.Text = "Build Your Bouquet"
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 309)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtBouquet)
        Me.Controls.Add(Me.txtQuiz)
        Me.Controls.Add(Me.lblOr)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblOr As Label
    Friend WithEvents txtQuiz As TextBox
    Friend WithEvents txtBouquet As TextBox
    Friend WithEvents btnExit As Button
End Class
