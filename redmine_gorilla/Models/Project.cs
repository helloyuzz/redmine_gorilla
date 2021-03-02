using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace com.redmine.gorilla.Models {
    [Table("sm_project")]
    public class Project {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Display(Name ="项目全称"),Required]
        public string Project_name { get; set; }
        //区域
        [Display(Name = "业务区域"), Required]
        public string Project_area { get; set; }
        //客户省份
        [Display(Name = "客户省份"), Required]
        public string Project_provnce { get; set; }
        //项目阶段
        [Display(Name = "项目阶段"), Required]
        public string Project_progress { get; set; }
        //用户类型
        [Display(Name = "用户类型"), Required]
        public string Project_type { get; set; }
        //客户上线类型
        [Display(Name = "客户上线类型"), Required]
        public string Project_howto { get; set; }
        [Display(Name = "实施负责人员"), Required]
        public string Project_employee { get; set; }
    }
}
