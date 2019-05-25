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
        Me.lyricTextBox = New System.Windows.Forms.TextBox()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.uniqueWordsListBox = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.showWordsButton = New System.Windows.Forms.Button()
        Me.uniqueWordsLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.totalWordsLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.percentUniqueLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.averageUniqueLengthLabel = New System.Windows.Forms.Label()
        Me.totalLettersLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.averageLengthLabel = New System.Windows.Forms.Label()
        Me.exportButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lyricTextBox
        '
        Me.lyricTextBox.Location = New System.Drawing.Point(12, 12)
        Me.lyricTextBox.Multiline = True
        Me.lyricTextBox.Name = "lyricTextBox"
        Me.lyricTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.lyricTextBox.Size = New System.Drawing.Size(432, 499)
        Me.lyricTextBox.TabIndex = 0
        Me.lyricTextBox.Text = "Enter text here"
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(451, 404)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(93, 31)
        Me.calcButton.TabIndex = 1
        Me.calcButton.Text = "Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'uniqueWordsListBox
        '
        Me.uniqueWordsListBox.FormattingEnabled = True
        Me.uniqueWordsListBox.Location = New System.Drawing.Point(559, 12)
        Me.uniqueWordsListBox.Name = "uniqueWordsListBox"
        Me.uniqueWordsListBox.Size = New System.Drawing.Size(123, 498)
        Me.uniqueWordsListBox.TabIndex = 0
        Me.uniqueWordsListBox.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(463, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Unique Words"
        '
        'showWordsButton
        '
        Me.showWordsButton.Enabled = False
        Me.showWordsButton.Location = New System.Drawing.Point(451, 441)
        Me.showWordsButton.Name = "showWordsButton"
        Me.showWordsButton.Size = New System.Drawing.Size(93, 32)
        Me.showWordsButton.TabIndex = 2
        Me.showWordsButton.Text = "Show Words"
        Me.showWordsButton.UseVisualStyleBackColor = True
        '
        'uniqueWordsLabel
        '
        Me.uniqueWordsLabel.BackColor = System.Drawing.Color.White
        Me.uniqueWordsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.uniqueWordsLabel.Location = New System.Drawing.Point(464, 76)
        Me.uniqueWordsLabel.Name = "uniqueWordsLabel"
        Me.uniqueWordsLabel.Size = New System.Drawing.Size(75, 22)
        Me.uniqueWordsLabel.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(463, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Total Words"
        '
        'totalWordsLabel
        '
        Me.totalWordsLabel.BackColor = System.Drawing.Color.White
        Me.totalWordsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.totalWordsLabel.Location = New System.Drawing.Point(464, 28)
        Me.totalWordsLabel.Name = "totalWordsLabel"
        Me.totalWordsLabel.Size = New System.Drawing.Size(75, 22)
        Me.totalWordsLabel.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(463, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Percent Unique"
        '
        'percentUniqueLabel
        '
        Me.percentUniqueLabel.BackColor = System.Drawing.Color.White
        Me.percentUniqueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.percentUniqueLabel.Location = New System.Drawing.Point(464, 127)
        Me.percentUniqueLabel.Name = "percentUniqueLabel"
        Me.percentUniqueLabel.Size = New System.Drawing.Size(75, 22)
        Me.percentUniqueLabel.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(463, 245)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 28)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Average unique word length"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(463, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Total letters"
        '
        'averageUniqueLengthLabel
        '
        Me.averageUniqueLengthLabel.BackColor = System.Drawing.Color.White
        Me.averageUniqueLengthLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.averageUniqueLengthLabel.Location = New System.Drawing.Point(464, 273)
        Me.averageUniqueLengthLabel.Name = "averageUniqueLengthLabel"
        Me.averageUniqueLengthLabel.Size = New System.Drawing.Size(75, 22)
        Me.averageUniqueLengthLabel.TabIndex = 0
        '
        'totalLettersLabel
        '
        Me.totalLettersLabel.BackColor = System.Drawing.Color.White
        Me.totalLettersLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.totalLettersLabel.Location = New System.Drawing.Point(464, 207)
        Me.totalLettersLabel.Name = "totalLettersLabel"
        Me.totalLettersLabel.Size = New System.Drawing.Size(75, 22)
        Me.totalLettersLabel.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(463, 313)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 27)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Average word length"
        '
        'averageLengthLabel
        '
        Me.averageLengthLabel.BackColor = System.Drawing.Color.White
        Me.averageLengthLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.averageLengthLabel.Location = New System.Drawing.Point(464, 340)
        Me.averageLengthLabel.Name = "averageLengthLabel"
        Me.averageLengthLabel.Size = New System.Drawing.Size(75, 22)
        Me.averageLengthLabel.TabIndex = 0
        '
        'exportButton
        '
        Me.exportButton.Enabled = False
        Me.exportButton.Location = New System.Drawing.Point(451, 479)
        Me.exportButton.Name = "exportButton"
        Me.exportButton.Size = New System.Drawing.Size(93, 31)
        Me.exportButton.TabIndex = 3
        Me.exportButton.Text = "Export"
        Me.exportButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 523)
        Me.Controls.Add(Me.exportButton)
        Me.Controls.Add(Me.averageLengthLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.totalLettersLabel)
        Me.Controls.Add(Me.averageUniqueLengthLabel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.percentUniqueLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.totalWordsLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.uniqueWordsLabel)
        Me.Controls.Add(Me.showWordsButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.uniqueWordsListBox)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.lyricTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(575, 561)
        Me.MinimumSize = New System.Drawing.Size(575, 561)
        Me.Name = "Form1"
        Me.Text = "Word Analyzer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lyricTextBox As System.Windows.Forms.TextBox
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents uniqueWordsListBox As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents showWordsButton As System.Windows.Forms.Button
    Friend WithEvents uniqueWordsLabel As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents totalWordsLabel As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents percentUniqueLabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents averageUniqueLengthLabel As System.Windows.Forms.Label
    Friend WithEvents totalLettersLabel As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents averageLengthLabel As System.Windows.Forms.Label
    Friend WithEvents exportButton As System.Windows.Forms.Button

End Class
