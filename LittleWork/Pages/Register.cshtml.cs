using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LittleWork.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LittleWork
{
    public class RegisterModel : PageModel
    {
        public UserModel User { get; set; }
        public void OnGet()
        {

        }
    }
}