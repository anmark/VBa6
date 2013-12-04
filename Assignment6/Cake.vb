Public Class Cake
    Inherits BakeryItem
    Private m_numOfPieces As Double

    Public Sub New(name As String, price As Double)
        MyBase.New(name, price)
    End Sub

    Public Property Pieces() As Integer
        Get
            Return m_numOfPieces
        End Get
        Set(ByVal value As Integer)
            m_numOfPieces = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Dim strOut As String = String.Format("{0}   {1}", MyBase.ToString(), Pieces())
        Return strOut
    End Function


End Class

