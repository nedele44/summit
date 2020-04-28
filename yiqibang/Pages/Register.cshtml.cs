using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using yiqibang.Entity;

namespace yiqibang
{
    public class RegisterModel : PageModel
    {
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public UserModel User { get; set; }

        [DataType(DataType.Password)]
        public string ComfirmPassword { get; set; }
        public void OnGet()
        {

        }
    }
}