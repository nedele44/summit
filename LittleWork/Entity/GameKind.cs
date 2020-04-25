using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LittleWork.Entity
{
    public enum GameKind
    {
        [Description("角色扮演")]
        RPG,
        [Description("动作")]
        ACT,
        [Description("多人竞技")]
        MOBA,
        [Description("射击")]
        STG,
        [Description("格斗")]
        FTG


    }

}
