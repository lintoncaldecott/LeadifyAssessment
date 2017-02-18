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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CellPhone { get; set; }
        public string Email { get; set; }
        public string NickName { get; set; }
    }
}