using Redmine.Net.Api.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace com.redmine.gorilla.Models {
    public class QueryResult {
        public List<Issue> issues { get; set; } = new List<Issue>();
        public int total_count { get; set; }
        public int offset { get; set; }
        public int limit { get; set; }
    }
}
