using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalIP.Models
{
    public class User
    {
        public int UserID { get; set; }
        [Display(Name = "Username")]
        public string UserName { get; set; }
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Display(Name = "City")]
        public string City { get; set; }
        [Display(Name = "Type Of User")]
        public string TypeOfUser { get; set; }
        [Display(Name = "End User Agreement")]
        public bool EndUserAgreement { get; set; }
    }
}
