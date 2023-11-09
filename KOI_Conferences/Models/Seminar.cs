using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace KOI_Conferences.Models
{
    public class Seminar
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Seminar Name is Required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "SeminarType is Required.")]
        public string SeminarType { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public float? RegistrationFee { get; set; }

        public virtual ICollection<Registration> Registration { get; set; }
    }
}