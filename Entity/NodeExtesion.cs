using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
   public static class NodeExtesion
    {
        //调用扩展方法Max()：能够返回链表中存贮着最大值的节点
        //链表如果能被foreach，那么找到链表的最大值得节点不成问题
        public static DLinkedNode Max(this IEnumerable<DLinkedNode> node)
        {

            DLinkedNode node1=new DLinkedNode();
            return node1;
        }
    }
}
