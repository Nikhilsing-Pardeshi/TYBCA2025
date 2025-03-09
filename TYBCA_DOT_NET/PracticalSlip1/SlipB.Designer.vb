<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SlipB
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
        Me.txtENO = New System.Windows.Forms.TextBox()
        Me.txtEName = New System.Windows.Forms.TextBox()
        Me.txtSalaary = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.DgvEmploeeList = New System.Windows.Forms.DataGridView()
        CType(Me.DgvEmploeeList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtENO
        '
        Me.txtENO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtENO.Location = New System.Drawing.Point(218, 28)
        Me.txtENO.Name = "txtENO"
        Me.txtENO.Size = New System.Drawing.Size(145, 22)
        Me.txtENO.TabIndex = 0
        '
        'txtEName
        '
        Me.txtEName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEName.Location = New System.Drawing.Point(218, 67)
        Me.txtEName.Name = "txtEName"
        Me.txtEName.Size = New System.Drawing.Size(145, 22)
        Me.txtEName.TabIndex = 1
        '
        'txtSalaary
        '
        Me.txtSalaary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSalaary.Location = New System.Drawing.Point(218, 108)
        Me.txtSalaary.Name = "txtSalaary"
        Me.txtSalaary.Size = New System.Drawing.Size(145, 22)
        Me.txtSalaary.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(101, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter EmpId"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(101, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Enter Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(101, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Enter Salary"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(165, 148)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'DgvEmploeeList
        '
        Me.DgvEmploeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEmploeeList.Location = New System.Drawing.Point(36, 224)
        Me.DgvEmploeeList.Name = "DgvEmploeeList"
        Me.DgvEmploeeList.RowHeadersWidth = 51
        Me.DgvEmploeeList.RowTemplate.Height = 24
        Me.DgvEmploeeList.Size = New System.Drawing.Size(388, 150)
        Me.DgvEmploeeList.TabIndex = 7
        '
        'SlipB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 450)
        Me.Controls.Add(Me.DgvEmploeeList)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSalaary)
        Me.Controls.Add(Me.txtEName)
        Me.Controls.Add(Me.txtENO)
        Me.Name = "SlipB"
        Me.Text = "SlipB"
        CType(Me.DgvEmploeeList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtENO As TextBox
    Friend WithEvents txtEName As TextBox
    Friend WithEvents txtSalaary As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents DgvEmploeeList As DataGridView
End Class
