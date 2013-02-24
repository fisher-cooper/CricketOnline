'Imports CricketOnline.MyUser
Imports System.Web.UI.StateBag
Imports CricketOnline.Membership
Imports AjaxControlToolkit.Accordion
Public Class _Default
    Inherits System.Web.UI.Page
    Dim MUser As New MyUser()
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Dim loginName, memberID
        'loginName = Membership.GetUser.ToString()
        ' MUser.CheckUser(loginName)
        'memberID = Session("MemberID")
        'Response.Write(memberID)
        'SendReg("pescetto")

    End Sub

End Class