#pragma checksum "C:\Users\deploy\source\repos\RepairShop_mvc\RepairMvc\Pages\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d6f58f57c11ec8fa4f560a6424548f40a744f04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RepairMvc.Pages.About.Pages_About_Index), @"mvc.1.0.razor-page", @"/Pages/About/Index.cshtml")]
namespace RepairMvc.Pages.About
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\deploy\source\repos\RepairShop_mvc\RepairMvc\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\deploy\source\repos\RepairShop_mvc\RepairMvc\Pages\_ViewImports.cshtml"
using RepairMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\deploy\source\repos\RepairShop_mvc\RepairMvc\Pages\_ViewImports.cshtml"
using RepairMvc.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d6f58f57c11ec8fa4f560a6424548f40a744f04", @"/Pages/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ede30d28851247df71befcbf0abb91bbc666be52", @"/Pages/_ViewImports.cshtml")]
    public class Pages_About_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\deploy\source\repos\RepairShop_mvc\RepairMvc\Pages\About\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<p class=""title"">About</p>

<article class=""message is-info"">
    <div class=""message-header"">
        <p>Sql-server and Entity Framework</p>
        <button class=""delete"" aria-label=""delete""></button>
    </div>
    <div class=""message-body"">
        <p><strong>Code first</strong> database, using <strong>Entity Framework</strong> to generate the database tables.</p>
        <p><strong>Sql Querries</strong> to fill the database with default products.</p>
        <p>Scaffolded <strong>Identity</strong> into the project, Appuser inherits from the IdentityUser class.</p>
    </div>
</article>

<article class=""message is-info"">
    <div class=""message-header"">
        <p>Mvc and Razorpages</p>
        <button class=""delete"" aria-label=""delete""></button>
    </div>
    <div class=""message-body"">
        <strong>MVC:</strong>
        <p>Models -> RepairMvcDomain.Models</p>
        <p>Views -> RepairMvc.Pages</p>
        <p>Controllers -> RepairMvc.Controllers</p>
</div>
</article>

<ar");
            WriteLiteral(@"ticle class=""message is-info"">
    <div class=""message-header"">
        <p>Vue.js, Axios http client and Bulma.css frontend</p>
        <button class=""delete"" aria-label=""delete""></button>
    </div>
    <div class=""message-body"">
        <p><strong>Vue.js</strong></p>
        <p>
            open-source model–view–viewmodel front end.
            JavaScript framework for building user interfaces
            and single-page applications.
        </p>
        <p><strong>Axios</strong></p>
        <p>
            A promise based http client.
        </p>
        <p><strong>Bulma.css</strong></p>
        <p>
            Library for Css Styling.
        </p>
    </div>
</article>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RepairMvc.Pages.About.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RepairMvc.Pages.About.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RepairMvc.Pages.About.IndexModel>)PageContext?.ViewData;
        public RepairMvc.Pages.About.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591