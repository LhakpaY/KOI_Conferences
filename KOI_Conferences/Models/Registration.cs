using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace KOI_Conferences.Models
{
    public class Registration
    {
        public int RegistrationId { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public float? RegistrationFee { get; set; }

        [Required(ErrorMessage = "SeminarType is Required.")]
        public string SeminarType { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

    }
}