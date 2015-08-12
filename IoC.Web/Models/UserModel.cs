using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IoC.Web.Models
{
    public class UserModel
    {

        public Int64 ID { get; set; }

        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }


        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }

        [Display(Name="Address")]
        [Required]
        public string Address { get; set; }

        [Display(Name = "User Name")]
        [Required]
        public string UserName { get; set; }

        [Display(Name="Email")]
        [Required]
        public string Email { get; set; }

        [Display(Name="Password")]
        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }


        [Display(Name = "Added Date")]
        public DateTime AddedDate { get; set; }



    }
}