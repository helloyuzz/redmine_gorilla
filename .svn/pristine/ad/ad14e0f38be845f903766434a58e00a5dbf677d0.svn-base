using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using com.redmine.gorilla.Models;
using com.redmine.gorilla.AppGorilla.Utils;

namespace com.redmine.gorilla.Pages.Users {
    public class IndexModel : PublicPage {
        public List<User> AllUser { get; set; }

        public async Task OnGetAsync() {
            _CrumbList.Add(new CrumbItem("用户管理"));

            AllUser = Globals.AllUser;
        }
    }
}