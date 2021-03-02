﻿using com.redmine.gorilla.Models;
using System;
using System.Collections.Generic;

namespace com.redmine.gorilla {
    public class Globals {
        static string _MySqlConnectionString = null;
        static string _MsSQLConnectionString = null;

        public static string MySqlConnectionString {
            get {
                // allowPublicKeyRetrieval=true;SslMode=None;
                if (string.IsNullOrEmpty(_MySqlConnectionString)) {
                    _MySqlConnectionString = AppConfigurtaionServices.Configuration["ConnectionString:MySql"];
                    if (string.IsNullOrEmpty(_MySqlConnectionString)) {
                        throw new ExceptionConnectionStringIsNull(SystemMessage.ConnectionStringIsNull);
                    }
                }
                return _MySqlConnectionString;
            }
        }
        public static string MsSqlConnectionString {
            get {
                if (string.IsNullOrEmpty(_MsSQLConnectionString)) {
                    _MsSQLConnectionString = AppConfigurtaionServices.Configuration["ConnectionString:MsSql"];
                    if (string.IsNullOrEmpty(_MsSQLConnectionString)) {
                        throw new ExceptionConnectionStringIsNull(SystemMessage.ConnectionStringIsNull);
                    }
                }
                return _MsSQLConnectionString;
            }
        }

        public const string CopyRight = "蓝鹰追溯";


        private static List<NaviMenuItem> _list = null;
        public static List<NaviMenuItem> NaviMenus {
            get {
                if (_list == null || _list.Count <=0) {
                    _list = new List<NaviMenuItem>();
                    NaviMenuItem naviMenu_Index = new NaviMenuItem() {
                        Menu_id = "navMenu_Index",
                        MenuText = "Welcome",
                        AspPage = "/Index",
                        Menu_icons = "fa-home",
                    };
                    NaviMenuItem naviMenu_Project = new NaviMenuItem() {
                        Menu_id = "naviMenu_Project",
                        MenuText = "项目列表",
                        AspPage = "/Projects/Index",
                        Menu_icons = "fa-city",
                    };
                    NaviMenuItem naviMenu_Subscribe = new NaviMenuItem() {
                        Menu_id = "naviMenu_Subscribe",
                        MenuText = "推送订阅",
                        AspPage = "/Subscribe",
                        Menu_icons = "fa-cloud-download-alt",
                    };
                    //NaviMenuItem naviMenu_System = new NaviMenuItem() {
                    //    Menu_id = "naviMenu_System",
                    //    MenuText = "系统管理",
                    //    AspPage = "/Provinces/Index",
                    //    Menu_icons = "glyphicon glyphicon glyphicon-wrench menuIcon",
                    //};
                    //NaviMenuItem naviMenu_ChangePwd = new NaviMenuItem() {
                    //    Menu_id = "naviMenu_ChangePwd",
                    //    MenuText = "修改密码",
                    //    AspPage = "/ChangePwd",
                    //    Menu_icons = "glyphicon glyphicon glyphicon-save menuIcon",
                    //};
                    //NaviMenuItem naviMenu_AuditLog = new NaviMenuItem() {
                    //    Menu_id = "naviMenu_AuditLog",
                    //    MenuText = "日志审计",
                    //    AspPage = "/Index",
                    //    Menu_icons = "glyphicon glyphicon glyphicon-th menuIcon",
                    //};
                    //NaviMenuItem naviMenu_Privacy = new NaviMenuItem() {
                    //    Menu_id = "naviMenu_Privacy",
                    //    MenuText = "Privacy",
                    //    AspPage = "/Privacy",
                    //    Menu_icons = "glyphicon glyphicon glyphicon-th menuIcon",
                    //};
                    //NaviMenuItem naviMenu_Logout = new NaviMenuItem() {
                    //    Menu_id = "naviMenu_Logout",
                    //    MenuText = "注销",
                    //    AspPage = "/Logout",
                    //    Menu_icons = "glyphicon glyphicon glyphicon-th menuIcon",
                    //};
                    _list.Add(naviMenu_Index);
                    _list.Add(naviMenu_Project);
                    _list.Add(naviMenu_Subscribe);
                    //_list.Add(naviMenu_AuditLog);
                    //_list.Add(naviMenu_System);
                    //_list.Add(naviMenu_Privacy);
                    //_list.Add(naviMenu_ChangePwd);
                    //_list.Add(naviMenu_Logout);
                }
                return _list;
            }
        }


        static string _RedmineURL = "";
        static string _GorillaURL = "";
        static string _VersionURL = "";
        static string _UserURL = "";
        static string _NewIssusURL = "";
        public static string RedmineURL {
            get {
                if (string.IsNullOrEmpty(_RedmineURL)) {
                    _RedmineURL = AppConfigurtaionServices.Configuration["URLDefintion:RedmineURL"];
                }
                return _RedmineURL;
            }
        }        
        public static string GorillaURL {
            get {
                if (string.IsNullOrEmpty(_GorillaURL)) {
                    _GorillaURL = AppConfigurtaionServices.Configuration["URLDefintion:GorillaURL"];
                }
                return _GorillaURL;
            }
        }
        public static string NewIssusURL {
            get {
                if (string.IsNullOrEmpty(_NewIssusURL)) {
                    _NewIssusURL = AppConfigurtaionServices.Configuration["URLDefintion:NewIssusURL"];
                }
                return _NewIssusURL;
            }
        }
        public static string VersionURL {
            get {
                if (string.IsNullOrEmpty(_VersionURL)) {
                    _VersionURL = AppConfigurtaionServices.Configuration["URLDefintion:VersionURL"];
                }
                return _VersionURL;
            }
        }
        public static string UserURL {
            get {
                if (string.IsNullOrEmpty(_UserURL)) {
                    _UserURL = AppConfigurtaionServices.Configuration["URLDefintion:UserURL"];
                }
                return _UserURL;
            }
        }
        public static List<User> AllUser { get; set; } = new List<User>();
        public static List<Project> AllProject { get; set; } = new List<Project>();
        public static List<UserSkin> SkinValues { get; set; } = new List<UserSkin>();
    }
}
