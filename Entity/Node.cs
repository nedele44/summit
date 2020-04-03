using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class DLinkedNode
    {
        public DLinkedNode Next { get; private set; }//链表节点

        public DLinkedNode Previous { get; private set; }


        public int Id { get; set; }//value 也可以

        //如果他是链表的第一个，说明他前面一个是null
        public bool IsHead 
        {
            get { return Previous == null; }
        }


        //如果他是链表的最后一个，说明他后面一个是null 
        public bool IsTail { get{ return Next == null; } }

        //添加一个删除的功能，能删除这个节点
        public void Detele() { }

        //添加一个插入的功能，在节点后面插入一个节点
        //把创建的节点（this）插在node的后面，创建的节点的前面就是node
        public void InsertAfter(DLinkedNode node) 
        {
            DLinkedNode nodeNext = node.Next;
            node.Next = this;
            this.Previous = node;
            this.Next = nodeNext;
            if (nodeNext!=null)
            {
                nodeNext.Previous = this;
            }
           
        }

        //在这个节点的前面插入一个节点
        //把创建的节点（this）插入node的前面，创建的节点的后面就是node
        public void InsertBefore(DLinkedNode node)
        {
            DLinkedNode nodePre = node.Previous;
            node.Previous = this;
            this.Next = node;
            this.Previous = nodePre;
            if (nodePre!=null)
            {
                nodePre.Next = this;
            }

        }


        //把两个节点进行交换
        public void Swap(DLinkedNode a, DLinkedNode b) { }
    }
}
