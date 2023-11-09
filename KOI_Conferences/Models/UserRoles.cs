using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KOI_Conferences.Models
{
    public class UserRoles
    {
        public int Id { get; set; }

        public int UserID { get; set; }

        public int RoleID { get; set; }

        public virtual User User { get; set; }

        public virtual Role Role { get; set; }

    }
}