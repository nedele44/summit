using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    //定义一个仓库（Repoistory）类，用于存取对象
    //实例类不占内存，实例化对象是才会在堆上分配内存
    //静态类在整个项目中实现资源共享，静态类本身就在静态存储空间占据一块内存
    /// <summary>
    ///存取对象可以所有实例都可以进行的行为，设计为静态类更为合适
    /// </summary>
    static class Repoistory
    {
        //一个int类型的常量version
        public const int version=10;
        //一个静态只读的字符串connection，以后可用于连接数据库
        static readonly string connection;//以后可用于连接数据库
    }
}
