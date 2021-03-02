using com.redmine.gorilla.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace com.redmine.gorilla {
    public class PublicPage : PageModel {
        [BindProperty(SupportsGet =true)]
        public string FromPage { get; set; }
        [BindProperty(SupportsGet =true)]
        public string ViewType { get; set; }
        [BindProperty]
        public User User { get; set; }

        public List<CrumbItem> _CrumbList = new List<CrumbItem>();
        public PublicPage() {
        }
    }
}
