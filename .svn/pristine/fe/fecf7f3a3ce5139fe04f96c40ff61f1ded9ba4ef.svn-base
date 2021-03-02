
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace com.redmine.gorilla.AppGorilla.Utils {
    public class UserDepartmentComparer : IComparer<com.redmine.gorilla.Models.User> {
        public int Compare([AllowNull] com.redmine.gorilla.Models.User x, [AllowNull] com.redmine.gorilla.Models.User y) {
            int xValue = x.User_department.CompareTo(y.User_department);
            if (xValue < 0) {
                return 1;
            } else if (xValue == 0) {
                return 0;
            }
            return -1;
        }
    }
}
