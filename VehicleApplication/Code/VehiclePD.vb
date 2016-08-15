Public Class VehiclePD
    Private _regNo, _Name, _Model, _Company, _Color, _CustomerNo As String
    '   Private  As Integer


    Public Sub New()
        _regNo = ""
        _Name = ""
        _Model = ""
        _Company = ""
        _Color = ""

        _CustomerNo = 0
    End Sub

    Public Sub New(ByVal theRegNo As String, ByVal theName As String, ByVal theModel As String, ByVal theCompany As String, ByVal theColor As String, ByVal theCustomerNo As String)
        _regNo = theRegNo
        _Name = theName
        _Model = theModel
        _Company = theCompany
        _Color = theColor

        _CustomerNo = theCustomerNo
    End Sub

    Property Company As String
        Get
            Return _Company
        End Get
        Set(ByVal value As String)
            _Company = Company
        End Set
    End Property

    Property CustomerNo As Integer
        Get
            Return _CustomerNo
        End Get
        Set(ByVal value As Integer)
            _CustomerNo = CustomerNo
        End Set
    End Property

    Property Color As String
        Get
            Return _Color
        End Get
        Set(ByVal value As String)
            _Color = Color
        End Set
    End Property



    Property Model As String
        Get
            Return _Model
        End Get
        Set(ByVal value As String)
            _Model = Model
        End Set
    End Property

    Property Name As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = Name
        End Set
    End Property


    Property RegNo As String
        Get
            Return _regNo
        End Get
        Set(ByVal value As String)
            _regNo = RegNo
        End Set
    End Property
End Class
