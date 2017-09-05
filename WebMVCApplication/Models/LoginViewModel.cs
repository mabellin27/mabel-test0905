using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebMVCApplication.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Please enter user name")]
        [Display(Name = "User Name")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="Please enter password")]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}