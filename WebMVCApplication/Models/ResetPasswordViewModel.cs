using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebMVCApplication.Models
{
    public class ResetPasswordViewModel
    {
        [Required]
        [Display(Name ="Your ID")]
        public string UserName { get; set; }
        [Required]
        [StringLength(12, ErrorMessage = "Please type 6 ~ 12 digits as your password.", MinimumLength =6)]
        [Display(Name ="New Password")]
        public string NewPwd { get; set; }
        [Required]
        [Compare("NewPwd", ErrorMessage ="Password is not the same as previous one")]
        [Display(Name ="Confirm Password")]
        public string RetypePwd { get; set; }
    }
}