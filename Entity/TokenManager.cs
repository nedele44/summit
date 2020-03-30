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
        private Token _tokens;


        //暴露Add(Token)、Remove(Token)和Has(Token)方法，可以添加、删除和判断其有无某个权限 
        public Token Add(Token token)
        {
            this._tokens = this._tokens | token;
            return this._tokens;
        }
        public Token Remove(Token token)
        {
            this._tokens = this._tokens ^ token;
            return this._tokens;
        }
        public bool Has(Token token)
        {
            return  (this._tokens & token) == token;
             
        }
    }
}
