using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using com.redmine.gorilla;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DirectoryView.Pages {
    public class OpenModel : PublicPage {
        public string ArguId { get; set; }
        public void OnGet(string id) {
            _CrumbList.Add(new com.redmine.gorilla.Models.CrumbItem("原型预览"));
            if (string.IsNullOrEmpty(id)) {
                ArguId = "参数不能为空";
            } else {
                ArguId = id;
                string localPath = Globals.PrototypePath;
                string[] htmlFiles = Directory.GetFiles(localPath, id + "*.html", SearchOption.AllDirectories);
                if (htmlFiles.Length <= 0) {
                    htmlFiles = Directory.GetFiles(localPath, "*_" + id + "*.html", SearchOption.AllDirectories);
                }
                if (htmlFiles.Length > 0) {
                    FileInfo htmlFile = new FileInfo(htmlFiles[0]);
                    string filePath = htmlFile.FullName.Replace("\\", "/");
                    filePath = filePath.Replace(localPath, "").Replace(".html","");
                    filePath = filePath.Insert(filePath.IndexOf("/")+1, "#p=");

                    Response.Redirect(Globals.PrototypeURL + filePath);
                }
            }
        }
    }
}
