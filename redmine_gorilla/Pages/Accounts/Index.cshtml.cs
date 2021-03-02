using System.Collections.Generic;
using System.Threading.Tasks;
using com.redmine.gorilla.Models;

namespace com.redmine.gorilla.Pages.Accounts {
    public class IndexModel : PublicPage {
   
        public IList<Account> Account { get; set; }

        public async Task OnGetAsync() {
            _CrumbList.Add(new CrumbItem("日志审计"));
            _CrumbList.Add(new CrumbItem("升级包提取"));
            //Account = await _context.Account.ToListAsync();
        }
    }
}