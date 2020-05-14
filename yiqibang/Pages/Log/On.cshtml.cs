using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using yiqibang.Entity;
using yiqibang.Repository;

namespace yiqibang.Pages.Log
{
    [BindProperties]
    public class OnModel : PageModel
    {
        //利用构造函数实例化仓库对象
        private UserRepository _userRepository;
        public OnModel()
        {
            _userRepository = new UserRepository();
        }
        public bool Success { get; set; }
        //接收前台传回来的Name和Password
        //Required 用来添加验证
        [Required(ErrorMessage = "*用户名不能为空")]
        public string Name { get; set; }
        [Required(ErrorMessage = "*密码不能为空")]
        public string Password { get; set; }
        public void OnGet()
        {

        }
        public void OnPost()
        {
            //检查验证
            if (!ModelState.IsValid)
            {
                return;
            }
            //根据前台传过来的Name从数据库获取到一个User对象
            User user = _userRepository.GetBy(Name);
            //首先判断user是否存在即是不是null
            //然后判断密码时候正确
            //最后生成cookie信息
            if (user == null)
            {
                ModelState.AddModelError("Name", "*用户名不存在");
                return;
            }
            else
            {
                if (user.Password != Password)
                {
                    ModelState.AddModelError("Password", "*用户名或密码不正确");
                    return;
                }
                else
                {
                    //生成cookie，保存用户信息
                    CookieOptions options = new CookieOptions
                    {
                        //显示指定过期时间
                        Expires = DateTime.Now.AddDays(14)
                    };
                    Response.Cookies.Append("UserId", user.Id.ToString(), options);
                    Response.Cookies.Append("Name", user.Name.ToString(), options);
                    Response.Cookies.Append("Password", user.Password.ToString(), options);
                    ViewData["UserName"] = user.Name;
                }

            }
        }
    }
}