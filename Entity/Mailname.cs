using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Entity
{
    public class Mailname
    {

        public Mailname(string filepath)
        {
            strFilePath = filepath;
        }
        private string strFilePath;

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
       

        public string[] SplitMessages()
        {
            string lowerMessages = this.GetMessages().ToLower();
            string trimMessages = lowerMessages.Replace(" ",null);
            string[] result = trimMessages.Split(";");
            return result;
        }

        public string[] DedupleMessages()
        {
            string[] result=this.SplitMessages().Distinct().ToArray();
            return result;
        }

        public int LineNumber { get; set; }
        public string RebulidMessages()
        {
            StringBuilder strMessages = new StringBuilder();
            for (int i = 1; i < this.DedupleMessages().Length + 1; i++)
            {
                if (i % LineNumber == 0)
                {
                    strMessages.Append(this.DedupleMessages()[i - 1] + "\n");
                }
                else
                {
                    strMessages.Append(this.DedupleMessages()[i - 1] + ";");
                }
            }
            return strMessages.ToString();
        }



        public void WriteMessages(string filepath)
        {
            File.WriteAllText(filepath,this.RebulidMessages());
        }

    }
}
