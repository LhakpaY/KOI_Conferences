﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace KOI_Conferences.Models
{
    public class Role
    {
        [Required]
        public int Id { get; set; }

        [Required]

        public string RoleName { get; set; }

        public virtual ICollection<UserRoles> UserRoles { get; set; }
    }
}