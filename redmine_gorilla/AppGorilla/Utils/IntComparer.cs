using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace com.redmine.gorilla.AppGorilla.Utils {
    public class IntComparer : IComparer<Redmine.Net.Api.Types.Version> {
        public int Compare([AllowNull] Redmine.Net.Api.Types.Version x, [AllowNull] Redmine.Net.Api.Types.Version y) {
            if (x.Id > y.Id) {
                return -1;
            } else if (x.Id == y.Id) {
                return 0;
            }
            return 1;
        }
    }
}
