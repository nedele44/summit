using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace yiqibang.Entity
{
    public class User
    {
        public int Id { get; set; }

        [Display(Name = "用户名")]
        public string Name { get; set; }
        [Display(Name = "密码")]
        [DataType(DataType.Password)]
        //[MinLength(4, ErrorMessage = "*长度不能小于4")]
        public string Password { get; set; }

        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
