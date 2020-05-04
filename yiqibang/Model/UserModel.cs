using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace yiqibang.Entity
{
    public class UserModel
    {
        public int Id { get; set; }
        public string InviteCode { get; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string QQ { get; set; }

        public string WeChat { get; set; }

        public string Telphone { get; set; }

    }
}
