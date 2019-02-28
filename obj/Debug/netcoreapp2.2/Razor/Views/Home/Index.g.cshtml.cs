#pragma checksum "/Users/berilbaltaci/Desktop/Comp4920_SAS/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed3aa2542df3223ed0d1985aeaebc9b14fcb499b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/berilbaltaci/Desktop/Comp4920_SAS/Views/_ViewImports.cshtml"
using Comp4920_SAS;

#line default
#line hidden
#line 2 "/Users/berilbaltaci/Desktop/Comp4920_SAS/Views/_ViewImports.cshtml"
using Comp4920_SAS.Models;

#line default
#line hidden
#line 1 "/Users/berilbaltaci/Desktop/Comp4920_SAS/Views/Home/Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#line 2 "/Users/berilbaltaci/Desktop/Comp4920_SAS/Views/Home/Index.cshtml"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed3aa2542df3223ed0d1985aeaebc9b14fcb499b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a3f0d893d19d02fabdb508e281809fd407a57eb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-xs btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "/Users/berilbaltaci/Desktop/Comp4920_SAS/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "_Layout";
	DataContext db=new DataContext();
    User usr = HttpContextAccessor.HttpContext.Session.GetObject<User>("user");
	

#line default
#line hidden
#line 11 "/Users/berilbaltaci/Desktop/Comp4920_SAS/Views/Home/Index.cshtml"
 if (usr.UserRole == 1)
{
	Student getStudent = db.Students.FirstOrDefault(t => t.UserId==usr.UserId);
	List<CourseStudent> getCourseStudentList = db.CourseStudents.Where(t => t.StudentId == getStudent.StudentId).ToList();
	Course[] getCourseList = new Course[getCourseStudentList.Count];
	int i = 0;
	foreach (var item in getCourseStudentList)
	{
		getCourseList[i] = db.Courses.SingleOrDefault(t => t.Id == item.CourseId);
		i++;
	}

#line default
#line hidden
            BeginContext(737, 545, true);
            WriteLiteral(@"	<div class=""row"">
		<div class=""col-lg-12 col-lg-12"">
			<section class=""panel"">
				<header class=""panel-heading panel-heading-transparent"">
					<h2 class=""panel-title"">Alınan Dersler</h2>
				</header>
				<div class=""panel-body"">
					<div class=""table-responsive"">
						<table class=""table table-striped mb-none"">
							<thead>
							<tr>
								<th>#</th>
								<th>Dersler</th>
								<th>Ders Kodu</th>
								<th>Devamsızlık Sayısı</th>
								<th>Durum</th>
								<th>Detay</th>
							</tr>
							</thead>
							<tbody>
");
            EndContext();
#line 42 "/Users/berilbaltaci/Desktop/Comp4920_SAS/Views/Home/Index.cshtml"
                              
								i = 0;
							

#line default
#line hidden
            BeginContext(1316, 7, true);
            WriteLiteral("\t\t\t\t\t\t\t");
            EndContext();
#line 45 "/Users/berilbaltaci/Desktop/Comp4920_SAS/Views/Home/Index.cshtml"
                             foreach (var item in getCourseStudentList)
							{

#line default
#line hidden
            BeginContext(1376, 26, true);
            WriteLiteral("\t\t\t\t\t\t\t\t<tr>\n\t\t\t\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(1404, 3, false);
#line 48 "/Users/berilbaltaci/Desktop/Comp4920_SAS/Views/Home/Index.cshtml"
                                    Write(i+1);

#line default
#line hidden
            EndContext();
            BeginContext(1408, 19, true);
            WriteLiteral("</td>\n\t\t\t\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(1428, 27, false);
#line 49 "/Users/berilbaltaci/Desktop/Comp4920_SAS/Views/Home/Index.cshtml"
                                   Write(getCourseList[i].CourseName);

#line default
#line hidden
            EndContext();
            BeginContext(1455, 19, true);
            WriteLiteral("</td>\n\t\t\t\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(1475, 27, false);
#line 50 "/Users/berilbaltaci/Desktop/Comp4920_SAS/Views/Home/Index.cshtml"
                                   Write(getCourseList[i].CourseCode);

#line default
#line hidden
            EndContext();
            BeginContext(1502, 19, true);
            WriteLiteral("</td>\n\t\t\t\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(1522, 18, false);
#line 51 "/Users/berilbaltaci/Desktop/Comp4920_SAS/Views/Home/Index.cshtml"
                                   Write(item.AttendanceSum);

#line default
#line hidden
            EndContext();
            BeginContext(1540, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 52 "/Users/berilbaltaci/Desktop/Comp4920_SAS/Views/Home/Index.cshtml"
                                     if (item.AttendanceSituation == 1)
									{

#line default
#line hidden
            BeginContext(1602, 65, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t<td><span class=\"label label-success\">Good</span></td>\n");
            EndContext();
#line 55 "/Users/berilbaltaci/Desktop/Comp4920_SAS/Views/Home/Index.cshtml"
									}
									else if (item.AttendanceSituation == 2)
									{

#line default
#line hidden
            BeginContext(1738, 69, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t<td><span class=\"label label-warning\">Critical</span></td>\n");
            EndContext();
#line 59 "/Users/berilbaltaci/Desktop/Comp4920_SAS/Views/Home/Index.cshtml"

									}
									else if (item.AttendanceSituation == 3)
									{

#line default
#line hidden
            BeginContext(1879, 66, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t<td><span class=\"label label-danger\">Repeat</span></td>\n");
            EndContext();
#line 64 "/Users/berilbaltaci/Desktop/Comp4920_SAS/Views/Home/Index.cshtml"
									}

#line default
#line hidden
            BeginContext(1956, 9, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t");
            EndContext();
#line 65 "/Users/berilbaltaci/Desktop/Comp4920_SAS/Views/Home/Index.cshtml"
                                      
										i++;	
									

#line default
#line hidden
            BeginContext(1995, 24, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t<td>\n\t\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(2019, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed3aa2542df3223ed0d1985aeaebc9b14fcb499b9109", async() => {
                BeginContext(2073, 5, true);
                WriteLiteral("Detay");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2028, "~/Home/Detail/", 2028, 14, true);
#line 69 "/Users/berilbaltaci/Desktop/Comp4920_SAS/Views/Home/Index.cshtml"
AddHtmlAttributeValue("", 2042, item.Id, 2042, 8, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2082, 333, true);
            WriteLiteral(@"
										<!-- <div class=""progress progress-sm progress-half-rounded m-none mt-xs light"">
											<div class=""progress-bar progress-bar-primary"" role=""progressbar"" aria-valuenow=""60"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 100%;"">
												100%
											</div>
										</div> -->
									</td>
								</tr>
");
            EndContext();
#line 77 "/Users/berilbaltaci/Desktop/Comp4920_SAS/Views/Home/Index.cshtml"
							}

#line default
#line hidden
            BeginContext(2424, 85, true);
            WriteLiteral("\t\t\t\t\t\t\t</tbody>\n\t\t\t\t\t\t</table>\n\t\t\t\t\t</div>\n\t\t\t\t</div>\n\t\t\t</section>\n\t\t</div>\n\t</div>\n");
            EndContext();
#line 85 "/Users/berilbaltaci/Desktop/Comp4920_SAS/Views/Home/Index.cshtml"

}else if (usr.UserRole == 2)
{
	Teacher getTeacher = db.Teachers.FirstOrDefault(t => t.UserId == usr.UserId);
	List<CourseTeacher> getCourseTeacherList = db.CourseTeachers.Where(t => t.TeacherId == getTeacher.TeacherId).ToList();
	Course[] getCourseList = new Course[getCourseTeacherList.Count];
	List<CourseStudent> getCourseStudentList=new List<CourseStudent>();

	int stuNum = 0;
	int i = 0;
	foreach (var crs in getCourseTeacherList)
	{
		getCourseList[i] = db.Courses.FirstOrDefault(t => t.Id == crs.CourseId);
		CourseStudent cs = db.CourseStudents.FirstOrDefault(t => t.CourseId == getCourseList[i].Id);
		getCourseStudentList.Add(cs);
		i++;
	}
	

#line default
#line hidden
            BeginContext(3165, 522, true);
            WriteLiteral(@"	<div class=""col-lg-12 col-lg-12"">
		<section class=""panel"">
			<header class=""panel-heading panel-heading-transparent"">

				<h2 class=""panel-title"">Verilen Dersler</h2>
			</header>
			<div class=""panel-body"">
				<div class=""table-responsive"">
					<table class=""table table-striped mb-none"">
						<thead>
						<tr>
							<th>#</th>
							<th>Dersler</th>
							<th>Ders Kodu</th>
							<th>Öğrenci sayısı</th>
							<th>Sınıf Listesi</th>
							<th>Yoklama Girişi</th>
						</tr>
						</thead>
						<tbody>
");
            EndContext();
#line 123 "/Users/berilbaltaci/Desktop/Comp4920_SAS/Views/Home/Index.cshtml"
                          
							i = 0;
						

#line default
#line hidden
            BeginContext(3718, 6, true);
            WriteLiteral("\t\t\t\t\t\t");
            EndContext();
#line 126 "/Users/berilbaltaci/Desktop/Comp4920_SAS/Views/Home/Index.cshtml"
                         foreach (var item in getCourseTeacherList)
						{

#line default
#line hidden
            BeginContext(3776, 24, true);
            WriteLiteral("\t\t\t\t\t\t\t<tr>\n\t\t\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(3802, 3, false);
#line 129 "/Users/berilbaltaci/Desktop/Comp4920_SAS/Views/Home/Index.cshtml"
                                Write(i+1);

#line default
#line hidden
            EndContext();
            BeginContext(3806, 18, true);
            WriteLiteral("</td>\n\t\t\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(3825, 27, false);
#line 130 "/Users/berilbaltaci/Desktop/Comp4920_SAS/Views/Home/Index.cshtml"
                               Write(getCourseList[i].CourseName);

#line default
#line hidden
            EndContext();
            BeginContext(3852, 18, true);
            WriteLiteral("</td>\n\t\t\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(3871, 27, false);
#line 131 "/Users/berilbaltaci/Desktop/Comp4920_SAS/Views/Home/Index.cshtml"
                               Write(getCourseList[i].CourseCode);

#line default
#line hidden
            EndContext();
            BeginContext(3898, 19, true);
            WriteLiteral("</td>\n\t\t\t\t\t\t\t\t<td>\n");
            EndContext();
#line 133 "/Users/berilbaltaci/Desktop/Comp4920_SAS/Views/Home/Index.cshtml"
                                     foreach (var item2 in getCourseStudentList)
									{
										if (item2.CourseId == item.CourseId)
										{
											stuNum++;
										}
									}

#line default
#line hidden
            BeginContext(4085, 9, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(4095, 6, false);
#line 140 "/Users/berilbaltaci/Desktop/Comp4920_SAS/Views/Home/Index.cshtml"
                               Write(stuNum);

#line default
#line hidden
            EndContext();
            BeginContext(4101, 24, true);
            WriteLiteral("\n\t\t\t\t\t\t\t\t</td>\n\t\t\t\t\t\t\t\t\n");
            EndContext();
#line 143 "/Users/berilbaltaci/Desktop/Comp4920_SAS/Views/Home/Index.cshtml"
                                  
									i++;	
								

#line default
#line hidden
            BeginContext(4161, 22, true);
            WriteLiteral("\t\t\t\t\t\t\t\t<td>\n\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(4183, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed3aa2542df3223ed0d1985aeaebc9b14fcb499b15660", async() => {
                BeginContext(4254, 13, true);
                WriteLiteral("Sınıf Listesi");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4192, "~/Home/CourseList/", 4192, 18, true);
#line 147 "/Users/berilbaltaci/Desktop/Comp4920_SAS/Views/Home/Index.cshtml"
AddHtmlAttributeValue("", 4210, item.CourseId, 4210, 14, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4271, 37, true);
            WriteLiteral("\n\t\t\t\t\t\t\t\t</td>\n\t\t\t\t\t\t\t\t<td>\n\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(4308, 98, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed3aa2542df3223ed0d1985aeaebc9b14fcb499b17488", async() => {
                BeginContext(4388, 14, true);
                WriteLiteral("Yoklama Girişi");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4317, "~/Home/AttendanceEntryList/", 4317, 27, true);
#line 150 "/Users/berilbaltaci/Desktop/Comp4920_SAS/Views/Home/Index.cshtml"
AddHtmlAttributeValue("", 4344, item.CourseId, 4344, 14, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4406, 28, true);
            WriteLiteral("\n\t\t\t\t\t\t\t\t</td>\n\t\t\t\t\t\t\t</tr>\n");
            EndContext();
#line 153 "/Users/berilbaltaci/Desktop/Comp4920_SAS/Views/Home/Index.cshtml"
						}

#line default
#line hidden
            BeginContext(4442, 71, true);
            WriteLiteral("\t\t\t\t\t\t</tbody>\n\t\t\t\t\t</table>\n\t\t\t\t</div>\n\t\t\t</div>\n\t\t</section>\n\t</div>\n");
            EndContext();
#line 160 "/Users/berilbaltaci/Desktop/Comp4920_SAS/Views/Home/Index.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
