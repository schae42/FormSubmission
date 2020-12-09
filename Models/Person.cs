using System.ComponentModel.DataAnnotations;


namespace FormSubmission.Models
{
    public class Person
    {
        [Display(Name="First Name")]
        [MinLength(4, ErrorMessage="First Name must be atleast 4 characters")]
        [Required]
        public string first_name{ get; set;}
        [Display(Name="Last Name")]
        [MinLength(4, ErrorMessage="Last Name must be atleast 4 characters")]
        [Required]
        public string last_name{ get; set;}
        [Display(Name="Age")]
        [Range(0, 999, ErrorMessage = "Please enter valid age")]
        [Required]
        public string age{ get; set;}
        [Display(Name="Email")]
        [EmailAddress]
        [Required]
        public string email{ get; set;}
        [Display(Name="Password")]
        [MinLength(8, ErrorMessage="Password must be atleast 8 characters")]
        [Required]
        public string password{ get; set;}
    }
}