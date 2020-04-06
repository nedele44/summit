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
        public bool IsTail { get { return Next == null; } }

        //添加一个删除的功能，能删除这个节点
        public void Detele()
        {
            //删除这个节点之后，他前一个节点就是他后一个节点

            //如果去掉的是头,就是把第二个变成第一个，第一个变成null
            if (IsHead)
            {
                DLinkedNode nodeNext = this.Next;//搞个中间变量
                this.Next = this;//把第二个变成第一个
                nodeNext.Previous = null;//把第一个变成空
            }
            //如果去掉的是尾巴，一样的道理，把倒数第二个变成倒数第一个，把倒数第一个变成空
            else if (IsTail)
            {
                DLinkedNode nodePre = this.Previous;//搞个中间变量
                this.Previous = this;
                nodePre.Next = null;//把倒数第一个变成空
            }
            //如果是中间，应该也需要一个中间变量把
            else
            {
                //DLinkedNode nodeNext = this.Next;
                //this.Next= this.Previous.Next;
                //this.Previous = nodeNext.Previous;

                this.Next.Previous = this.Previous;
                this.Previous.Next = this.Next;
            }
        }

        //添加一个插入的功能，在节点后面插入一个节点
        //把创建的节点（this）插在node的后面，创建的节点的前面就是node
        public void InsertAfter(DLinkedNode node)
        {
            DLinkedNode nodeNext = node.Next;
            node.Next = this;
            this.Previous = node;
            this.Next = nodeNext;
            if (nodeNext != null)
            {
                nodeNext.Previous = this;
            }

        }

        //在这个节点的前面插入一个节点
        //把创建的节点（this）插入node的前面，创建的节点的后面就是node
        public void InsertBefore(DLinkedNode node)
        {
            //在某个节点的前面插入一个节点，说明是在这个节点之前的节点的后面插入一个节点

            if (node.Previous == null)
            {
                node.Previous = this;
                this.Next = node;
            }
            else
            {
                InsertAfter(node.Previous);
            }

            //DLinkedNode nodePre = node.Previous;
            //node.Previous = this;
            //this.Next = node;
            //this.Previous = nodePre;
            //if (nodePre!=null)
            //{
            //    nodePre.Next = this;
            //}

        }


        
    
       public  enum Position
        {
            front,
            behind
        }
        //节点a表示节点移动的参考对象，b表示在节点的前面还是在节点的后面
        public bool Move(DLinkedNode a, Position position)
        {

            //移动一个节点，可以分两步走，1，是删除掉这个节点，2，是插入这个节点
            //如果移动的节点和参考节点都不存在呢
            if (a == null/* || this==null*/)
            {
                Console.WriteLine("你输入的信息有误！");
                return false;
            }
            this.Detele();
            switch (position)
            {
                case Position.front:
                    this.InsertBefore(a);
                    break;
                case Position.behind:
                    this.InsertAfter(a);
                    break;
            }
            return true;
        }



    }
}
