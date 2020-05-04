using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace yiqibang.Entity
{
    public enum KindOfBook
    {
        //display之后怎么传送到前端呢
        [Display(Name ="被人捡走")]
        picked,
        [Display(Name = "被点赞")]
        liked,
        [Display(Name = "邀请")]
        invited,
        [Display(Name = "设为精选")]
        begood
    }
}
