#pragma checksum "D:\CoreDemo\Views\Comment\CommentListByBlog.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "fb2564c4873fb9cdff85345634b123955f701598e8dfc385b0e8b03a20705291"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_Comment_CommentListByBlog), @"mvc.1.0.view", @"/Views/Comment/CommentListByBlog.cshtml")]
namespace AspNetCoreGeneratedDocument
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo

#nullable disable
    ;
#nullable restore
#line 2 "D:\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models

#nullable disable
    ;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"fb2564c4873fb9cdff85345634b123955f701598e8dfc385b0e8b03a20705291", @"/Views/Comment/CommentListByBlog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"28e9796c92c1d16a3954ba6ba0aa2474261584969ce6f7ea25d023e9241fc234", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Views_Comment_CommentListByBlog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 1 "D:\CoreDemo\Views\Comment\CommentListByBlog.cshtml"
       IEnumerable<EntityLayer.Concrete.Comment>

#line default
#line hidden
#nullable disable
    >
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"comment-top\">\r\n\t<h4>Comments</h4>\r\n\t<div class=\"media\">\r\n\t\t<img src=\"images/t1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 147, "\"", 153, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid"" />
		<div class=""media-body"">
			<h5 class=""mt-0"">Joseph Goh</h5>
			<p>
				Lorem Ipsum convallis diam consequat magna vulputate malesuada. id dignissim sapien velit id felis ac cursus eros.
				Cras a ornare elit.
			</p>

			<div class=""media mt-3"">
				<a class=""d-flex pr-3"" href=""#"">
					<img src=""images/t2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 502, "\"", 508, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid"" />
				</a>
				<div class=""media-body"">
					<h5 class=""mt-0"">Richard Spark</h5>
					<p>
						Lorem Ipsum convallis diam consequat magna vulputate malesuada. id dignissim sapien velit id felis ac cursus eros.
						Cras a ornare elit.
					</p>
				</div>
			</div>
		</div>
	</div>
</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Comment>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
