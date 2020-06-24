<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kitchen
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
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblEgg = New System.Windows.Forms.Label()
        Me.lblFlour = New System.Windows.Forms.Label()
        Me.lblSugar = New System.Windows.Forms.Label()
        Me.lblMilk = New System.Windows.Forms.Label()
        Me.lblButter = New System.Windows.Forms.Label()
        Me.lblOil = New System.Windows.Forms.Label()
        Me.lblPowder = New System.Windows.Forms.Label()
        Me.lblSalt = New System.Windows.Forms.Label()
        Me.txtEgg = New System.Windows.Forms.TextBox()
        Me.txtFlour = New System.Windows.Forms.TextBox()
        Me.txtSugar = New System.Windows.Forms.TextBox()
        Me.txtMilk = New System.Windows.Forms.TextBox()
        Me.txtButter = New System.Windows.Forms.TextBox()
        Me.txtOil = New System.Windows.Forms.TextBox()
        Me.txtPowder = New System.Windows.Forms.TextBox()
        Me.txtSalt = New System.Windows.Forms.TextBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDescription
        '
        Me.lblDescription.BackColor = System.Drawing.SystemColors.Control
        Me.lblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(58, 124)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(366, 154)
        Me.lblDescription.TabIndex = 1
        Me.lblDescription.Text = "Enter in the amount of" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ingredients you have using the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "suggesting measuring inc" & _
    "riments. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Use Decimals for Fractions." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Example: 1/2 = .5)"
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEgg
        '
        Me.lblEgg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEgg.Location = New System.Drawing.Point(175, 305)
        Me.lblEgg.Name = "lblEgg"
        Me.lblEgg.Size = New System.Drawing.Size(100, 23)
        Me.lblEgg.TabIndex = 2
        Me.lblEgg.Text = "Eggs"
        Me.lblEgg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFlour
        '
        Me.lblFlour.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlour.Location = New System.Drawing.Point(175, 345)
        Me.lblFlour.Name = "lblFlour"
        Me.lblFlour.Size = New System.Drawing.Size(100, 23)
        Me.lblFlour.TabIndex = 3
        Me.lblFlour.Text = "Flour (Cups)"
        Me.lblFlour.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSugar
        '
        Me.lblSugar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSugar.Location = New System.Drawing.Point(159, 385)
        Me.lblSugar.Name = "lblSugar"
        Me.lblSugar.Size = New System.Drawing.Size(116, 23)
        Me.lblSugar.TabIndex = 4
        Me.lblSugar.Text = "Sugar (Cups)"
        Me.lblSugar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMilk
        '
        Me.lblMilk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMilk.Location = New System.Drawing.Point(110, 425)
        Me.lblMilk.Name = "lblMilk"
        Me.lblMilk.Size = New System.Drawing.Size(165, 23)
        Me.lblMilk.TabIndex = 5
        Me.lblMilk.Text = "Milk (Cups)"
        Me.lblMilk.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblButter
        '
        Me.lblButter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblButter.Location = New System.Drawing.Point(106, 465)
        Me.lblButter.Name = "lblButter"
        Me.lblButter.Size = New System.Drawing.Size(169, 23)
        Me.lblButter.TabIndex = 6
        Me.lblButter.Text = "Butter (Tablespoons)"
        Me.lblButter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblOil
        '
        Me.lblOil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOil.Location = New System.Drawing.Point(47, 505)
        Me.lblOil.Name = "lblOil"
        Me.lblOil.Size = New System.Drawing.Size(228, 23)
        Me.lblOil.TabIndex = 7
        Me.lblOil.Text = "Vegetable Oil (Tablespoons)"
        Me.lblOil.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPowder
        '
        Me.lblPowder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPowder.Location = New System.Drawing.Point(63, 545)
        Me.lblPowder.Name = "lblPowder"
        Me.lblPowder.Size = New System.Drawing.Size(212, 23)
        Me.lblPowder.TabIndex = 8
        Me.lblPowder.Text = "Baking Powder (teaspoons)"
        Me.lblPowder.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSalt
        '
        Me.lblSalt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalt.Location = New System.Drawing.Point(114, 585)
        Me.lblSalt.Name = "lblSalt"
        Me.lblSalt.Size = New System.Drawing.Size(161, 23)
        Me.lblSalt.TabIndex = 9
        Me.lblSalt.Text = "Salt (teaspoons)"
        Me.lblSalt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEgg
        '
        Me.txtEgg.Location = New System.Drawing.Point(300, 305)
        Me.txtEgg.Name = "txtEgg"
        Me.txtEgg.Size = New System.Drawing.Size(100, 20)
        Me.txtEgg.TabIndex = 10
        Me.txtEgg.Text = "0"
        '
        'txtFlour
        '
        Me.txtFlour.Location = New System.Drawing.Point(300, 345)
        Me.txtFlour.Name = "txtFlour"
        Me.txtFlour.Size = New System.Drawing.Size(100, 20)
        Me.txtFlour.TabIndex = 11
        Me.txtFlour.Text = "0"
        '
        'txtSugar
        '
        Me.txtSugar.Location = New System.Drawing.Point(300, 385)
        Me.txtSugar.Name = "txtSugar"
        Me.txtSugar.Size = New System.Drawing.Size(100, 20)
        Me.txtSugar.TabIndex = 12
        Me.txtSugar.Text = "0"
        '
        'txtMilk
        '
        Me.txtMilk.Location = New System.Drawing.Point(300, 425)
        Me.txtMilk.Name = "txtMilk"
        Me.txtMilk.Size = New System.Drawing.Size(100, 20)
        Me.txtMilk.TabIndex = 13
        Me.txtMilk.Text = "0"
        '
        'txtButter
        '
        Me.txtButter.Location = New System.Drawing.Point(300, 465)
        Me.txtButter.Name = "txtButter"
        Me.txtButter.Size = New System.Drawing.Size(100, 20)
        Me.txtButter.TabIndex = 14
        Me.txtButter.Text = "0"
        '
        'txtOil
        '
        Me.txtOil.Location = New System.Drawing.Point(300, 505)
        Me.txtOil.Name = "txtOil"
        Me.txtOil.Size = New System.Drawing.Size(100, 20)
        Me.txtOil.TabIndex = 15
        Me.txtOil.Text = "0"
        '
        'txtPowder
        '
        Me.txtPowder.Location = New System.Drawing.Point(300, 545)
        Me.txtPowder.Name = "txtPowder"
        Me.txtPowder.Size = New System.Drawing.Size(100, 20)
        Me.txtPowder.TabIndex = 16
        Me.txtPowder.Text = "0"
        '
        'txtSalt
        '
        Me.txtSalt.Location = New System.Drawing.Point(300, 585)
        Me.txtSalt.Name = "txtSalt"
        Me.txtSalt.Size = New System.Drawing.Size(100, 20)
        Me.txtSalt.TabIndex = 17
        Me.txtSalt.Text = "0"
        '
        'btnGenerate
        '
        Me.btnGenerate.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.Location = New System.Drawing.Point(34, 635)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(419, 89)
        Me.btnGenerate.TabIndex = 18
        Me.btnGenerate.Text = "Find out what you can make!"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.Sawle_FinalProjectAssessment1.My.Resources.Resources.emptyKitchenText
        Me.PictureBox1.Location = New System.Drawing.Point(58, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(366, 93)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Kitchen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(484, 748)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.txtSalt)
        Me.Controls.Add(Me.txtPowder)
        Me.Controls.Add(Me.txtOil)
        Me.Controls.Add(Me.txtButter)
        Me.Controls.Add(Me.txtMilk)
        Me.Controls.Add(Me.txtSugar)
        Me.Controls.Add(Me.txtFlour)
        Me.Controls.Add(Me.txtEgg)
        Me.Controls.Add(Me.lblSalt)
        Me.Controls.Add(Me.lblPowder)
        Me.Controls.Add(Me.lblOil)
        Me.Controls.Add(Me.lblButter)
        Me.Controls.Add(Me.lblMilk)
        Me.Controls.Add(Me.lblSugar)
        Me.Controls.Add(Me.lblFlour)
        Me.Controls.Add(Me.lblEgg)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Kitchen"
        Me.Text = "Kitchen"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents lblEgg As System.Windows.Forms.Label
    Friend WithEvents lblFlour As System.Windows.Forms.Label
    Friend WithEvents lblSugar As System.Windows.Forms.Label
    Friend WithEvents lblMilk As System.Windows.Forms.Label
    Friend WithEvents lblButter As System.Windows.Forms.Label
    Friend WithEvents lblOil As System.Windows.Forms.Label
    Friend WithEvents lblPowder As System.Windows.Forms.Label
    Friend WithEvents lblSalt As System.Windows.Forms.Label
    Friend WithEvents txtEgg As System.Windows.Forms.TextBox
    Friend WithEvents txtFlour As System.Windows.Forms.TextBox
    Friend WithEvents txtSugar As System.Windows.Forms.TextBox
    Friend WithEvents txtMilk As System.Windows.Forms.TextBox
    Friend WithEvents txtButter As System.Windows.Forms.TextBox
    Friend WithEvents txtOil As System.Windows.Forms.TextBox
    Friend WithEvents txtPowder As System.Windows.Forms.TextBox
    Friend WithEvents txtSalt As System.Windows.Forms.TextBox
    Friend WithEvents btnGenerate As System.Windows.Forms.Button

End Class
