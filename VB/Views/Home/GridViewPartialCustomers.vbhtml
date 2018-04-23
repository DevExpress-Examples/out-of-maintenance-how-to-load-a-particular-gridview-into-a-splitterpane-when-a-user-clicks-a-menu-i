@Html.DevExpress().GridView( _
    Sub(settings)
            settings.Name = "gvCustomers"
            settings.CallbackRouteValues = New With {.Controller = "Home", .Action = "GridViewPartialCustomers"}
            
            settings.KeyFieldName = "CustomerID"

            settings.Columns.Add("CustomerID")
            settings.Columns.Add("CompanyName")
    End Sub).Bind(Model).GetHtml()