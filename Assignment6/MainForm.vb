Public Class MainForm
    Dim m_item As Cake = New Cake("cake", 1)

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ' m_contacts = New ContactManager()
        InitializeGUI()
    End Sub

    'Add countries to the combo box and do other initilizations. 
    Private Sub InitializeGUI()
        cmbProduct.DataSource = m_item.GetProductStrings()
        UpdateGUI()
    End Sub

    'Clear the ListBox, call the method GetContactsInfo of the m_contacts objects
    'and using the ListBox's AddRange method, add the array to the ListBox
    Private Sub UpdateGUI()
        'Dim strContacts() As String = m_contacts.GetContactsInfo()
        'lblcount.text = lstresults.items.count.tostring()
        'lstresults.items.clear()
        'If (strContacts IsNot Nothing) Then
        '    lstresults.items.clear()
        '    lstresults.items.addrange(strContacts)
        '    lblcount.text = lstresults.items.count.tostring()
        'End If
    End Sub

    ''' <summary>
    ''' Validates name and address inputs
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function ReadInput() As Boolean
        If True Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProduct.SelectedIndexChanged
        If cmbProduct.SelectedIndex >= 0 Then

        End If

    End Sub
End Class
