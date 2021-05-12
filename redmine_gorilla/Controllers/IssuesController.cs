using com.redmine.gorilla.Models;
using Microsoft.AspNetCore.Mvc;
using Redmine.Net.Api;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;

namespace com.redmine.gorilla.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class IssuesController : Controller {
        public ActionResult<QueryResult> Get(string issues_type, int from_id) {
            QueryResult queryResult = new QueryResult();

            NameValueCollection nameValueCollection = null;
            RedmineManager manager = new RedmineManager(Globals.RedmineURL, Globals.APIKey);
            switch (issues_type) {
                case "author_id":   // 按作者
                    nameValueCollection = new NameValueCollection() { { RedmineKeys.INCLUDE, RedmineKeys.RELATIONS }, { "author_id", from_id.ToString() } };
                    break;
                case "cf_22":   // 按医院
                    nameValueCollection = new NameValueCollection() { { RedmineKeys.INCLUDE, RedmineKeys.RELATIONS }, { "cf_22", from_id.ToString() } };
                    break;
                case "assigned_to_id":  // 按指派给
                    nameValueCollection = new NameValueCollection() { { RedmineKeys.INCLUDE, RedmineKeys.RELATIONS }, { "assigned_to_id", from_id.ToString() } };
                    break;   
            }
            if (nameValueCollection != null) {
                var issues = manager.GetObjects<Redmine.Net.Api.Types.Issue>(nameValueCollection);
                queryResult.total_count = issues.Count;
                foreach (Redmine.Net.Api.Types.Issue issue in issues) {
                    issue.Description = "";
                    queryResult.issues.Add(issue);
                }
            }
            return queryResult;
        }
    }
}
