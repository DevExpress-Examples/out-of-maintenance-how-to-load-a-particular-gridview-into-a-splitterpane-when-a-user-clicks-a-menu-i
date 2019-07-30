<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/Controllers/HomeController.vb))
* [MyModel.cs](./CS/Models/MyModel.cs) (VB: [MyModel.vb](./VB/Models/MyModel.vb))
* [GridViewAction.cshtml](./CS/Views/Home/GridViewAction.cshtml)
* [GridViewPartialCustomers.cshtml](./CS/Views/Home/GridViewPartialCustomers.cshtml)
* [GridViewPartialProducts.cshtml](./CS/Views/Home/GridViewPartialProducts.cshtml)
* [Index.cshtml](./CS/Views/Home/Index.cshtml)
<!-- default file list end -->
# How to load a particular GridView into a SplitterPane when a user clicks a Menu item 
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e4332/)**
<!-- run online end -->


<p>This example illustrates how to load a View that renders a PartialView with a particular GridView into the right SplitterPane. This action is performed when a user clicks an item. Here the are main steps:</p><br />
<p>Define the right pane as:<br />
</p>

```cs
pane.Name = "contentUrlPane";
pane.ContentUrlIFrameName = "ContentUrlPane";
pane.ContentUrl = "about:blank";


```

<p>Note that I've set it's ContentUrl property to "about:blank" to force the corresponding iframe element to be included in the pane's render. Then, the pages of your Menu items will be targeted according to the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxMenuMenuItem_Targettopic"><u>Menu.Target</u></a> property.</p><p>After that, handle the client-side <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxMenuScriptsASPxClientMenuBase_ItemClicktopic"><u>ASPxClientMenu.ItemClick</u></a> event and call the client-side <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxSplitterScriptsASPxClientSplitterPane_SetContentUrltopic"><u>SetContentUrl</u></a> method of the right pane to load the necessary page:<br />
</p>

```cs
settingsMenu.ClientSideEvents.ItemClick =
            String.Format("function(s, e) {{ splitter.GetPaneByName('contentUrlPane').SetContentUrl('{0}?_GridViewName=' + e.item.name); }}", Url.Action("GridViewAction", "Home"));
```

<p> </p>

<br/>


