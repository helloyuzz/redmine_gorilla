using com.redmine.gorilla.AppGorilla.Utils;
using com.redmine.gorilla.Models;
using com.redmine.gorilla.TreeView;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace com.redmine.gorilla {
    public class GorillaUtil {
        public static string NewUUID {
            get {
                return Guid.NewGuid().ToString().Replace("-", "");
            }
        }

        internal static int QueryInt(IQueryCollection query, string key) {
            return ParseInt(query[key]);
        }
        public static int ParseInt(object value) {
            int intValue = 0;
            if (value != null) {
                int.TryParse(value.ToString(), out intValue);
            }
            return intValue;
        }

        internal static string Md5(string pwd) {
            string result = "";
            using (MD5 md5 = MD5.Create()) {
                Byte[] bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(pwd));
                StringBuilder stringBuilder = new StringBuilder();
                foreach (Byte key in bytes) {
                    stringBuilder.Append(key.ToString("X2"));
                }
                result = stringBuilder.ToString();
            }
            return result;
        }

        internal static void HtmlTree<T>(IList<T> treeItems, HtmlTree htmlTree) {
            if (treeItems == null || treeItems.Count <= 0) {
                throw new Exception("HtmlTree<T>()转换的数据对象DbModel为空。");
            }
            Type dbModelType = typeof(T);

            PropertyInfo field_id = null;           // Id Field
            PropertyInfo field_pid = null;          // Pid Field
            PropertyInfo field_text = null;         // Text Field

            Attribute[] dbModelAttribytes = Attribute.GetCustomAttributes(dbModelType);
            foreach (Attribute attribute in dbModelAttribytes) {
                if (attribute is HtmlTreeAttribute) {
                    HtmlTreeAttribute treeAttribute = (HtmlTreeAttribute)attribute;
                    field_id = dbModelType.GetProperty(treeAttribute.ID);
                    field_pid = dbModelType.GetProperty(treeAttribute.PID);
                    field_text = dbModelType.GetProperty(treeAttribute.TextField);
                    break;
                }
            }
            if (field_id == null && field_pid == null && field_text == null) {
                throw new Exception("HtmlTree<T>()未指定对象" + dbModelType.ToString() + "的自定义属性[HtmlTree(\"Id\",\"Pid\",\"Text Field\")]属性。");
            }

            int treeLevel = 1;
            BuildHtmlTree(treeItems, htmlTree, -1, ref treeLevel, field_id, field_pid, field_text);   
        }

        private static void BuildHtmlTree<T>(IList<T> treeNodes, HtmlTree htmlTree, object pid, ref int nodeLevel, params PropertyInfo[] dbModelAttributes) {
            IEnumerable<T> subNodes = treeNodes.Where(x => dbModelAttributes[1].GetValue(x).Equals(pid));
            foreach (var subNode in subNodes) {
                object value_id = dbModelAttributes[0].GetValue(subNode);
                object value_pid = dbModelAttributes[1].GetValue(subNode);
                object value_text = dbModelAttributes[2].GetValue(subNode);

                AFlag html_a = new AFlag();
                html_a.Text = value_text.ToString();

                SpanFlag html_span = new SpanFlag();
                html_span.ClassName = "caret";
                html_span.MenuLevel = nodeLevel;

                LiFlag html_li = new LiFlag();
                html_li.Span = html_span;
                html_li.A = html_a;
                BuildHtmlTree(treeNodes, html_li.UL, value_id, ref nodeLevel, dbModelAttributes);

                nodeLevel++;
                htmlTree.LiNodes.Add(html_li);
            }
        }

        internal static void Resort(List<Redmine.Net.Api.Types.User> AllUser) {
            Globals.AllProject.Clear();
            Globals.AllUser.Clear();
            foreach (var item in AllUser) {
                var field = item.CustomFields.Find(t => t.Name.Equals("用户类型"));
                if (field != null) {
                    if (field.Values != null && field.Values.Count > 0) {
                        string userType = field.Values[0].Info;
                        switch (userType) {
                            case "管理员":
                            case "公司帐号":
                                User newUser = new User();
                                newUser.Id = item.Id;
                                newUser.User_account = item.Login;
                                newUser.User_email = item.Email;
                                newUser.User_department = "";
                                newUser.User_name = item.LastName + item.FirstName;
                                newUser.User_password = "";
                                newUser.User_type = "公司帐号";

                                var getItem = item.CustomFields.Find(t => t.Name.Equals("部门"));
                                if (getItem != null) {
                                    if (getItem.Values != null && getItem.Values.Count > 0)
                                        foreach (var dept in getItem.Values) {
                                            if (string.IsNullOrEmpty(newUser.User_department)==false) {
                                                newUser.User_department += ",";
                                            }
                                            newUser.User_department += "<a href=\"#Link\">"+dept.Info+"</a>";
                                        }
                                }
                                if (item.CreatedOn != null) {
                                    newUser.Reg_date = item.CreatedOn.Value.ToString("yyyy-MM-dd HH:mm");
                                }
                                if (item.LastLoginOn != null) {
                                    newUser.Last_login = item.LastLoginOn.Value.ToString("yyyy-MM-dd HH:mm");
                                }
                                Globals.AllUser.Add(newUser);
                                break;
                            case "客户":
                                Project newProject = new Project();
                                newProject.ID = item.Id;
                                foreach (var customItem in item.CustomFields) {
                                    string tempValue = "";
                                    if (customItem.Values != null && customItem.Values.Count > 0) {
                                        tempValue = customItem.Values[0].Info;
                                    }

                                    switch (customItem.Name) {
                                        case "客户全称":
                                            if (tempValue.Length > 4) {
                                                newProject.Project_name = tempValue.Substring(0, 3) + "*******" + tempValue.Substring(tempValue.Length - 2);
                                            } else {
                                                newProject.Project_name = tempValue;
                                            }
                                            break;
                                        case "客户省份":
                                            newProject.Project_provnce = tempValue;
                                            break;
                                        case "客户项目阶段":
                                            newProject.Project_progress = tempValue;
                                            break;
                                        case "用户类型":
                                            newProject.Project_type = tempValue;
                                            break;
                                        case "区域":
                                            newProject.Project_area = tempValue;
                                            break;
                                        case "客户上线类型":
                                            newProject.Project_howto = tempValue;
                                            break;
                                    }
                                }
                                newProject.Project_employee = "N/A";
                                Globals.AllProject.Add(newProject);
                                break;
                        }
                    }
                }
            }
            Globals.AllUser.Sort(new UserDepartmentComparer());
        }
    }
}
