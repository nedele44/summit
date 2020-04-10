using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    public interface Iin<in T>
    {
        void show(T t);
    }

    public class In<T> : Iin<T>
    {
        public void show(T t)
        {

        }
    }


}
