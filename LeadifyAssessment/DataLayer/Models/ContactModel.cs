using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LeadifyAssessment.DataLayer.Models
{
    [Table("Contact")]
    public class ContactModel
    {
        [Key]
        public int ContactId { get; set; }

        [Required(ErrorMessage = "A first name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "A last name is required")]
        public string LastName { get; set; }

        [Required]
        [RegularExpression(@"[0](\d{9})|([0](\d{2})( |-)((\d{3}))( |-)(\d{4}))|[0](\d{2})( |-)(\d{7})", ErrorMessage = "please provide a cellphone number in the format 0791111111")]
        public int CellPhone { get; set; }

        [Required()]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{1,3}|[0-9]{1,6})(\]?)$", ErrorMessage = "Please enter a valid e-mail")]
        public string Email { get; set; }

    }
}