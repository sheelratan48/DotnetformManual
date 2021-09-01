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

        [Required(ErrorMessage = "Enter student Age")]
        [Display(Name = "Age")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Enter student Roll")]
        [Display(Name = "Roll")]
        public int Roll { get; set; }
    }
}
