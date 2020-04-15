using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
   public static class NodeExtesion
    {
        private static int[] a;
        private static DLinkedNode maxnode;


        //调用扩展方法Max()：能够返回链表中存贮着最大值的节点
        //链表如果能被foreach，那么找到链表的最大值得节点不成问题
        public static DLinkedNode Max(this DLinkedNode DLinkedNode)
        {
            //先搞个集合来装node.Value,不对，应该是搞个字典，一个存节点名，一个存节点值
            List<int> values = new List<int>();
            ////DLinkedNode node1 = new DLinkedNode();
            //Dictionary<DLinkedNode, int> scores = new Dictionary<DLinkedNode, int>();
            foreach (var item in DLinkedNode)
            {
                int value = ((DLinkedNode)item).Value;
                values.Add(value);
            }
            //先找到字典里面的最大值
            //将字典里的values生成一个一维数组，第一项标识为0
            int[] a=values.ToArray();
            //在一维数组中找到最大值
            int max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }//else nothing change
            }
            //在通过最大值来找到字典中对应的key
            foreach (var item in DLinkedNode)
            {
                int value = ((DLinkedNode)item).Value;
                if (value == max)
                {
                    DLinkedNode maxnode = (DLinkedNode)item;
                }
            }
            return maxnode;
            //在回过头来想，其实可以不用字典，用list就可以了，把node的value框起来，然后copytoArray
            //然后for循环找到最大值，在foreach，node即可
        }

        
      
    }
}
