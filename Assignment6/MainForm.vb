Option Explicit On
Option Strict On

'MainForm.vb
'Created By: Anmar Khazal 2013-12-04

Public Class MainForm
    Dim m_item As BakeryItem = New BakeryItem("test", 1)

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
    End Sub

  
    Private Sub UpdateGUI()
        If DirectCast(cmbProduct.SelectedIndex, ProductType).Equals(ProductType.Cookies) Then
            lblNumberOrWeight.Text = "Weight of cookies (grams)"
        Else
            lblNumberOrWeight.Text = "Number of pieces"
        End If
    End Sub

    ''' <summary>
    ''' Validates input
    ''' </summary>
    ''' <returns>True if input is valid, False otherwise</returns>
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

    ''' <summary>
    ''' Dynamical binding. Creates new cake or cookie depending on user input
    ''' </summary>
    ''' <param name="choice"></param>
    ''' <param name="numberOfPieces"></param>
    ''' <param name="costPerPiece"></param>
    ''' <param name="name"></param>
    ''' <remarks></remarks>
    Public Sub CreateItem(ByVal choice As Integer, ByVal numberOfPieces As Double, ByVal costPerPiece As Double, ByVal name As String)
        Dim bakery_item As BakeryItem
        Select Case (choice)
            Case 1
                bakery_item = New Cake(name, numberOfPieces * costPerPiece, numberOfPieces)
                PrintReciept(bakery_item)
            Case 2
                bakery_item = New Cookies(name, numberOfPieces * costPerPiece, numberOfPieces)
                PrintReciept(bakery_item)
        End Select
    End Sub

    ''' <summary>
    ''' Determines product type and calls CreateItem accordingly
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub DetermineProductType()
        Dim numberOfPieces As Double
        Dim costPerPiece As Double

        If ReadInput(numberOfPieces, costPerPiece) And cmbProduct.SelectedIndex >= 0 Then
            Dim productType As ProductType = DirectCast(cmbProduct.SelectedIndex, ProductType)

            If (m_item.IsItemCake(productType)) Then
                CreateItem(1, numberOfPieces, costPerPiece, m_item.GetProductString(productType))
            Else
                CreateItem(2, numberOfPieces, costPerPiece, m_item.GetProductString(productType))
            End If
        End If

    End Sub

    ''' <summary>
    ''' Prints reciept
    ''' </summary>
    ''' <param name="item"></param>
    ''' <remarks></remarks>
    Private Sub PrintReciept(ByVal item As BakeryItem)
        ''   If (item.IsItemCake(
        lblReciept.Text = item.ToString()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        DetermineProductType()
    End Sub

    Private Sub cmbProduct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProduct.SelectedIndexChanged
        If cmbProduct.SelectedIndex >= 0 Then
            UpdateGUI()
        End If
    End Sub
End Class
