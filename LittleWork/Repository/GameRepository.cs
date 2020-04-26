using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LittleWork.Entity;

namespace LittleWork.Repository
{
    public class GameRepository
    {
        private static IList<GameItemModel> _games;
        static GameRepository()
        {
            _games = new List<GameItemModel>
            {
                new GameItemModel
                {

                PublishTime = DateTime.Now,
                Id = 1,
                Title = "塞尔达传说之荒野之息",
                Abstract = "游戏故事发生在海拉鲁王国灭亡的100年后，" +
                    "曾经一场大灾难袭击了海拉鲁王国使之灭亡，主角林克在地下遗迹苏醒，" +
                    "追寻着不可思议的声音，开始了冒险之旅",
                Author = new UserModel
                {
                    Id = 1,
                    Name = "三水"
                },
                Kind=GameKind.RPG
                 },
                new GameItemModel
                {

                    PublishTime = DateTime.Now.AddDays(1),
                    Id = 2,
                    Title = "巫师3",
                    Abstract = "该作承接《巫师2：国王刺客》的剧情，" +
                    "那些想要利用杰洛特的人已经不在了。杰洛特寻求改变自己的生活，" +
                    "着手于新的个人使命，而世界的秩序也在悄然改变。",
                    Author = new UserModel
                    {
                        Id = 2,
                        Name = "三金"
                    },
                    Kind=GameKind.RPG
                },
                new GameItemModel
                {
                    PublishTime = DateTime.Now.AddDays(2),
                    Id = 3,
                    Title = "魔兽世界",
                    Abstract = "《魔兽世界》（World of Warcraft）是由著名游戏公司暴雪娱乐所制作的第一款网络游戏，" +
                    "属于大型多人在线角色扮演游戏。游戏以该公司出品的即时战略游戏《魔兽争霸》的剧情为历史背景，" +
                    "依托魔兽争霸的历史事件和英雄人物，魔兽世界有着完整的历史背景时间线。" +
                    "玩家在魔兽世界中冒险、完成任务、新的历险、探索未知的世界、征服怪物等。",
                    Author = new UserModel
                    {
                        Id = 3,
                        Name = "三木"
                    },
                    Kind=GameKind.MMORPG
                },
                new GameItemModel
                {
                    PublishTime = DateTime.Now.AddDays(2),
                    Id = 4,
                    Title = "英雄联盟",
                    Abstract = "《英雄联盟》（简称LOL）是由美国拳头游戏（Riot Games）开发、" +
                    "中国大陆地区腾讯游戏代理运营的英雄对战MOBA竞技网游。",
                    Author = new UserModel
                    {
                        Id = 3,
                        Name = "三木"
                    },
                    Kind=GameKind.MOBA
                },
                new GameItemModel
                {
                    PublishTime = DateTime.Now.AddDays(2),
                    Id = 5,
                    Title = "上古卷轴5",
                    Abstract = "《游戏的背景时间设定在《上古卷轴4：湮没》的200年之后，地点为人类帝国的天际省。" +
                    "玩家将扮演传说中的龙裔，踏上对抗世界吞噬者巨龙奥杜因的征途。" +
                    "另外，还有天际内战、魔神器、地下遗迹、组织势力等各类支线和隐藏任务，具有庞大的世界观和高自由度。",
                    Author = new UserModel
                    {
                        Id = 3,
                        Name = "三木"
                    },
                    Kind=GameKind.RPG
                },
                new GameItemModel
                {
                    PublishTime = DateTime.Now.AddDays(2),
                    Id = 6,
                    Title = "最终幻想7重制版",
                    Abstract = "《最终幻想7重制版》是由Square Enix基于经典的《最终幻想7》所进行的的完全重制版，" +
                    "但并非对原作的 1 比 1 复刻。除了次世代主机带来的画面革新外，游戏战斗风格也更加偏向于“动作”，" +
                    "克劳德的突刺颇似《最终幻想15》里诺克提斯的长枪突刺，整个游戏的游戏系统可以理解为半即时遭遇战斗模式，" +
                    "其最大的特色是通过积攒ATB槽进行与回合制相仿的技能攻击。由于没有了战斗进场与结算镜头，" +
                    "因此使整个游戏的推动变得尤为顺滑，希望可以给玩家带来更爽快的砍杀体验。",
                    Author = new UserModel
                    {
                        Id = 3,
                        Name = "三木"
                    },
                    Kind=GameKind.RPG
                },
                new GameItemModel
                {
                    PublishTime = DateTime.Now.AddDays(2),
                    Id = 7,
                    Title = "生化危机3：重制版",
                    Abstract = "《生化危机3：重制版》采用RE Engine引擎开发，" +
                    "游戏根据《生化危机3》进行制作，在游戏中玩家将会扮演初代中的女主角吉尔，" +
                    "从危机重重的浣熊市中杀出一条血路逃出生天。",
                    Author = new UserModel
                    {
                        Id = 3,
                        Name = "三木"
                    },
                    Kind=GameKind.RPG
                },
                new GameItemModel
                {
                    PublishTime = DateTime.Now.AddDays(2),
                    Id = 8,
                    Title = "穿越火线",
                    Abstract = "《穿越火线》游戏是由韩国Smile Gate开发，由深圳市腾讯计算机系统有限公司代理运营的一款第一人称射击游戏。" +
                    "游戏讲述了全球两大佣兵集团Global Risk和Black List间的对决。游戏中有团队模式、战队赛、爆破模式、幽灵模式等多种模式。" +
                    "引进了“缺人补充”形式的即时加入系统。",
                    Author = new UserModel
                    {
                        Id = 1,
                        Name = "三水"
                    },
                    Kind=GameKind.STG
                },
                new GameItemModel
                {
                    PublishTime = DateTime.Now.AddDays(2),
                    Id = 9,
                    Title = "拳皇",
                    Abstract = "《拳皇》是1994年日本SNK公司旗下在MVS游戏机板上发售的一款著名对战型格斗街机游戏，简称KOF，" +
                    "也是在剧情中举行的世界规模的格斗大赛的名称。" +
                    "最初为该公司旗下另外两部作品《饿狼传说》系列和《龙虎之拳2》中以南镇为舞台举办的格斗大赛。",
                    Author = new UserModel
                    {
                        Id = 1,
                        Name = "三水"
                    },
                    Kind=GameKind.FTG
                },
                new GameItemModel
                {
                    PublishTime = DateTime.Now.AddDays(2),
                    Id = 10,
                    Title = "守望先锋",
                    Abstract = "《守望先锋》（Overwatch，简称OW） 是由暴雪娱乐公司开发的一款第一人称射击游戏，" +
                    "于2016年5月24日全球上市，中国大陆地区由网易公司代理。",
                    Author = new UserModel
                    {
                        Id = 1,
                        Name = "三水"
                    },
                    Kind=GameKind.STG
                },
                new GameItemModel
                {
                    PublishTime = DateTime.Now.AddDays(2),
                    Id = 11,
                    Title = "仙剑奇侠传",
                    Abstract = "仙剑故事以中国古代的仙妖神鬼传说为背景、以武侠和仙侠为题材，" +
                    "迄今已发行八款单机角色扮演游戏、一款衍生经营模拟游戏、两款网络游戏、一款网络社交游戏和一款衍生手机游戏" +
                    "。2017年5月23日，系列单机游戏第九部作品《仙剑奇侠传七》正式立项",
                    Author = new UserModel
                    {
                        Id = 1,
                        Name = "三水"
                    },
                    Kind=GameKind.RPG
                },
                new GameItemModel
                {
                    PublishTime = DateTime.Now.AddDays(2),
                    Id = 12,
                    Title = "刺客信条",
                    Abstract = "该游戏系列是以超高的自由度和精美的画面作为最大卖点的动作类游戏。" +
                    "玩家将在每部游戏中控制一名刺客，通过在任务中巧妙穿插重要的历史人物及历史事件带给玩家深沉的代入感。",
                    Author = new UserModel
                    {
                        Id = 1,
                        Name = "三水"
                    },
                    Kind=GameKind.ACT
                },
            };
        }
        public IList<GameItemModel> Getinclude(GameKind kind)
        {

            return _games.Where(p => p.Kind == kind).ToList();
        }
        public IList<GameItemModel> Get()
        {
            return _games;
        }

        public void Add(GameItemModel model)
        {
            _games.Add(model);
        }

        


    }
}
