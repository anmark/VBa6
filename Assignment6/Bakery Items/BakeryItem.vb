Option Explicit On
Option Strict On

'BakeryItem.vb
'Created By: Anmar Khazal 2013-12-04

Public Class BakeryItem
    Private m_name As String
    Private m_price As Double

    Public Sub New(name As String, price As Double)
        m_name = name
        m_price = price
    End Sub

    Public Property Name() As String
        Get
            Return m_name
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                m_name = value
            End If
        End Set
    End Property

    Public Property Price() As Double
        Get
            Return m_price
        End Get
        Set(ByVal value As Double)
            m_price = value
        End Set
    End Property

    ''' <summary>
    ''' Checks if item of producttype is a cake or cookie
    ''' </summary>
    ''' <param name="item"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function IsItemCake(item As ProductType) As Boolean
        If item.Equals(ProductType.Cookies) Then
            Return False
        Else
            Return True
        End If
    End Function

    ''' <summary>
    ''' This function deletes the "_"s from products names
    ''' </summary>
    ''' <returns>The product string without "_" char</returns>
    ''' <remarks></remarks>
    Public Function GetProductString(item As ProductType) As String
        Dim strOut As String = item.ToString().Replace("_", " ").Trim()
        Return strOut
    End Function

    ''' <summary>
    ''' This function deletes the "_"s from all products names
    ''' </summary>
    ''' <returns>The products strings without "_" chars</returns>
    ''' <remarks></remarks>
    Public Function GetProductStrings() As String()
        Dim strOut As New List(Of String)

        Dim items As Array
        items = System.Enum.GetValues(GetType(ProductType))

        For Each item As ProductType In items
            strOut.Add(GetProductString(item))
        Next

        Dim productStrings As String() = strOut.ToArray()

        Return productStrings
    End Function


    Public Overrides Function ToString() As String
        Dim strOut As String = String.Format("Name: {0} {2}Price: {1} kr", Name, Price, Environment.NewLine)
        Return strOut
    End Function



End Class
