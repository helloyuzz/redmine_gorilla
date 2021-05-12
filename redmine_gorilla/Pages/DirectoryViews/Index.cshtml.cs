using com.redmine.gorilla;
using com.redmine.gorilla.Models;
using DirectoryView;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DirectoryInfo.Pages {
    public class IndexModel : PublicPage {
        private readonly ILogger<IndexModel> _logger;
        public List<FileView> AllFiles { get; set; }
        public IndexModel(ILogger<IndexModel> logger) {
            _logger = logger;
        }

        public void OnGet() {
            _CrumbList.Add(new CrumbItem("原型列表"));
            AllFiles = new List<FileView>();
            string[] path = Directory.GetDirectories(Globals.PrototypePath);
            foreach (string item in path) {
                if (item.StartsWith(".\\.")) {
                    continue;
                }
                if (item.IndexOf(".") != item.LastIndexOf(".")) {
                    FileInfo fileInfo = new FileInfo(item);
                    AllFiles.Add(new FileView(fileInfo.Name, ""));
                }
            }
        }
    }
}
