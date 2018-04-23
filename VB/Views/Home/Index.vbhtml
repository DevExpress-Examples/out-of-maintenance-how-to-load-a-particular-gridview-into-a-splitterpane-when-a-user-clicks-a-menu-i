@ModelType VB.MyViewModel
@Html.DevExpress().Menu( _
    Sub(settingsMenu)
            settingsMenu.Name = "mainMenu"
            settingsMenu.Items.Add("Products", "products").Target = "ContentUrlPane"
            settingsMenu.Items.Add("Customers", "customers").Target = "ContentUrlPane"

            settingsMenu.ClientSideEvents.ItemClick =
                String.Format("function(s, e) {{ splitter.GetPaneByName('contentUrlPane').SetContentUrl('{0}?_GridViewName=' + e.item.name); }}", Url.Action("GridViewAction", "Home"))
    End Sub).GetHtml()
<br />
@Html.DevExpress().Splitter( _
   Sub(settings)
           settings.Name = "splitter"
           settings.Height = 250
           settings.Width = System.Web.UI.WebControls.Unit.Percentage(100)
           settings.ShowCollapseBackwardButton = True
           settings.ShowCollapseForwardButton = True

           settings.Panes.Add(Sub(pane)
                                      pane.Name = "TextPane"
                                      pane.Size = 300
                                      pane.SetContent(Sub() ViewContext.Writer.Write("Click a Menu item to load the particular GridView"))
                              End Sub)
           settings.Panes.Add(Sub(pane)
                                      pane.Name = "contentUrlPane"
                                      pane.ContentUrlIFrameName = "ContentUrlPane"
                                      pane.ContentUrl = "about:blank"
                              End Sub)
   End Sub).GetHtml()
