Option Explicit On
Option Strict On

'MainForm.vb
'Created By: Anmar Khazal 2013-12-04

Public Class MainForm
    Dim m_item As BakeryItem = New Cake("cake", 1)

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
    Private Function ReadInput(ByRef number As Double, ByRef cost As Double) As Boolean
       
        If GetPositiveDouble(txtNumberOfPieces.Text, number) And GetPositiveDouble(txtCostPerPiece.Text, cost) Then
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' GetPositiveDouble
    ''' Converts a string represented Double value to an Double type, and validates
    ''' the converted value to be >= 0
    ''' </summary>
    ''' <param name="stringToConvert">String representing the Double value.</param>
    ''' <param name="doubleOutValue">The converted Double value. If the conversion is successful
    ''' this variable will have a valid value, otherwise it is initiated to zero.</param>
    ''' <returns>True if the conversion is successful and the converted value >=0, False otherwise.</returns>
    ''' <remarks></remarks>
    Public Shared Function GetPositiveDouble(ByVal stringToConvert As String, ByRef doubleOutValue As Double) As Boolean
        Dim goodNumber As Boolean = Double.TryParse(stringToConvert, doubleOutValue)
        If (goodNumber) Then
            goodNumber = doubleOutValue >= 0
        End If
        Return goodNumber
    End Function

    Public Sub CreateItem(ByVal choice As Integer)
        Dim bakery_item As BakeryItem
        Select Case (choice)
            Case 1
                bakery_item = New Cake("cake", 1)
            Case 2
                bakery_item = New Cookies("cookie", 1)
        End Select
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim numberOfPieces As Double = 0.0
        Dim costPerPiece As Double = 0.0
        If ReadInput(numberOfPieces, costPerPiece) Then
            PrintReciept(costPerPiece, numberOfPieces)
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProduct.SelectedIndexChanged
        If cmbProduct.SelectedIndex >= 0 Then

        End If

    End Sub

    Private Sub PrintReciept(ByVal numberOfPieces As Double, ByVal costPerPiece As Double)
        Dim strOut As String = String.Format("The cake will cost your {0} kr", numberOfPieces * costPerPiece)
        lblReciept.Text = strOut
    End Sub


End Class
