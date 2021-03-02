using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using com.redmine.gorilla.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace com.redmine.gorilla.Pages {
    public class HidePanelModel : PublicPage {
        public void OnGet() {
            string userId = Request.Query["UserId"];
            string userJpg = Request.Query["JpgName"];
            if (string.IsNullOrEmpty(userJpg)==false) {
                User user = HttpContext.Session.Get<User>(SessionExtensions.SessionKey_CUA);
                if (user != null) { }
                userId = user.Id.ToString();

                UserSkin skin = Globals.SkinValues.FirstOrDefault(t => t.UserId.Equals(userId));
                if (skin == null) {
                    skin = new UserSkin(userId, userJpg);
                    Globals.SkinValues.Add(skin);
                } else {
                    skin.JpgPath = userJpg;
                    //Globals.SkinValues.FirstOrDefault(t => t.UserId.Equals(userId)).JpgPath = userJpg;
                }
            }
        }
    }
}