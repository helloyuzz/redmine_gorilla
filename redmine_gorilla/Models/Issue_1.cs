using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace com.redmine.gorilla.Models {
    public class Issue_1 {
        public string id { get; set; }
        public IDVItem project { get; set; }
        public IDVItem tracker { get; set; }
        public IDVItem priority { get; set; }
        public IDVItem author { get; set; }
        public IDVItem status { get; set; }
        public IDVItem assigned_to { get; set; }
        public IDVItem fixed_version { get; set; }
        public List<IDVItem> custom_fields { get; set; }
        public string subject { get; set; }
        public string description { get; set; }
        public string start_date { get; set; }
        public string due_date { get; set; }
        public string done_ratio { get; set; }
        public string is_private { get; set; }
        public string estimated_hours { get; set; }
        public string created_on { get; set; }
        public string updated_on { get; set; }
        public string closed_on { get; set; }
    }
}
