Public Class cIsotopes

    Friend DefaultComparer As IComparer
    Friend EnergyComparer As IComparer

    Friend Sub ListIsotopes()
        With Form_Main.MyListView1
            .View = View.Details
            .Clear()
            ' ----------------------------------------------------------------- column headers
            .Columns.Add("Name", 76, HorizontalAlignment.Left)
            .Columns.Add("Energy", 54, HorizontalAlignment.Left)
            '.Columns.Add("", 1, HorizontalAlignment.Left)

            .Refresh()
            ' -----------------------------------------------------------------
            Dim clist As String = "Am241=59,Cs137=66,K40=1460"
            Dim item As ListViewItem
            Dim s As String = ""
            Dim ss As String = ""
            For i As Int32 = 0 To IdentiFinder.iIsotopeEnergy.Length - 1
                s = IdentiFinder.iIsotopeName(i)
                If s Is Nothing Then Continue For
                s = s.Replace("-", "").Trim
                item = .Items.Add(s)
                ss = IdentiFinder.iIsotopeEnergy(i).ToString("0.00")
                item.SubItems.Add(ss)
                item.SubItems.Add("")
                ss = Left(s & "=" & ss, 8)
                If clist.Contains(ss) Then item.Checked = True
            Next
            'item = .Items.Add("x32")
            'item.SubItems.Add("32")

            For i As Int32 = 1 To 100
                item = .Items.Add("")
                item.SubItems.Add("")
                item.SubItems.Add("")
            Next

            DefaultComparer = New MyListViewComparerName()
            .ListViewItemSorter = New MyListViewComparer()
            EnergyComparer = .ListViewItemSorter
            .Sort()
            .Enabled = True
        End With
    End Sub
End Class

Public Class MyListViewComparer
    Implements IComparer

    Public Function CompareItems(ByVal x As Object, ByVal y As Object) As Integer Implements IComparer.Compare
        'Debug.WriteLine(Item1.SubItems(1).Text & Item2.SubItems(1).Text)

        Dim i1 As String = CType(x, ListViewItem).SubItems(1).Text
        Dim i2 As String = CType(y, ListViewItem).SubItems(1).Text
        If i1 = "" And i2 <> "" Then Return 1
        If i1 <> "" And i2 = "" Then Return -1
        'Log(Item1.SubItems(1).Text & "<<<>>>" & Item2.SubItems(1).Text)
        i1 = i1.Replace(",", ".").Trim
        i2 = i2.Replace(",", ".").Trim
        If i1 = i2 Then Return 0
        If CSng(i1) > CSng(i2) Then
            Return 1
        Else
            Return -1
        End If
    End Function
End Class

Public Class MyListViewComparerName
    Implements IComparer

    Public Function CompareItems(ByVal x As Object, ByVal y As Object) As Integer Implements IComparer.Compare
        Dim Item1 As String = CType(x, ListViewItem).SubItems(0).Text
        Dim Item2 As String = CType(y, ListViewItem).SubItems(0).Text

        'Debug.WriteLine(Item1.SubItems(1).Text & Item2.SubItems(1).Text)

        If Item1 = "" And Item2 <> "" Then Return 1
        If Item1 <> "" And Item2 = "" Then Return -1
        'Log(Item1.SubItems(1).Text & "<<<>>>" & Item2.SubItems(1).Text)
        If Item1 = Item2 Then Return 0
        If Item1 > Item2 Then
            Return 1
        Else
            Return -1
        End If
    End Function
End Class
