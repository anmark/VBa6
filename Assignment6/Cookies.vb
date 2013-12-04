Public Class Cookies
    Inherits BakeryItem
    Private m_weight As Double

    Public Sub New(name As String, price As Double)
        MyBase.New(name, price)
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
        Dim strOut As String = String.Format("{0}   {1}", MyBase.ToString(), Weight())
        Return strOut
    End Function

End Class