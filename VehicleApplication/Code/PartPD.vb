Public Class PartPD
    Private _code, _desc, _supplierID, _vehicle, _model, _engineNo, _shelf As String
    Private _qty, _year As Integer
    ' As Integer
    Private _costPrice, _sellPrice As Decimal


    Sub New()
        _shelf = Nothing
        _engineNo = Nothing
        _sellPrice = Nothing
        _code = Nothing
        _vehicle = Nothing
        _model = Nothing
        _year = Nothing
        _desc = Nothing
        _costPrice = Nothing
        _qty = Nothing
        _supplierID = Nothing
    End Sub


    Sub New(ByVal theCode As String, _
            ByVal theDesc As String, _
            ByVal theCostPrice As Decimal, _
            ByVal theQty As Integer, _
            ByVal theSupplier As String, _
            ByVal theVehicle As String, _
            ByVal theModel As String, _
            ByVal theYear As Integer, _
            ByVal theSellPrice As Decimal, _
            ByVal theEngineNo As String, _
            theSelf As String)
        _shelf = theSelf
        _sellPrice = theSellPrice
        _engineNo = theEngineNo
        _year = theYear
        _model = theModel
        _vehicle = theVehicle
        _code = theCode
        _desc = theDesc
        _costPrice = theCostPrice
        _qty = theQty
        _supplierID = theSupplier
    End Sub

    Property Shelf As String
        Get
            Return _shelf
        End Get
        Set(value As String)
            _shelf = Shelf
        End Set
    End Property

    Property SellingPrice As Decimal
        Get
            Return _sellPrice
        End Get
        Set(value As Decimal)
            _sellPrice = SellingPrice
        End Set
    End Property

    Property EngineNo As String
        Get
            Return _engineNo
        End Get
        Set(value As String)
            _engineNo = EngineNo
        End Set
    End Property

    Property Vehicle As String
        Get
            Return _vehicle
        End Get
        Set(value As String)
            _vehicle = Vehicle
        End Set
    End Property

    Property Model As String
        Get
            Return _model
        End Get
        Set(value As String)
            _model = Model
        End Set
    End Property

    Property Year As Integer
        Get
            Return _year
        End Get
        Set(value As Integer)
            _year = Year
        End Set
    End Property
    Property Code As String
        Get
            Return _code
        End Get
        Set(ByVal value As String)
            _code = Code
        End Set
    End Property

    Property Description As String
        Get
            Return _desc
        End Get
        Set(ByVal value As String)
            _desc = Description
        End Set
    End Property

    Property Qty As Integer
        Get
            Return _qty
        End Get
        Set(ByVal value As Integer)
            _qty = Qty
        End Set
    End Property


    Property CostPrice As Decimal
        Get
            Return _costPrice
        End Get
        Set(ByVal value As Decimal)
            _costPrice = CostPrice
        End Set
    End Property

    Property SupplierID As String
        Get
            Return _supplierID
        End Get
        Set(ByVal value As String)
            _supplierID = SupplierID
        End Set
    End Property
End Class
