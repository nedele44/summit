using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace yiqibang.Entity
{
    public class ArticleItemModel
    {
        //public DateTime PublishTime { get; set; }
        public int Id { get; set; }

        public UserModel Author { get; set; }

        public string Title { get; set; }
        //public string Abstract { get; set; }
       
    }
}
