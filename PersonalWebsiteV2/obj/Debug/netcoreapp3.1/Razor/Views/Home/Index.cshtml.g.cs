#pragma checksum "C:\Users\johnn\source\repos\PersonalWebsiteV2\PersonalWebsiteV2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57f2d6ca3b2831f4e37b783c8f96e6e8b0d1af15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\johnn\source\repos\PersonalWebsiteV2\PersonalWebsiteV2\Views\_ViewImports.cshtml"
using PersonalWebsiteV2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\johnn\source\repos\PersonalWebsiteV2\PersonalWebsiteV2\Views\_ViewImports.cshtml"
using PersonalWebsiteV2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57f2d6ca3b2831f4e37b783c8f96e6e8b0d1af15", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad6683ef4ece1ea7279d634ce037b51b9b3a167a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\johnn\source\repos\PersonalWebsiteV2\PersonalWebsiteV2\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""cards-container flex"">
    <div id=""profile-card"" class=""card card--center card--shadowed"">
        <div class=""card__header card__header--p-2"">
            <div class=""avatar""></div>
            <h1 class=""card__heading"">Johnny <strong>Le</strong></h1>
            <div class=""button button--bg-grey"">Web Developer</div>
            <div class=""icon-group container container--p-t-2"">
                <i class=""icon icon--size-4 fab fa-github""></i>
                <i class=""icon icon--size-4 fab fa-linkedin""></i>
            </div>
        </div>
        <div class=""card__content card__content--bg-grey"">
            <ul class=""card__list"">
                <li class=""card__list-item""><i class=""card__list-item-icon fas fa-university""></i>Aston University</li>
                <li class=""card__list-item""><i class=""card__list-item-icon fas fa-location-arrow""></i>Birmingham, UK</li>
                <li class=""card__list-item""><i class=""card__list-item-icon fas fa-book-open""></i>BSc Compute");
            WriteLiteral(@"r Science</li>
            </ul>
        </div>
        <div class=""card__content card__content--p-3"">
            <a class=""button button--tertiary button--bg-secondary"">Email Me</a>
        </div>
    </div>
    <div id=""about-me-card"" class=""card card--shadowed"">
        <div class=""card__header card__header--p-h-2 card__header--p-b-2"">
            <h1 class=""card__heading""><strong>About me</strong></h1>
            <p>I'm a final year undergraduate with industrial experience in web development (full-stack), now looking for a graduate opportunity in software/web development!</p>
            <div class=""button-group"">
                <a href=""#experience-card"" class=""button button--tertiary button--bg-secondary"">Experience</a>
                <a href=""#academics-card"" class=""button button--tertiary button--bg-secondary"">Academics</a>
                <a href=""#"" class=""button button--tertiary button--bg-disabled""><i class=""icon icon--inline fas fa-download""></i>Resume</a>
            </div>
 ");
            WriteLiteral(@"       </div>
        <div class=""card__content card__content--p-2 card__content--bg-grey"">
            <h1 class=""title title--size-3 title-style-1""><strong>What I do</strong></h1>
            <p>I have been programming for 5 years and have over a year of full-stack web development experience working for companies</p>
            <p>Currently, I'm studying for my final year towards my bachelor's degree. Hopefully, I have the experience and rights skills for you to consider me working at your company!</p>
        </div>

    </div>
</div>
");
            WriteLiteral(@"<div class=""cards-container"">
    <div id=""experience-card"" class=""card card--max-width"">
        <div class=""card__header card__header--p-h-2"">
            <h1 class=""card__heading""><strong>Experience</strong></h1>
        </div>
        <div class=""card__content card__content--p-h-2"">
            <div class=""timeline"">
                <div class=""timeline__item"">
                    <h1 class=""timeline__timestamp"">SEP 2019 - SEP 2020</h1>
                    <h2 class=""timeline__title""><span class=""timeline__title--bold"">Placement Web Developer</span> Pinewood Technologies PLC</h2>
                    <div class=""timeline__content"">
                        <p>Technologies: C#, ASP.NET Framework & Core (MVC/API), JS, JQuery, KnockoutJS, SQL (Server), TFS, Docker, Azure Services & DevOps</p>
                        <p>Industrial Placement year in Web development, gaining technical experience in developing/maintaining web APIs, microservices and UX design, working with ASP.NET.</p>
               ");
            WriteLiteral(@"         <p>Managed sites for CarStore.com, Stratstone.com, EvansHalshaw.com and other Pendragon PLC web applications.</p>
                        <ul>
                            <li>Projects: Enrolment portal, DevOps Dashboard</li>
                        </ul>
                    </div>
                </div>
                <div class=""timeline__item"">
                    <h1 class=""timeline__timestamp"">JUN 2019 – SEP 2019</h1>
                    <h2 class=""timeline__title""><span class=""timeline__title--bold"">Web Developer,</span> Beautiful Canoe</h2>
                    <div class=""timeline__content"">
                        <p>Technologies: Laravel, Git (Lab), JS, Bootstrap, Vagrant, R, SQL</p>
                        <p>Summer contractual position developing and maintaining websites for two clients, gaining technical experience, improving team and communicational skills.</p>
                        <p>Projects:</p>
                        <ul>
                            <li>FLDB - Text ");
            WriteLiteral(@"Crimes</li>
                            <li>Aston Contractor and Tradesperson Sign-In System</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div id=""academics-card"" class=""card card--max-width"">
        <div class=""card__header card__header--p-h-2"">
            <h1 class=""card__heading""><strong>Academics</strong></h1>
        </div>
        <div class=""card__content card__content--p-h-2"">
            <div class=""timeline"">
                <div class=""timeline__item"">
                    <h1 class=""timeline__timestamp"">SEP 2017 - PRESENT</h1>
                    <h2 class=""timeline__title""><span class=""timeline__title--bold"">Computer Science BSc,</span> Aston University - Excellence Scholarship</h2>
                    <div class=""timeline__content"">
                        <ul>
                            <li>Year 1 (1st) - including modules in Internet Computing, Database and Information Systems, Java ");
            WriteLiteral(@"Programming Foundations et al.</li>
                            <li>Year 2 (1st) -  including modules in Internet Applications and Techniques, Data Structures and Algorithms, Group Project et al.</li>
                        </ul>
                    </div>
                </div>
                <div class=""timeline__item"">
                    <h1 class=""timeline__timestamp"">SEP 2017 – AUG 2019</h1>
                    <h2 class=""timeline__title""><span class=""timeline__title--bold"">Chinese Mandarin - Beginners and Intermediate,</span> Aston University - LFA Scholarship</h2>
                    <div class=""timeline__content"">
                        <ul>
                            <li>Year 1 (1st) - Beginners</li>
                            <li>Year 2 (1st) - Intermediate</li>
                        </ul>
                    </div>
                </div>
                <div class=""timeline__item"">
                    <h1 class=""timeline__timestamp"">SEP 2015 – AUG 2017</h1>
                ");
            WriteLiteral(@"    <h2 class=""timeline__title""><span class=""timeline__title--bold"">A Levels,</span> Matthew Boulton College</h2>
                    <div class=""timeline__content"">
                        <ul>
                            <li>A - Computing</li>
                            <li>A - Biology</li>
                            <li>B - Mathematics</li>
                        </ul>
                    </div>
                </div>
            </div>

            <h1 class=""alert alert-1 alert-1--primary"">Interests & Hobbies</h1>
            <ul>
                <li>Bouldering and Mountaineering</li>
                <li>Aston Computer Science Society</li>
                <li>Eastern Languages</li>
                <li>Badminton</li>
                <li>Instant Noodles Connoisseur</li>
            </ul>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
