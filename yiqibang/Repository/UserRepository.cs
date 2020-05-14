using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using yiqibang.Entity;

namespace yiqibang.Repository
{
    public class UserRepository
    {
        public void Save(User user)
        { 
            //把用户名和密码存到数据库中
        }

        public User GetBy(string name)
        {
            if (name == "yezi")
            {
                return new User
                {
                    Id = 1,
                    Name = "yezi",
                    Password = "1234"
                };
            }
            else if (name == "ye")
            {
                return new User {
                    Id = 2,
                    Name = "ye",
                    Password = "1234"
                };
            }
            else
            {
                return null;
            }
        }


        //通过用户的名称找到用户
        //用户名不存在
        //用户名或密码错误
        //完全匹配
    }
}
