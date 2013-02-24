Imports Limilabs.Client.IMAP
Imports Limilabs.Client.POP3
Imports Limilabs.Client.SMTP
Imports Limilabs.Mail
Imports Limilabs.Mail.Fluent
Imports Limilabs.Mail.Headers
Imports Limilabs.Mail.MIME
Imports Limilabs.Mail.Templates


Public Class ConfirmReg
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim templateData As Contact

        Dim html As String = Template _
        .FromFile("C:\Users\Gary\Documents\Visual Studio 2010\Projects\CricketOnline\CricketOnline\Account\Template.txt") _
        .DataFrom(templateData) _
        .Render()

        Fluent.Mail.Html(Template _
                       .FromFile("C:\Users\Gary\Documents\Visual Studio 2010\Projects\CricketOnline\CricketOnline\Account\Template.txt") _
                       .DataFrom(templateData) _
                       .Render()) _
                        .From(New MailBox("gary@utopiamodels.co.uk", "CricketOnline")) _
                        .[To](New MailBox("gary@waldrom.com", "Gary")) _
                        .Subject("Site Registration") _
                        .UsingNewSmtp() _
                        .WithCredentials("info@utopiamodels.co.uk", "Sl4ckBl4dd3r") _
                        .Server("mail.utopiamodels.co.uk") _
                        .Send()
    End Sub

End Class