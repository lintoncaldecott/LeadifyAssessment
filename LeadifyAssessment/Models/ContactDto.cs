using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeadifyAssessment.Models
{
    public class ContactDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CellPhone { get; set; }
        public string Email { get; set; }
    }
}