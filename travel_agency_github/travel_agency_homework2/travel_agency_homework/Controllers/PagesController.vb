Imports System.Web.Mvc

Namespace Controllers
    Public Class PagesController
        Inherits Controller

        Function Destination() As ActionResult
            Return View()
        End Function

        Function Booking() As ActionResult
            Return View()
        End Function

        Function Team() As ActionResult
            Return View()
        End Function

        Function Testimonial() As ActionResult
            Return View()
        End Function
    End Class
End Namespace
