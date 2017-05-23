using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models.ContactViewModels
{
    public class ContactViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }


        [Required]
        [Display(Name = "Message")]
        public string Message{get;set;}
    }
}