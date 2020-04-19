using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Entity
{
    public class Mailname
    {
        //首先要创建一个方法来获取txt文件中的文本信息
        public Mailname(string filepath)
        {
            strFilePath = filepath;
        }
        private string strFilePath;
        //private string messages;
        private string newMessages;
        public string GetMessages()
        {
            if (File.Exists(strFilePath))
            {
                string messages = File.ReadAllText(strFilePath);
                return messages;
            }
            else
            {
                throw new FieldAccessException("请输入正确的文本路径");
            }
        }

        //然后是创建一个方法来改造获取的信息，三十个一行，删除重复（这里认定为保留一个）
        //有空格的，去掉空格后的相同的仍然属于相同字符串，统一保留没空格的
        public string ChangeMessages(int lineMail)
        {
            //先去掉字符串内的所有空格
            string trimMessages =this.GetMessages().Trim();
            //把所获取的信息进行分组，根据分号“：”,生成一个集合
            string[] splitMessages = trimMessages.Split(";");
            //然后在去掉重复,通过使用默认的相等比较器(Distinct)返回序列中的不同元素
            string[] result = splitMessages.Distinct().ToArray();
            StringBuilder strMessages= new StringBuilder();
            //
            for (int i = 1; i < result.Length+1; i++)
            {
                if (i%lineMail==0)
                {
                   strMessages.Append(result[i-1]+ "\n");
                }
                else
                {
                    strMessages.Append(result[i-1]+";");
                }
                
            }
            newMessages = strMessages.ToString();
            return newMessages;
        }

        //最后是将改造的信息，加入一个新的txt文本中
        public void WriteMessages(string filepath,int lineMail)
        {
            File.WriteAllText(filepath, this.ChangeMessages(lineMail));
        }

    }
}
