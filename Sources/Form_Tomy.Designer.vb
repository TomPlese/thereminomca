<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Tomy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Tomy))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label_Tolerance = New System.Windows.Forms.Label
        Me.txt_EnergyTolerance = New MyTextBox
        Me.Button_AddPOI = New System.Windows.Forms.Button
        Me.GroupBox_Report = New System.Windows.Forms.GroupBox
        Me.TextBox_TomyReport = New System.Windows.Forms.TextBox
        Me.ComboBox_IsotopeList = New System.Windows.Forms.ComboBox
        Me.CheckBox_XRF = New System.Windows.Forms.CheckBox
        Me.TextBox_TomyIsotopeIdentifier = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button_SaveTol = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label_Suit = New System.Windows.Forms.Label
        Me.MyTextBox_CloseTo = New MyTextBox
        Me.MyTextBox_Suit = New MyTextBox
        Me.Button_XRFshell = New System.Windows.Forms.Button
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton_ShowRes = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton_ResetPOI = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton_SaveReport = New System.Windows.Forms.ToolStripButton
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox_Report.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label_Tolerance)
        Me.GroupBox1.Controls.Add(Me.txt_EnergyTolerance)
        Me.GroupBox1.Controls.Add(Me.Button_AddPOI)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(6, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(298, 45)
        Me.GroupBox1.TabIndex = 175
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Energy Tolerance "
        '
        'Label_Tolerance
        '
        Me.Label_Tolerance.AutoSize = True
        Me.Label_Tolerance.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label_Tolerance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label_Tolerance.Location = New System.Drawing.Point(61, 21)
        Me.Label_Tolerance.Name = "Label_Tolerance"
        Me.Label_Tolerance.Size = New System.Drawing.Size(99, 13)
        Me.Label_Tolerance.TabIndex = 175
        Me.Label_Tolerance.Text = "eV +/- 10 to 20000"
        '
        'txt_EnergyTolerance
        '
        Me.txt_EnergyTolerance.ArrowsIncrement = 10
        Me.txt_EnergyTolerance.BackColor = System.Drawing.Color.MintCream
        Me.txt_EnergyTolerance.BackColor_Over = System.Drawing.Color.Moccasin
        Me.txt_EnergyTolerance.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_EnergyTolerance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_EnergyTolerance.ForeColor = System.Drawing.Color.Black
        Me.txt_EnergyTolerance.Increment = 0.02
        Me.txt_EnergyTolerance.Location = New System.Drawing.Point(6, 20)
        Me.txt_EnergyTolerance.MaxValue = 20000
        Me.txt_EnergyTolerance.MinValue = 10
        Me.txt_EnergyTolerance.Name = "txt_EnergyTolerance"
        Me.txt_EnergyTolerance.NumericValue = 10
        Me.txt_EnergyTolerance.NumericValueInteger = 10
        Me.txt_EnergyTolerance.RectangleColor = System.Drawing.Color.PowderBlue
        Me.txt_EnergyTolerance.RectangleStyle = System.Windows.Forms.ButtonBorderStyle.Dashed
        Me.txt_EnergyTolerance.RoundingStep = 0
        Me.txt_EnergyTolerance.ShadowColor = System.Drawing.Color.LightGray
        Me.txt_EnergyTolerance.Size = New System.Drawing.Size(47, 16)
        Me.txt_EnergyTolerance.TabIndex = 174
        Me.txt_EnergyTolerance.Text = "10"
        Me.txt_EnergyTolerance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button_AddPOI
        '
        Me.Button_AddPOI.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_AddPOI.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button_AddPOI.Location = New System.Drawing.Point(191, 15)
        Me.Button_AddPOI.Name = "Button_AddPOI"
        Me.Button_AddPOI.Size = New System.Drawing.Size(100, 23)
        Me.Button_AddPOI.TabIndex = 177
        Me.Button_AddPOI.Text = "Add Energy POI"
        Me.Button_AddPOI.UseVisualStyleBackColor = True
        '
        'GroupBox_Report
        '
        Me.GroupBox_Report.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_Report.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.GroupBox_Report.Controls.Add(Me.TextBox_TomyReport)
        Me.GroupBox_Report.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox_Report.Location = New System.Drawing.Point(6, 78)
        Me.GroupBox_Report.Name = "GroupBox_Report"
        Me.GroupBox_Report.Size = New System.Drawing.Size(298, 162)
        Me.GroupBox_Report.TabIndex = 176
        Me.GroupBox_Report.TabStop = False
        Me.GroupBox_Report.Text = " Identification Report "
        '
        'TextBox_TomyReport
        '
        Me.TextBox_TomyReport.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox_TomyReport.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TextBox_TomyReport.Location = New System.Drawing.Point(7, 19)
        Me.TextBox_TomyReport.Multiline = True
        Me.TextBox_TomyReport.Name = "TextBox_TomyReport"
        Me.TextBox_TomyReport.ReadOnly = True
        Me.TextBox_TomyReport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox_TomyReport.Size = New System.Drawing.Size(284, 137)
        Me.TextBox_TomyReport.TabIndex = 0
        '
        'ComboBox_IsotopeList
        '
        Me.ComboBox_IsotopeList.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_IsotopeList.DropDownHeight = 999
        Me.ComboBox_IsotopeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_IsotopeList.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ComboBox_IsotopeList.FormattingEnabled = True
        Me.ComboBox_IsotopeList.IntegralHeight = False
        Me.ComboBox_IsotopeList.Location = New System.Drawing.Point(501, 2)
        Me.ComboBox_IsotopeList.Name = "ComboBox_IsotopeList"
        Me.ComboBox_IsotopeList.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_IsotopeList.TabIndex = 178
        '
        'CheckBox_XRF
        '
        Me.CheckBox_XRF.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox_XRF.AutoSize = True
        Me.CheckBox_XRF.BackColor = System.Drawing.Color.Lavender
        Me.CheckBox_XRF.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox_XRF.Location = New System.Drawing.Point(444, 5)
        Me.CheckBox_XRF.Name = "CheckBox_XRF"
        Me.CheckBox_XRF.Size = New System.Drawing.Size(47, 17)
        Me.CheckBox_XRF.TabIndex = 179
        Me.CheckBox_XRF.Text = "XRF"
        Me.CheckBox_XRF.UseVisualStyleBackColor = False
        '
        'TextBox_TomyIsotopeIdentifier
        '
        Me.TextBox_TomyIsotopeIdentifier.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_TomyIsotopeIdentifier.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TextBox_TomyIsotopeIdentifier.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox_TomyIsotopeIdentifier.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TextBox_TomyIsotopeIdentifier.Location = New System.Drawing.Point(10, 64)
        Me.TextBox_TomyIsotopeIdentifier.Multiline = True
        Me.TextBox_TomyIsotopeIdentifier.Name = "TextBox_TomyIsotopeIdentifier"
        Me.TextBox_TomyIsotopeIdentifier.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox_TomyIsotopeIdentifier.Size = New System.Drawing.Size(303, 141)
        Me.TextBox_TomyIsotopeIdentifier.TabIndex = 180
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Button_SaveTol)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label_Suit)
        Me.GroupBox2.Controls.Add(Me.MyTextBox_CloseTo)
        Me.GroupBox2.Controls.Add(Me.MyTextBox_Suit)
        Me.GroupBox2.Controls.Add(Me.TextBox_TomyIsotopeIdentifier)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(310, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(320, 212)
        Me.GroupBox2.TabIndex = 181
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Isotope identifier"
        '
        'Button_SaveTol
        '
        Me.Button_SaveTol.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_SaveTol.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_SaveTol.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button_SaveTol.Location = New System.Drawing.Point(214, 25)
        Me.Button_SaveTol.Name = "Button_SaveTol"
        Me.Button_SaveTol.Size = New System.Drawing.Size(100, 23)
        Me.Button_SaveTol.TabIndex = 184
        Me.Button_SaveTol.Text = "Save tolerances"
        Me.Button_SaveTol.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(66, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 13)
        Me.Label1.TabIndex = 183
        Me.Label1.Text = "eV +/- ""close to"" tolerance"
        '
        'Label_Suit
        '
        Me.Label_Suit.AutoSize = True
        Me.Label_Suit.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label_Suit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label_Suit.Location = New System.Drawing.Point(66, 23)
        Me.Label_Suit.Name = "Label_Suit"
        Me.Label_Suit.Size = New System.Drawing.Size(114, 13)
        Me.Label_Suit.TabIndex = 182
        Me.Label_Suit.Text = "eV +/- ""suit"" tolerance"
        '
        'MyTextBox_CloseTo
        '
        Me.MyTextBox_CloseTo.ArrowsIncrement = 10
        Me.MyTextBox_CloseTo.BackColor = System.Drawing.Color.MintCream
        Me.MyTextBox_CloseTo.BackColor_Over = System.Drawing.Color.Moccasin
        Me.MyTextBox_CloseTo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MyTextBox_CloseTo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyTextBox_CloseTo.ForeColor = System.Drawing.Color.Black
        Me.MyTextBox_CloseTo.Increment = 0.02
        Me.MyTextBox_CloseTo.Location = New System.Drawing.Point(13, 41)
        Me.MyTextBox_CloseTo.MaxValue = 20000
        Me.MyTextBox_CloseTo.MinValue = 10
        Me.MyTextBox_CloseTo.Name = "MyTextBox_CloseTo"
        Me.MyTextBox_CloseTo.NumericValue = 10
        Me.MyTextBox_CloseTo.NumericValueInteger = 10
        Me.MyTextBox_CloseTo.RectangleColor = System.Drawing.Color.PowderBlue
        Me.MyTextBox_CloseTo.RectangleStyle = System.Windows.Forms.ButtonBorderStyle.Dashed
        Me.MyTextBox_CloseTo.RoundingStep = 0
        Me.MyTextBox_CloseTo.ShadowColor = System.Drawing.Color.LightGray
        Me.MyTextBox_CloseTo.Size = New System.Drawing.Size(47, 16)
        Me.MyTextBox_CloseTo.TabIndex = 181
        Me.MyTextBox_CloseTo.Text = "10"
        Me.MyTextBox_CloseTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MyTextBox_Suit
        '
        Me.MyTextBox_Suit.ArrowsIncrement = 10
        Me.MyTextBox_Suit.BackColor = System.Drawing.Color.MintCream
        Me.MyTextBox_Suit.BackColor_Over = System.Drawing.Color.Moccasin
        Me.MyTextBox_Suit.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MyTextBox_Suit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyTextBox_Suit.ForeColor = System.Drawing.Color.Black
        Me.MyTextBox_Suit.Increment = 0.02
        Me.MyTextBox_Suit.Location = New System.Drawing.Point(13, 21)
        Me.MyTextBox_Suit.MaxValue = 20000
        Me.MyTextBox_Suit.MinValue = 10
        Me.MyTextBox_Suit.Name = "MyTextBox_Suit"
        Me.MyTextBox_Suit.NumericValue = 10
        Me.MyTextBox_Suit.NumericValueInteger = 10
        Me.MyTextBox_Suit.RectangleColor = System.Drawing.Color.PowderBlue
        Me.MyTextBox_Suit.RectangleStyle = System.Windows.Forms.ButtonBorderStyle.Dashed
        Me.MyTextBox_Suit.RoundingStep = 0
        Me.MyTextBox_Suit.ShadowColor = System.Drawing.Color.LightGray
        Me.MyTextBox_Suit.Size = New System.Drawing.Size(47, 16)
        Me.MyTextBox_Suit.TabIndex = 176
        Me.MyTextBox_Suit.Text = "10"
        Me.MyTextBox_Suit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button_XRFshell
        '
        Me.Button_XRFshell.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_XRFshell.BackColor = System.Drawing.Color.Lavender
        Me.Button_XRFshell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_XRFshell.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button_XRFshell.Location = New System.Drawing.Point(378, 2)
        Me.Button_XRFshell.Name = "Button_XRFshell"
        Me.Button_XRFshell.Size = New System.Drawing.Size(58, 21)
        Me.Button_XRFshell.TabIndex = 185
        Me.Button_XRFshell.Text = "Shells"
        Me.Button_XRFshell.UseVisualStyleBackColor = False
        Me.Button_XRFshell.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_ShowRes, Me.ToolStripSeparator2, Me.ToolStripButton_ResetPOI, Me.ToolStripSeparator3, Me.ToolStripButton_SaveReport})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(636, 25)
        Me.ToolStrip1.TabIndex = 182
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton_ShowRes
        '
        Me.ToolStripButton_ShowRes.Image = CType(resources.GetObject("ToolStripButton_ShowRes.Image"), System.Drawing.Image)
        Me.ToolStripButton_ShowRes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_ShowRes.Name = "ToolStripButton_ShowRes"
        Me.ToolStripButton_ShowRes.Size = New System.Drawing.Size(94, 22)
        Me.ToolStripButton_ShowRes.Text = "Show Report"
        Me.ToolStripButton_ShowRes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton_ResetPOI
        '
        Me.ToolStripButton_ResetPOI.Image = CType(resources.GetObject("ToolStripButton_ResetPOI.Image"), System.Drawing.Image)
        Me.ToolStripButton_ResetPOI.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_ResetPOI.Name = "ToolStripButton_ResetPOI"
        Me.ToolStripButton_ResetPOI.Size = New System.Drawing.Size(77, 22)
        Me.ToolStripButton_ResetPOI.Text = "Reset POI"
        Me.ToolStripButton_ResetPOI.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton_SaveReport
        '
        Me.ToolStripButton_SaveReport.Image = CType(resources.GetObject("ToolStripButton_SaveReport.Image"), System.Drawing.Image)
        Me.ToolStripButton_SaveReport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_SaveReport.Name = "ToolStripButton_SaveReport"
        Me.ToolStripButton_SaveReport.Size = New System.Drawing.Size(89, 22)
        Me.ToolStripButton_SaveReport.Text = "Save Report"
        Me.ToolStripButton_SaveReport.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ToolStripButton_SaveReport.Visible = False
        '
        'Form_Tomy
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(636, 246)
        Me.Controls.Add(Me.Button_XRFshell)
        Me.Controls.Add(Me.ComboBox_IsotopeList)
        Me.Controls.Add(Me.CheckBox_XRF)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox_Report)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(644, 280)
        Me.Name = "Form_Tomy"
        Me.Opacity = 0
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "GS Isotope identifier and XRF element identifier by Tom 9A5TOM"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox_Report.ResumeLayout(False)
        Me.GroupBox_Report.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_EnergyTolerance As MyTextBox
    Friend WithEvents Label_Tolerance As System.Windows.Forms.Label
    Friend WithEvents GroupBox_Report As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox_TomyReport As System.Windows.Forms.TextBox
    Friend WithEvents Button_AddPOI As System.Windows.Forms.Button
    Friend WithEvents ComboBox_IsotopeList As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox_XRF As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox_TomyIsotopeIdentifier As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label_Suit As System.Windows.Forms.Label
    Friend WithEvents MyTextBox_CloseTo As MyTextBox
    Friend WithEvents MyTextBox_Suit As MyTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button_SaveTol As System.Windows.Forms.Button
    Friend WithEvents Button_XRFshell As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_ShowRes As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton_ResetPOI As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton_SaveReport As System.Windows.Forms.ToolStripButton
End Class
