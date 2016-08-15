Public Class EmployeePD
    Private _name, _surname, _cell, _email, _question, _answer, _username, _password As String

    Public Sub New()
        _name = ""
        _surname = ""
        '_physical = ""
        '_postal = ""
        _cell = ""
        _email = ""
        _question = ""
        _answer = ""
        _username = ""
        _password = ""
    End Sub


    Public Sub New(ByVal theName As String, _
                   ByVal theSurname As String, _
                   ByVal theCell As String, _
                   ByVal theEmail As String, _
                   ByVal theQuestion As String, _
                   ByVal theAnswer As String, _
                   ByVal theUsername As String, _
                   ByVal thePassword As String)
        _name = theName
        _surname = theSurname
     
        _cell = theCell
        _email = theEmail
        _question = theQuestion
        _answer = theAnswer
        _username = theUsername
        _password = thePassword
    End Sub


    Property Username As String
        Get
            Return _username
        End Get
        Set(ByVal value As String)
            _username = Username
        End Set



    End Property



    Property Passsword As String
        Get
            Return _password
        End Get
        Set(ByVal value As String)
            _password = Passsword
        End Set


    End Property


    Property Answer As String
        Get
            Return _answer
        End Get
        Set(ByVal value As String)
            _answer = Answer
        End Set


    End Property

    Property Question As String
        Get
            Return _question
        End Get
        Set(ByVal value As String)
            _question = Question
        End Set

    End Property


    Property Email As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = Email
        End Set

    End Property

    Property Cell As String
        Get
            Return _cell
        End Get
        Set(ByVal value As String)
            _cell = Cell
        End Set

    End Property


    'Property Postal As String
    '    Get
    '        Return _postal
    '    End Get
    '    Set(ByVal value As String)
    '        _postal = Postal
    '    End Set

    'End Property




    'Property Physical As String
    '    Get
    '        Return _physical
    '    End Get
    '    Set(ByVal value As String)
    '        _physical = Physical
    '    End Set

    'End Property
    Property Surname As String
        Get
            Return _surname
        End Get
        Set(ByVal value As String)
            _surname = Surname
        End Set
    End Property

    Property Name As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = Name
        End Set
    End Property
End Class
