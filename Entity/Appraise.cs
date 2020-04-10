using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
   public class Appraise
    {
        private User author;

        public int Praise(User voter)
        {
            author.HelpCreit++;
            voter.HelpCreit--;
            return author.HelpCreit;
        }
        public int Tread(User voter)
        {
            author.HelpCreit--;
            voter.HelpCreit--;
            return author.HelpCreit;
        }
    }
}
