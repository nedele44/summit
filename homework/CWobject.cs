using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    class CWObject
    {



        // Writes the text representation of an object followed by a line terminator to the text stream.
        //将对象的文本表示形式，后跟行终止符写入文本流。
        //
        //public virtual void WriteLine(object? value)
        //{
        //    if (value == null)
        //    {
        //        WriteLine();//直接打印换行
        //    }
        //    else
        //    {
        //        // Call WriteLine(value.ToString), not Write(Object), WriteLine().
        //        // This makes calls to WriteLine(Object) atomic.
        //        if (value is IFormattable f)
        //        {
        //            WriteLine(f.ToString(null, FormatProvider));
        //        }
        //        else
        //        {
        //            WriteLine(value.ToString());
        //        }
        //    }
        //}

        // Writes a line terminator to the text stream. The default line terminator is Environment.NewLine, but this value can be changed by setting the NewLine property.
        // 将行终止符写入文本流。 默认的行终止符是Environment.NewLine，但是可以通过设置NewLine属性来更改此值。
        //
        //public virtual void WriteLine()
        //{
        //    Write(CoreNewLine);
        //}

        /// <summary>
        /// This is the 'NewLine' property expressed as a char[].
        /// NewLine属性用字符组来表示
        /// It is exposed to subclasses as a protected field for read-only purposes.
        /// 出于只读目的，它作为保护字段公开给子类。
        ///   You should only modify it by using the 'NewLine' property.
        /// 使用属性对其修改
        /// In particular you should never modify the elements of the array  as they are shared among many instances of TextWriter.
        ///特别是，您永远不要修改数组的元素，因为它们在许多TextWriter实例之间共享。
        /// </summary>
        //protected char[] CoreNewLine = s_coreNewLine;
        //private string CoreNewLineStr = Environment.NewLineConst;


        // Returns a String which represents the object instance.  The default  for an object is to return the fully qualified name of the class.
        //返回表示对象实例的字符串。 对象的默认值是返回类的完全限定名称。
        public virtual string? ToString()
        {
            return GetType().ToString();
        }
    }
}
