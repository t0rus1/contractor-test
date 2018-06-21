using System.ComponentModel.DataAnnotations;

namespace LeonVanDyk.WMTestApp.Models
{
    public class Student
    {
        public int StudentID { get; set; }

        [Required]
        [RegularExpression(@"Mrs|Mr|Miss|Dr", ErrorMessage = "Only Mr, Miss, Mrs or Dr allowed")]
        public string Salutation { get; set; }

        [StringLength(50, ErrorMessage = "Required, not longer than 50 characters.")]
        [Display(Description ="First Name")]
        public string FirstName { get; set; }

        [StringLength(50, ErrorMessage = "Required, not longer than 50 characters.")]
        public string Surname { get; set; }

        [Range(0, 99, ErrorMessage ="Age must be between 0 and 99")]
        public int Age { get; set; }

        [RegularExpression("^Male|Female$", ErrorMessage ="Only 'Male' or 'Female' allowed")]
        public string Gender { get; set; }

        public string FullName
        {
            get { return $"{Salutation} {FirstName} {Surname}"; }
        }


    }
}