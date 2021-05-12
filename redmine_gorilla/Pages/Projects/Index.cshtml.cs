using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using com.redmine.gorilla.Models;

namespace com.redmine.gorilla.Pages.Projects {
    public class IndexModel : PublicPage {
 

        public IList<Project> Projects { get; set; }

        public async Task<IActionResult> OnGet() {
            _CrumbList.Add(new CrumbItem("医院项目列表",true,true));
            ViewData["CrumbList"] = _CrumbList;

            //User user = HttpContext.Session.Get<User>(SessionExtensions.SessionKey_CUA);
            //if (user == null) {
            //    return RedirectToPage("Login");
            //}
            int nCount = Globals.AllUser.Count;
            SessionExtensions.Set<string>(HttpContext.Session, SessionExtensions.SessionKey_ActiveMenuId, "naviMenu_Project");
            Projects = Globals.AllProject;

            return Page();
        }
        [BindProperty(SupportsGet = true)]
        public string SearchProjectName { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchProvince { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchProgress { get; set; }
        [BindProperty(SupportsGet = true)]
        public int PageSize { get; set; } = 12;
        [BindProperty(SupportsGet = true)]
        public int PageIndex { get; set; } = 1;
        [BindProperty(SupportsGet = true)]
        public int PageCount { get; set; }
        [BindProperty(SupportsGet = true)]
        public int RecordCount { get; set; }
        [BindProperty(SupportsGet =true)]
        public string HtmlTip { get; set; }
    }
}