using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    class DynamicAndVar
    {
        ///var表示“变量的类型是在编译时决定的”， var让你在初始化变量时少输入一些字，
        ///编译器会根据右值来推断出变量的类型， var只能用于局部变量的定义，你不能把类的属性定义成 var，
        ///也不能把方法的返回值类型或者是参数类型定义成var
        ///

        ///
        ///dynamic表示“变量的类型是在运行时决定的”，动态语言运行时（dynamic language runtime DLR）是.NET Framework 4 Beta 1中的一组新的API，
        ///它提供了对c#中dynamic类型的支持, dynamic告诉编译器，根本就别理究竟是啥类型，运行时再推断不迟，
        ///dynamic类型并没有跳过类型校验，只是延迟到了运行时。如果在运行时，检测到类型不兼容，照样会抛出异常。
        ///变量，属性，方法返回值类型及参数类型都可定义为dynamic。
        ///

        //全局变量  
        //var a = 4;
        //dynamic b = 4;

        ////局部变量和参数引用,方法返回值
        //public var add(var a)
        //{
        //    var b = 1;
        //}
       
        //public dynamic add(dynamic a)
        //{
        //    dynamic b = 1;
        //}

        ////属性设置
        //public var d { get; }

        //public dynamic e { get; }

        //var的可适用范围确实少的可怜
    }
}
