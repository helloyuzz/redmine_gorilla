using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace com.redmine.gorilla.AppGorilla.Utils {
    public class VarcharComparer : IComparer<Redmine.Net.Api.Types.Version> {
        public int Compare([AllowNull] Redmine.Net.Api.Types.Version x, [AllowNull] Redmine.Net.Api.Types.Version y) {
            int xValue = x.Name.CompareTo(y.Name);
            if (xValue < 0) {
                return 1;
            } else if (xValue == 0) {
                return 0;
            }
            return -1;
        }
    }
}
