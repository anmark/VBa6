Option Explicit On
Option Strict On

'Cookies.vb
'Created By: Anmar Khazal 2013-12-04

Public Class Cookies
    Inherits BakeryItem
    Private m_weight As Double

    Public Sub New(name As String, price As Double, weight As Double)
        MyBase.New(name, price)
        m_weight = weight
    End Sub

    Public Property Weight() As Double
        Get
            Return m_weight
        End Get
        Set(ByVal value As Double)
            m_weight = value
        End Set

    End Property

    Public Overrides Function ToString() As String
        Dim strOut As String = String.Format("{0}{2}Weight: {1} grams", MyBase.ToString(), Weight(), Environment.NewLine)
        Return strOut
    End Function

End Class