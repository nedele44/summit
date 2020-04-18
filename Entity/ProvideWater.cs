using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    //1.声明一个委托：打水（ProvideWater），可以接受一个Person类的参数，返回值为int类型 
    public delegate int ProvideWater(Person person);

    public class Person
    {
        public int age { get; set; }
        public string Name { get; set; }
    }

    
   
}
