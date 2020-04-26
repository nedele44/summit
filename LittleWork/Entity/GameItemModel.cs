using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LittleWork.Entity
{
    public class GameItemModel
    {

        public DateTime PublishTime { get; set; }
        public int Id { get; set; }

        public UserModel Author { get; set; }

        public string Title { get; set; }
        public string Abstract { get; set; }
        public GameKind Kind { get; set; }

    }
}
