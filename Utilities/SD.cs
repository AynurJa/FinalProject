using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagicHome.Utilities
{
    public static class SD
    {
        public enum Roles
        {
         Admin,
         Manager,
         Member
        }

        public const string AdminRole = "Admin";
        public const string MemberRole = "Member";
        public const string ManagerRole = "Manager";

    }
}
