﻿Public Class SupplierPD
    Private _name, _email, _tel, _fax As String

    Public Sub New()
        _name = ""
        _email = ""
        _tel = ""
        _fax = ""
    End Sub

    Public Sub New(ByVal theName As String, _
                   ByVal theemail As String, _
                   ByVal thetel As String, _
                   ByVal thefax As String)
        _name = theName
        '_physical = thephysical
        '_postal = thepostal
        _email = theemail
        _tel = thetel
        _fax = thefax
    End Sub


    Property Name As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = Name
        End Set
    End Property

    'Property Physical As String
    '    Get
    '        Return _physical
    '    End Get
    '    Set(ByVal value As String)
    '        _physical = Physical
    '    End Set
    'End Property

    'Property Postal As String
    '    Get
    '        Return _postal
    '    End Get
    '    Set(ByVal value As String)
    '        _postal = Postal
    '    End Set
    'End Property

    Property Email As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = Email
        End Set
    End Property

    Property Tel As String
        Get
            Return _tel
        End Get
        Set(ByVal value As String)
            _tel = Tel
        End Set
    End Property

    Property Fax As String
        Get
            Return _fax
        End Get
        Set(ByVal value As String)
            _fax = Fax
        End Set
    End Property
End Class
