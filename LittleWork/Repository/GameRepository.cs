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
                Title = "荒野之息",
                Abstract = "游戏故事发生在海拉鲁王国灭亡的100年后，" +
                    "曾经一场大灾难袭击了海拉鲁王国使之灭亡，主角林克在地下遗迹苏醒，" +
                    "追寻着不可思议的声音，开始了冒险之旅",
                Author = new UserModel
                {
                    Id = 1,
                    Name = "三水"
                },
                kind=GameKind.RPG
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
                    kind=GameKind.RPG
                }
            };
        }

        public IList<GameItemModel> get()
        {
            return _games;
        }

        public void Add(GameItemModel model)
        {
            _games.Add(model);
        }
    }
}
