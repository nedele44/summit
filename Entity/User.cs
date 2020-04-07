using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{


    /// <summary>
    /// 用户类,添加sealed让User类无法被继承
    /// </summary>
public class User:IChat,ISendMessage
    //定义一个User类来完成注册和登录功能
    {
        //每一个User对象一定有Name和Password赋值
        //构造函数里实例化，name和password为两个字符串
        public User(string name, string password)
        {
            this._name = name;
            this._password = password;
        }
        /// <summary>
        /// 无参构造函数，一般隐藏
        /// </summary>
        public User()
        {
            //生成一个用户时，默认的初始帮帮币为100
            HelpCreit = 100;
        }
        /// <summary>
        /// 有参构造函数
        /// </summary>
        /// <param name="_name"></param>
        public User(string _name):this()
        {
            //Console.WriteLine("相濡以沫，不如相忘于江湖");
        }

        //实现接口，由于两个接口都有申明，Send方法，就采用显示实现
        void IChat.Send()
        {
            Console.WriteLine("骑马射箭");
        }

        void ISendMessage.Send()
        {
            Console.WriteLine("声东击西");
        }

        // 设计一个适用的机制，能确保用户（User）的昵称（Name）不能含有admin、17bang、管理员等敏感词。
        private string _name;//用户名
        //如果user.Name为“admin”，输入是修改为“系统管理员”
        public string Name
        {
            get { return _name; }
            set
            {
                if (value == "admin")
                {
                    Console.WriteLine("系统管理员");
                    return;
                }

                if (value.Contains("admin")||value.Contains("17bang")||value.Contains("管理员"))
                {
                    Console.WriteLine("请重新输入用户名");
                    return;
                }
                _name = value;
            }
        }

        private string _password;//密码
        //user.Password 在类的外部只能改不能读

        //第一种写法
        //internal void setPassword(string password)
        //{
        //    _Password = password;
        //}
        //第二种写法
        public string Password
        {
            set { _password = value; }
            get { return _password; }
        }
        //第三种写法
        //public string Password { set；}


        //用户的棒棒币
        public int HelpCreit ;



        //下面是审错题，瞎做的，浪费了不少时间

        private string rePassword;//验证密码
        //验证密码有必要设置为字段吗，我想是有必要的
        //因为每个人都需要输入吧，邀请人和邀请码也一样
        private string InvitedBy;//邀请人

        private string InviteNum;//邀请码



        //通过接收外传值来修改内部数据
        //下面的语句似乎可以整合到注册函数中
        public void SetName(string name)
        {
            this.Name = name;
        }
        public void SetPassword(string password)
        {
            this.Password = password;
        }
        public void SetRepassword(string repassword)
        {
            this.rePassword = repassword;
        }

        public void SetInviteby(string inviteby)
        {
            this.InvitedBy = inviteby;
        }

        public void SetInvitenum(string invitenum)
        {
            this.InviteNum = invitenum;
        }




        //邀请人和邀请码是一一对应的，首先应该进行判断才能确定是否可以注册
        //邀请人和邀请码应该和登录的逻辑一样，要一一配对才行



        //先梳理一下注册页面的逻辑
        //首先邀请人要写对，不然显示“没有找到这个邀请人”，不能注册
        //然后是邀请码要正确，不然显示“邀请码错误”，不能注册

        //然后是用户名，密码和验证密码，密码和验证密码要一致
        //再然后是验证码，验证码要准确，不然也不能注册
        //最后才能提交，注册成功





        /// <summary>
        /// 首先判定邀请人和邀请码是否正确
        /// </summary>
        /// <param name="person">注册时输入的邀请人</param>
        /// <param name="code">注册时输入的邀请码</param>
        /// <returns>如果是true说明可以注册，反正不行</returns>
        public bool InviteSuccess(string person, string code)
        {


            //这里暂时设定只有一个邀请人和邀请码
            if (person != InvitedBy)
            {
                Console.WriteLine("邀请人不存在");
                return false;
            }
            else
            {
                if (code != InviteNum)
                {
                    Console.WriteLine("邀请码不正确");
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        /// <summary>
        /// 这里不考虑重名的问题把，依然不考虑与数据库有关的问题
        /// 也不考虑密码的格式等
        /// </summary>
        /// <param name="name">用户名</param>
        /// <param name="password">密码</param>
        /// <param name="verificationcode">验证码</param>
        public void Register(string name, string password, string repassword, string verificationcode)
        {
            if (verificationcode != "5656")
            //验证的自动生成这里暂时不考虑
            {
                Console.WriteLine("验证码错误，注册失败");
            }
            else
            {
                if (password != repassword)
                //两次输入的密码要相同
                {
                    Console.WriteLine("密码设置有误，注册失败");
                }
                else
                {
                    this.Name = name;
                    this.Password = password;
                    Console.WriteLine("注册成功");
                }
                //我想后面应该还有将name和password传送到后台数据库的操作等等
            }
        }


        //User类中添加一个Tokens属性，类型为TokenManager
        private TokenManager tokens { get; set; }

        //登录页面的逻辑是先验证验证码，再验证用户名，再验证密码
        public void LogOn(string username, string password, string verificode)
        {
            if (verificode != "5656")
            {
                Console.WriteLine("验证码输入错误");
            }
            else
            {
                if (username != Name)
                {
                    Console.WriteLine("用户名不存在");
                }
                else
                {
                    if (password != _password)
                    {
                        Console.WriteLine("密码错误");
                    }
                    else
                    {
                        Console.WriteLine("登录成功");
                    }
                }
            }
        }
    }
}
