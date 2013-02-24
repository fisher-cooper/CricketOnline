Imports CricketOnline.Membership

Public Class Login
    Inherits System.Web.UI.Page
    Dim mUser As New CricketOnline.Membership()

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RegisterHyperLink.NavigateUrl = "Register.aspx?ReturnUrl=" + HttpUtility.UrlEncode(Request.QueryString("ReturnUrl"))
        If Not IsPostBack Then
            Dim regCode As String
            regCode = Request.QueryString("UserID")
            If Not regCode = "" Then
                'If we have a code then it is a user confirmation, update the database accordingly
                mUser.ConfirmReg(regCode)
            End If
        End If
    End Sub

End Class