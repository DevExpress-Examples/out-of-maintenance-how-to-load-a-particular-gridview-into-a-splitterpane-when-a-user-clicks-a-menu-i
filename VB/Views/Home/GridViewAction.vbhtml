@ModelType VB.MyViewModel
@Code
    ViewBag.Title = "GridViewAction"
    
    If ViewData("GridViewName").ToString() = "products" Then
        Html.RenderPartial("GridViewPartialProducts", Model.Products)
    Else
          Html.RenderPartial("GridViewPartialCustomers", Model.Customers)
    End If
End Code