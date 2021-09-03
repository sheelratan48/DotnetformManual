using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Dotnetman.Models
{
    public class NewStuClass
    {
        [Key]
        public int Stuid { get; set; }

        [Required(ErrorMessage ="Enter student name")]
        [Display(Name ="Student Name")]
        public string Stuname { get; set; }

        [Required(ErrorMessage = "Enter student Email")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]

        public string Email { get; set; }

        [Required(ErrorMessage = "Enter student Roll")]
        [Display(Name = "Roll")]
        public int Roll { get; set; }

        [Required(ErrorMessage ="Enter the Gender")]
        [Display(Name ="Gender")]
        public String Gender { get; set; }

        [Required(ErrorMessage = "Enter the Qualification")]
        [Display(Name = "Qualification")]
        public String Qualification { get; set; }

        [Required(ErrorMessage = "Enter the Date of Birth")]
        [Display(Name = "DateOfBirth")]
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }
    }
}
