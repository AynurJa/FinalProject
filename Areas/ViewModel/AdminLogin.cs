using MagicHome.Areas.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MagicHome.Areas.ViewModel
{
    public class AdminLogin
    {

        [Required(ErrorMessage = "Email daxil edin")]
       
        [DataType(DataType.EmailAddress)]
        [StringLength(50, ErrorMessage = "Enter Correct Email please")]
        [MinLength(5, ErrorMessage = "Enter Correct Email please")]
        public string Email { get; set; }

        [Display(Name = "Parol")]
        [MinLength(8, ErrorMessage = "Password is short!")]
        [StringLength(300)]
        [Required(ErrorMessage = "Write Password !")]
        public string Password { get; set; }
    }
}

