using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using com.redmine.gorilla.Models;

namespace com.redmine.gorilla.Pages.Departments {
    public class IndexModel : PublicPage {
 
        public IList<Department> Department { get; set; }
        public Project Project { get; set; }

        public async Task OnGetAsync() {
            //.Include(d => d.Project)
        }
    }
}