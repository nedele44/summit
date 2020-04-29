using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using yiqibang.Entity;

namespace yiqibang
{
    public class ForgetModel : PageModel
 
    {
        public UserModel User { get; set; }
        
        public void OnGet()
        {

        }
    }
}