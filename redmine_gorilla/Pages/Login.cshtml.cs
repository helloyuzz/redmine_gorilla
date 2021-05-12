using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using com.redmine.gorilla.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Redmine.Net.Api;
using Redmine.Net.Api.Exceptions;

namespace com.redmine.gorilla.Pages {
    public class LoginModel : PublicPage {
        private User User { get; set; }

        public string tipDisplayed = "none";
  

        public IActionResult OnGet() {
            return RedirectToPage("/Progresses/Index");
            ModelState.Clear();
            string temp = Request.Query["errcode"];//.ContainsKey("errcode");
            try {
                DateTime dt;
                DateTime.TryParse(temp, out dt);

                if (DateTime.Now.Second - dt.Second > 5) {
                    tipDisplayed = "none";
                } else {
                    tipDisplayed = "block";
                }

            } catch (Exception exc) {
                tipDisplayed = "none";
            }
            return Page();
        }
        [BindProperty(SupportsGet = true), Required(ErrorMessage = "帐号不能为空"), Display(Name = "帐号")]
        public string Account { get; set; }
        [BindProperty(SupportsGet = true), Required(ErrorMessage = "密码不能为空"), Display(Name = "密码")]
        public string Password { get; set; }
        public async Task<IActionResult> OnPostAsync() {
            if (!ModelState.IsValid) {
                return Page();
            }
            var proj_collection = new NameValueCollection { { RedmineKeys.INCLUDE, RedmineKeys.RELATIONS } };
            RedmineManager manager = new RedmineManager(Globals.RedmineURL, Account, Password, MimeFormat.Json);
            try {
                var getProjectes = manager.GetObjects<Redmine.Net.Api.Types.Project>(proj_collection);

                //User user = new User();
                //user.User_account = Account;
                //user.User_password = Password;
                //user.Theme_url = "/images/4.jpg";

                if (Account.Equals("redmine") == false) {
                    manager = new RedmineManager(Globals.RedmineURL, "redmine", "aa123456", MimeFormat.Json);
                }
                var getAllUser = manager.GetObjects<Redmine.Net.Api.Types.User>(new NameValueCollection(){
                {RedmineKeys.STATUS, ((int)Redmine.Net.Api.Types.UserStatus.StatusActive).ToString(CultureInfo.InvariantCulture)},{ RedmineKeys.INCLUDE, RedmineKeys.RELATIONS }
            });
                GorillaUtil.Resort(getAllUser);

                User user = Globals.AllUser.FirstOrDefault(t => t.User_account.Equals(Account));
                user.User_password = Password;
                SessionExtensions.Set<User>(HttpContext.Session, SessionExtensions.SessionKey_CUA, user);

                return RedirectToPage("Index");
            } catch (RedmineException exc) {
                return RedirectToPage("Login", new { errcode = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") });
            }
        }
    }
}
