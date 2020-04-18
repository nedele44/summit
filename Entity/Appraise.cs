using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Appraise
    {
        public  User Author{get;set;}

        public int Praise(User voter)
        {
           Author.HelpCreit++;
            voter.HelpCreit--;
            return Author.HelpCreit;
        }
        public int Tread(User voter)
        {
            Author.HelpCreit--;
            voter.HelpCreit--;
            return Author.HelpCreit;
        }
    }
}
