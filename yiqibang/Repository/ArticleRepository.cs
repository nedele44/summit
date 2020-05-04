using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using yiqibang.Entity;

namespace yiqibang.Repository
{
    public class ArticleRepository
    {
        //申明一个泛型接口
        private static IList<ArticleItemModel> _articles;

        static ArticleRepository()
        {
            _articles = new List<ArticleItemModel>
            {
                new ArticleItemModel
                {
                    Id=1,
                    Author=new UserModel
                    {
                        Id=1,
                        Name="叶飞"
                    },
                    Title="所有关于学历的问题，一次说个够"
                },
                  new ArticleItemModel
                {
                    Id=2,
                    Author=new UserModel
                    {
                        Id=2,
                        Name="小鱼"
                    },
                    Title="收费明细通知"
                },
                    new ArticleItemModel
                {
                    Id=3,
                    Author=new UserModel
                    {
                        Id=3,
                        Name="赵淼"
                    },
                    Title="学习感悟与总结"
                }
            };
        }

        internal IList<ArticleItemModel> Get()
        {
            return _articles;
        }
    }
}
