using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KOI_Conferences.Data
{
    public class KOI_ConferencesContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public KOI_ConferencesContext() : base("name=KOI_ConferencesContext")
        {
        }

        public System.Data.Entity.DbSet<KOI_Conferences.Models.Registration> Registrations { get; set; }

        public System.Data.Entity.DbSet<KOI_Conferences.Models.Seminar> Seminars { get; set; }

        public System.Data.Entity.DbSet<KOI_Conferences.Models.User> Users { get; set; }

        public System.Data.Entity.DbSet<KOI_Conferences.Models.Role> Roles { get; set; }

        public System.Data.Entity.DbSet<KOI_Conferences.Models.UserRoles> UserRoles { get; set; }
    }
}
