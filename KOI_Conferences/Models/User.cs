using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace KOI_Conferences.Models
{
    public class User
    {
        [Required]
        [Display(Name = "User ID")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "User name is required.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }

        public string FullName { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email is required.")]
        public string Email { get; set; }

        [Phone]
        [Required(ErrorMessage = "Phone Number is required.")]

        public string PhoneNumber { get; set; }

        public virtual ICollection<UserRoles> UserRoles { get; set; }

        public virtual ICollection<Registration> Registration { get; set; }


    }
}