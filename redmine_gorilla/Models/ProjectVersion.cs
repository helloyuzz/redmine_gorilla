using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace com.redmine.gorilla.Models {
    public class ProjectVersion {
        public int Id { get; set; }
        [Display(Name = "版本号")]
        public string Version { get; set; }
        [Display(Name = "开始研发")]
        public string StartPrograming { get; set; }
        [Display(Name = "计划完成")]
        public string PlanComplete { get; set; }
        [Display(Name = "实际完成")]
        public string RealComplete { get; set; }
        [Display(Name = "状态")]
        public string Status { get; set; }
        [Display(Name = "需求来源")]
        public string Source { get; set; }
        [Display(Name = "功能需求清单")]
        public string RequirementURL { get; set; }
        [Display(Name = "产品原型")]
        public string PrototypeURL { get; set; }
        [Display(Name = "参与评审人员")]
        public string EmployeeList { get; set; }
        [Display(Name = "发布日期")]
        public string PublishBy { get; set; }
        [Display(Name = "Release地址")]
        public string ReleasePath { get; set; }
        public string Name1 { get; set; }
        [Display(Name ="版本描述")]
        public string Desc { get; set; }
    }
}
