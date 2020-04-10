using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    public interface Iout<out T>
    {
        T get();
    }

    public class Out<T> : Iout<T>
    {
        public T get()
        {
            return default(T);
        }

    }
}
