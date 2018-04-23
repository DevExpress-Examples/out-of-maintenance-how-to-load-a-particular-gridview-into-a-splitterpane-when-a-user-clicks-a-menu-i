Imports Microsoft.VisualBasic
Imports System.Web.Mvc

Namespace CS.Controllers
    Public Class HomeController
        Inherits Controller
        Public Function Index() As ActionResult
            Return View()
        End Function

        Public Function GridViewAction(_GridViewName As [String]) As ActionResult
            ViewData("GridViewName") = _GridViewName
            Return View(New MyViewModel() With {.Products = MyModel.GetProducts(), .Customers = MyModel.GetCustomers()})
        End Function

        Public Function GridViewPartialProducts() As ActionResult
            Return PartialView(MyModel.GetProducts())
        End Function

        Public Function GridViewPartialCustomers() As ActionResult
            Return PartialView(MyModel.GetCustomers())
        End Function
    End Class

End Namespace
