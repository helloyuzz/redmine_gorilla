using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace com.redmine.gorilla.Models {
    [Table("sm_user")]
    public class User {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display(Name = "登录帐号")]
        public string User_account { get; set; }
        [Display(Name ="姓名")]
        public string User_name { get; set; }
        [Display(Name = "类型")]
        public string User_type { get; set; }
        [Display(Name = "最近登录")]
        public string Last_login { get; set; }
        [Display(Name = "部门")]
        public string User_department { get; set; }
        [Display(Name = "Email")]
        public string User_email { get; set; }
        [Display(Name = "注册日期")]
        public string Reg_date { get; set; }
        public object Theme_url { get; set; }
        public string User_password { get; set; }       

    }
}
