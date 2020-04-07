using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class TokenManager
    {
        public TokenManager(Token token)
        {
            this._tokens = token;
        }

        //使用私有的Token枚举_tokens存储所具有的权限
        public Token _tokens;


        //暴露Add(Token)、Remove(Token)和Has(Token)方法，可以添加、删除和判断其有无某个权限 
        public Token Add(Token token)
        {
            this._tokens =(this._tokens | token);
            return this._tokens;
            
        }
        public Token Remove(Token token)
        {
            //异或是相同的去掉，不同的留下
            //这个方法的目的是移除已经有的指令，也就是说这个指令必须是this含有的
            //需要进行一次判断看看是否包含,包含就去掉这个权限，不包含就维持
            bool result=this.Has(token);
            if (result)
            {
                this._tokens = (this._tokens ^ token);
                return this._tokens;
            }
            else
            {
                return this._tokens;
            }
        }
        public bool Has(Token token)
        {
            return  (this._tokens & token) == token;
             
        }
    }
}
