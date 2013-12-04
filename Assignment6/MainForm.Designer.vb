<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.Item = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbProduct = New System.Windows.Forms.ComboBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.txtNumberOfPieces = New System.Windows.Forms.TextBox()
        Me.txtCostPerPiece = New System.Windows.Forms.TextBox()
        Me.lblReciept = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Item
        '
        Me.Item.AutoSize = True
        Me.Item.Location = New System.Drawing.Point(12, 27)
        Me.Item.Name = "Item"
        Me.Item.Size = New System.Drawing.Size(27, 13)
        Me.Item.TabIndex = 0
        Me.Item.Text = "Item"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Number of pieces"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cost per piece "
        '
        'cmbProduct
        '
        Me.cmbProduct.FormattingEnabled = True
        Me.cmbProduct.Location = New System.Drawing.Point(157, 24)
        Me.cmbProduct.Name = "cmbProduct"
        Me.cmbProduct.Size = New System.Drawing.Size(121, 21)
        Me.cmbProduct.TabIndex = 3
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(49, 116)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(191, 23)
        Me.btnOK.TabIndex = 6
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'txtNumberOfPieces
        '
        Me.txtNumberOfPieces.Location = New System.Drawing.Point(204, 52)
        Me.txtNumberOfPieces.Name = "txtNumberOfPieces"
        Me.txtNumberOfPieces.Size = New System.Drawing.Size(74, 20)
        Me.txtNumberOfPieces.TabIndex = 9
        '
        'txtCostPerPiece
        '
        Me.txtCostPerPiece.Location = New System.Drawing.Point(204, 83)
        Me.txtCostPerPiece.Name = "txtCostPerPiece"
        Me.txtCostPerPiece.Size = New System.Drawing.Size(74, 20)
        Me.txtCostPerPiece.TabIndex = 10
        '
        'lblReciept
        '
        Me.lblReciept.AutoSize = True
        Me.lblReciept.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblReciept.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReciept.Location = New System.Drawing.Point(13, 148)
        Me.lblReciept.MinimumSize = New System.Drawing.Size(260, 180)
        Me.lblReciept.Name = "lblReciept"
        Me.lblReciept.Size = New System.Drawing.Size(260, 180)
        Me.lblReciept.TabIndex = 11
        Me.lblReciept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(285, 337)
        Me.Controls.Add(Me.lblReciept)
        Me.Controls.Add(Me.txtCostPerPiece)
        Me.Controls.Add(Me.txtNumberOfPieces)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.cmbProduct)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Item)
        Me.Name = "MainForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Item As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbProduct As System.Windows.Forms.ComboBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents txtNumberOfPieces As System.Windows.Forms.TextBox
    Friend WithEvents txtCostPerPiece As System.Windows.Forms.TextBox
    Friend WithEvents lblReciept As System.Windows.Forms.Label

End Class
