Imports System.Web.Mvc

Namespace Controllers
    Public Class HomeController
        Inherits Controller

        ' GET: Home
        Function Index() As ActionResult
            Return View()
        End Function
        Function About() As ActionResult
            Return View()
        End Function
        Function Service() As ActionResult
            Return View()
        End Function
        Function Package() As ActionResult
            Return View()
        End Function
        Function Contact() As ActionResult
            Return View()
        End Function
        Function Register() As ActionResult
            Return View()
        End Function
        Function Signin() As ActionResult
            Return View()
        End Function

        Function ProcessBooking(ByVal name As String, ByVal email As String, ByVal datetime As String, ByVal destination As String, ByVal message As String) As ActionResult
            ViewData("Name") = name
            ViewData("Email") = email
            ViewData("Datetime") = datetime
            ViewData("Destination") = destination
            ViewData("Message") = message

            Return View()
        End Function
        Function ShowBookingData(ByVal name As String, ByVal email As String, ByVal datetime As String, ByVal destination As String, ByVal specialRequest As String) As ActionResult
            ViewData("Name") = name
            ViewData("Email") = email
            ViewData("Datetime") = datetime
            ViewData("Destination") = destination
            ViewData("SpecialRequest") = specialRequest

            Return View()
        End Function
    End Class
End Namespace