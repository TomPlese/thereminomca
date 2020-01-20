Public Class Form_Tomy

    'Private Sub SemiAutoIdent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Private Sub Form_Tomy_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        GetToleranceTxtBox()
        IdentiFinder.ResetPOI()
        IdentiFinder.SAIonoff(True)
        InitSnap()
    End Sub
    Private Sub Form_Tomy_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'MsgBox("Form_Tomy " + e.CloseReason.ToString)
        If Not e.CloseReason = CloseReason.FormOwnerClosing Then
            Me.Hide()
        End If
        e.Cancel = True
        IdentiFinder.Disable()
    End Sub
    Private Sub Form_Tomy_ResizeEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ResizeEnd
        SetSnap()
    End Sub


    ' =======================================================================================
    '   SNAP WINDOW
    ' =======================================================================================
    Private SnapPosition As Int32 = 0
    ' --------------------------------------------------------------------- InitSmap must be calle from FormLoad
    Private Sub InitSnap()
        ' ---------------------------------- prepare snap params (timer will be disabled automatically)
        SnapMouseMoveTimer.Enabled = True
        TestSnap()
    End Sub
    ' --------------------------------------------------------------------- Start snap when clicking on TitleBar
    Protected Overrides Sub WndProc(ByRef m As Message)
        Const WM_NCLBUTTONDOWN As Integer = 161
        Const HTCAPTION As Integer = 2
        If m.Msg = WM_NCLBUTTONDOWN AndAlso m.WParam.ToInt32 = HTCAPTION Then
            Me.Select()
            Snap_MouseDown()
            Return
        End If
        MyBase.WndProc(m)
    End Sub
    ' --------------------------------------------------------------------- test snap positions
    Private Sub TestSnap()
        Dim newSnap As Int32 = 0
        If Math.Abs(Me.Left - Form_Main.Left) < 40 And Math.Abs(Me.Top - Form_Main.Bottom) < 40 Then newSnap = 1
        If Math.Abs(Me.Left - (Form_Main.Left + 400)) < 40 And Math.Abs(Me.Top - Form_Main.Bottom) < 40 Then newSnap = 2
        If Math.Abs(Me.Left - Form_Main.Right) < 40 And Math.Abs(Me.Top - Form_Main.Top) < 40 Then newSnap = 3
        If Math.Abs(Me.Left - Form_Main.Right) < 40 And Math.Abs(Me.Top - (Form_Main.Top + 320)) < 40 Then newSnap = 4
        If newSnap <> SnapPosition Then
            SnapPosition = newSnap
            If newSnap <> 0 Then
                SnapMouseMoveTimer.Enabled = False
                SetSnap()
            End If
        End If
    End Sub
    ' --------------------------------------------------------------------- set position to snap positions
    '    must be called from MainForm:DockAllWindows and from ResizeEnd
    ' -----------------------------------------------------------------------------------------------------
    Friend Sub SetSnap()
        If Form_Main.Left < -30000 Then Return
        Select Case SnapPosition
            Case 1 : Me.Left = Form_Main.Left : Me.Top = Form_Main.Bottom
            Case 2 : Me.Left = Form_Main.Left + 400 : Me.Top = Form_Main.Bottom
            Case 3 : Me.Left = Form_Main.Right : Me.Top = Form_Main.Top
            Case 4 : Me.Left = Form_Main.Right : Me.Top = Form_Main.Top + 320
        End Select
    End Sub
    ' --------------------------------------------------------------------- move the window with the mouse
    Private CursorStartPos As Point
    Private FormStartPos As Point
    Private WithEvents SnapMouseMoveTimer As Timer = New Timer
    Private Sub Snap_Form_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Move
        If Not SnapMouseMoveTimer.Enabled Then Return
        LimitFormPosition(Me)
        TestSnap()
    End Sub
    Private Sub Snap_MouseDown()
        CursorStartPos = Cursor.Position
        FormStartPos = Me.Location
        SnapMouseMoveTimer.Interval = 15
        SnapMouseMoveTimer.Enabled = True
    End Sub
    Private Sub SnapMouseMoveTimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles SnapMouseMoveTimer.Tick
        If MouseButtonLeftPressed() Then
            Me.Location = New Point(FormStartPos.X + Cursor.Position.X - CursorStartPos.X, _
                                    FormStartPos.Y + Cursor.Position.Y - CursorStartPos.Y)
        Else
            SnapMouseMoveTimer.Enabled = False
        End If
    End Sub




    ' =======================================================================================
    '   TOOLBAR
    ' =======================================================================================
    Private Sub ToolStripButton_ResetPOI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_ResetPOI.Click
        IdentiFinder.ResetPOI()
        ToolStripButton_SaveReport.Visible = False
        TextBox_TomyReport.Text = ""
    End Sub
    Private Sub ToolStripButton_ShowRes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_ShowRes.Click
        If CheckBox_XRF.Checked = True Then
            IdentiFinder.ShowAutoIdentResults("XRF")
        Else
            IdentiFinder.ShowAutoIdentResults("GS")
        End If
    End Sub
    Private Sub ToolStripButton_SaveReport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton_SaveReport.Click
        Dim TextToSendSave As String
        TextToSendSave = TextBox_TomyReport.Text
        IdentiFinder.SaveReport(TextToSendSave)
    End Sub


    ' =======================================================================================
    '   BUTTONS and TEXT BOX
    ' =======================================================================================
    Private Sub Button_AddPOI_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_AddPOI.Click
        IdentiFinder.AddPOI(Spectrometer.SelectedEnergy)
    End Sub

    Private Sub GetToleranceTxtBox()
        If CheckBox_XRF.Checked = True Then
            txt_EnergyTolerance.Text = IdentiFinder.GetSetTolerance("XRF", "Suit", "G").ToString
            MyTextBox_Suit.Text = IdentiFinder.GetSetTolerance("XRF", "Suit", "G").ToString
            MyTextBox_CloseTo.Text = IdentiFinder.GetSetTolerance("XRF", "CloseTo", "G").ToString
        Else
            txt_EnergyTolerance.Text = IdentiFinder.GetSetTolerance("GS", "Suit", "G").ToString
            MyTextBox_Suit.Text = IdentiFinder.GetSetTolerance("GS", "Suit", "G").ToString
            MyTextBox_CloseTo.Text = IdentiFinder.GetSetTolerance("GS", "CloseTo", "G").ToString
        End If
    End Sub

    Private Sub SetToleranceTxtBox()
        Dim SetResult As String
        If CheckBox_XRF.Checked = True Then
            SetResult = IdentiFinder.GetSetTolerance("XRF", "Suit", "S").ToString
            SetResult = IdentiFinder.GetSetTolerance("XRF", "CloseTo", "S").ToString
            txt_EnergyTolerance.Text = IdentiFinder.GetSetTolerance("XRF", "Suit", "G").ToString
        Else
            SetResult = IdentiFinder.GetSetTolerance("GS", "Suit", "S").ToString
            SetResult = IdentiFinder.GetSetTolerance("GS", "CloseTo", "S").ToString
            txt_EnergyTolerance.Text = IdentiFinder.GetSetTolerance("GS", "Suit", "G").ToString
        End If
    End Sub

    Private Sub CheckBox_XRF_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox_XRF.CheckedChanged
        IdentiFinder.ResetPOI()
        ToolStripButton_SaveReport.Visible = False
        TextBox_TomyReport.Text = ""

        If CheckBox_XRF.Checked = True Then
            Button_XRFshell.Visible = True
        Else
            Button_XRFshell.Visible = False
        End If
        GetToleranceTxtBox()
    End Sub

    Private Sub Button_SaveTol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_SaveTol.Click
        SetToleranceTxtBox()
        MessageBox.Show("New tolerances saved in IdentSettings file.", "Tolerance settings saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button_XRFshell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_XRFshell.Click
        Dim bolKalpha1 As Boolean = False
        Dim bolKalpha2 As Boolean = False
        Dim bolKbeta1 As Boolean = False
        Dim bolLalpha1 As Boolean = False
        Dim bolLalpha2 As Boolean = False
        Dim bolLbeta1 As Boolean = False
        Dim bolLbeta2 As Boolean = False
        Dim bolLgamma1 As Boolean = False
        Dim bolMalpha1 As Boolean = False
        Dim UserChange As Boolean = False
        Dim ListShells As String = ""

        ListShells = "Visibility of atomic shells in XRF process (True = visible, False = not visible):" & vbCrLf & _
                "Kalpha1 = " & IdentiFinder.GetSetShells("Kalpha1", "G", False).ToString & vbCrLf & _
                "Kalpha2 = " & IdentiFinder.GetSetShells("Kalpha2", "G", False).ToString & vbCrLf & _
                "Kbeta1 = " & IdentiFinder.GetSetShells("Kbeta1", "G", False).ToString & vbCrLf & _
                "Lalpha1 = " & IdentiFinder.GetSetShells("Lalpha1", "G", False).ToString & vbCrLf & _
                "Lalpha2 = " & IdentiFinder.GetSetShells("Lalpha2", "G", False).ToString & vbCrLf & _
                "Lbeta1 = " & IdentiFinder.GetSetShells("Lbeta1", "G", False).ToString & vbCrLf & _
                "Lbeta2 = " & IdentiFinder.GetSetShells("Lbeta2", "G", False).ToString & vbCrLf & _
                "Lgamma1 = " & IdentiFinder.GetSetShells("Lgamma1", "G", False).ToString & vbCrLf & _
                "Malpha1 = " & IdentiFinder.GetSetShells("Malpha1", "G", False).ToString & vbCrLf & vbCrLf & _
                "Do you want to change visibility of atomic shells in XRF?"

        If MessageBox.Show(ListShells, "XRF Atomic shells visibility", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            UserChange = True
            If MessageBox.Show("Kalpha1 to be visible?", "Atomic shell visibility", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then bolKalpha1 = True
            If MessageBox.Show("Kalpha2 to be visible?", "Atomic shell visibility", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then bolKalpha2 = True
            If MessageBox.Show("Kbeta1 to be visible?", "Atomic shell visibility", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then bolKbeta1 = True
            If MessageBox.Show("Lalpha1 to be visible?", "Atomic shell visibility", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then bolLalpha1 = True
            If MessageBox.Show("Lalpha2 to be visible?", "Atomic shell visibility", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then bolLalpha2 = True
            If MessageBox.Show("Lbeta1 to be visible?", "Atomic shell visibility", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then bolLbeta1 = True
            If MessageBox.Show("Lbeta2 to be visible?", "Atomic shell visibility", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then bolLbeta2 = True
            If MessageBox.Show("Lgamma1 to be visible?", "Atomic shell visibility", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then bolLgamma1 = True
            If MessageBox.Show("Malpha1 to be visible?", "Atomic shell visibility", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then bolMalpha1 = True
        End If
        If UserChange = True Then
            If bolKalpha1 = False And bolKalpha2 = False And bolKbeta1 = False And bolLalpha1 = False And bolLalpha2 = False And bolLbeta1 = False And bolLbeta2 = False And bolLgamma1 = False And bolMalpha1 = False Then
                MessageBox.Show("Changes wouldn't be saved because at least on shell must be set to be visible!" & vbCrLf & _
                                "Retry change process and select at least one shell to be visible.", "Changes are not saved", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                IdentiFinder.GetSetShells("Kalpha1", "S", bolKalpha1)
                IdentiFinder.GetSetShells("Kalpha2", "S", bolKalpha2)
                IdentiFinder.GetSetShells("Kbeta1", "S", bolKbeta1)
                IdentiFinder.GetSetShells("Lalpha1", "S", bolLalpha1)
                IdentiFinder.GetSetShells("Lalpha2", "S", bolLalpha2)
                IdentiFinder.GetSetShells("Lbeta1", "S", bolLbeta1)
                IdentiFinder.GetSetShells("Lbeta2", "S", bolLbeta2)
                IdentiFinder.GetSetShells("Lgamma1", "S", bolLgamma1)
                IdentiFinder.GetSetShells("Malpha1", "S", bolMalpha1)
                MessageBox.Show("New atomic shells visibility settings saved!", "Settings saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

End Class