using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using com.redmine.gorilla.Models;
using Redmine.Net.Api;
using Redmine.Net.Api.Exceptions;
using System.Collections.Specialized;
using com.redmine.gorilla.AppGorilla.Utils;

namespace com.redmine.gorilla.Pages.Progresses {
    public class IndexModel : PublicPage {
        public IList<ProjectVersion> AllVersion { get; set; }

        public async Task<IActionResult> OnGetAsync() {
            _CrumbList.Add(new CrumbItem("当前项目进度"));
            AllVersion = new List<ProjectVersion>();

            User user = SessionExtensions.Get<User>(HttpContext.Session, SessionExtensions.SessionKey_CUA);
            if (user == null) {
                return RedirectToPage("Login");
            }
            RedmineManager manager = new RedmineManager(Globals.RedmineURL, user.User_account, user.User_password, MimeFormat.Json);
            try {
                var getCondition = new NameValueCollection { { RedmineKeys.PROJECT_ID, "4" },{ RedmineKeys.INCLUDE, RedmineKeys.RELATIONS }, { RedmineKeys.INCLUDE, RedmineKeys.USER } };
                var allVersion = manager.GetObjects<Redmine.Net.Api.Types.Version>(getCondition);
                allVersion.Sort(new VarcharComparer());
                foreach (Redmine.Net.Api.Types.Version item in allVersion) {
                    ProjectVersion temp = new ProjectVersion();
                    temp.Version = item.Name;
                    temp.Name1 = item.Name;
                    temp.Id = item.Id;
                    if (item.DueDate != null) {
                        temp.PlanComplete = item.DueDate.Value.ToString("yyyy-MM-dd");
                    } else {
                        temp.PlanComplete = "N/A";
                    }
                    foreach (var customItem in item.CustomFields) {
                        string customValue = "";
                        if (customItem.Values != null && customItem.Values.Count > 0) {
                            foreach (var tempValue in customItem.Values) {
                                if (string.IsNullOrEmpty(customValue) == false) {
                                    customValue += ", ";
                                }

                                switch (customItem.Name) {
                                    case "需求来源":
                                    case "参与评审人员":
                                        int userid = int.Parse(tempValue.Info);
                                        User getUser = Globals.AllUser.FirstOrDefault(t => t.Id == userid);

                                        if (customItem.Name.Equals("需求来源") && string.IsNullOrEmpty(customValue)==false) {
                                            customValue +=  "<br>";
                                        }
                                        customValue += "<a href=\"" + Globals.RedmineURL + "/users/" + userid+ "\" target=\"_blank\">"+getUser.User_name+"</a>";
                                        break;
                                    default:
                                        customValue += tempValue.Info;
                                        break;
                                }
                            }

                            switch (customItem.Name) {
                                case "开始研发":                                    
                                        temp.StartPrograming = customValue;
                                    break;
                                case "实际完成":
                                    if (string.IsNullOrEmpty(customValue)) {
                                        temp.RealComplete = "N/A";
                                    } else {
                                        temp.RealComplete = customValue;
                                    }
                                    break;
                                case "状态":
                                    if (customValue.Equals("研发中")) {
                                        temp.Status = "<span style =\"color:red;\">研发中</span>";
                                    } else {
                                    temp.Status = customValue;
                                    }                                    
                                    break;
                                case "需求来源":
                                    temp.Source = customValue;
                                    break;
                                case "功能需求清单(URL)":
                                    if (string.IsNullOrEmpty(customValue)) {
                                        temp.RequirementURL = "N/A";
                                    } else {
                                        temp.RequirementURL = "<a href=\"" + customValue + "\" target=\"_blank\">查看需求</a>";
                                    }
                                    break;
                                case "参与评审人员":
                                    temp.EmployeeList = customValue;
                                    break;
                                case "产品原型(URL)":
                                    if (string.IsNullOrEmpty(customValue)) {
                                        temp.PrototypeURL = "N/A";
                                    } else {
                                        temp.PrototypeURL = "<a href=\"" + customValue + "\" target=\"_blank\">查看原型</a>";
                                    }
                                    break;
                                case "发布日期":
                                    if (string.IsNullOrEmpty(customValue)) {
                                        temp.PublishBy = "N/A";
                                    } else {
                                        temp.PublishBy = customValue;
                                    }
                                    break;
                                case "Release地址":
                                    if (string.IsNullOrEmpty(customValue) == false) {
                                        temp.ReleasePath = "<a href=\"" + customValue + "\" target=\"_blank\">提取升级包</a>";
                                    } else {
                                        temp.ReleasePath = "N/A";
                                    }
                                    break;
                            }
                        }
                    }
                    if (temp.Status.IndexOf("研发中") != -1) {
                        temp.Version = temp.RequirementURL.Replace("查看需求", "<b>" + item.Name + "</b>");
                    } else if (temp.RequirementURL.IndexOf("查看需求") != -1) {
                        temp.Version = temp.RequirementURL.Replace("查看需求", "<b>" + item.Name + "</b>");
                    }
                    AllVersion.Add(temp);
                }
            } catch (RedmineException exc) {
            }
            return Page();
        }

        public int RecordCount { get; set; }
    }
}
