using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    //双向链表要能被foreach，就要继承IEnumerable
    public class DLinkedNode : IEnumerable
    {
        public DLinkedNode Next { get; private set; }//链表节点

        public DLinkedNode Previous { get; private set; }


        public int Id { get; set; }//value 也可以
        public int Value { get; set; }//value 也可以

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

            if (nodeNext != null)
            {
                this.Next = nodeNext;
                nodeNext.Previous = this;
            }
            else
            {
                this.Next = null;
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
                this.Previous = null;
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




        public enum Position
        {
            front,
            behind
        }
        //节点a表示节点移动的参考对象，position表示在节点的前面还是在节点的后面
        public /*bool*/ void Move(DLinkedNode a, Position position)
        {

            //移动一个节点，可以分两步走，1，是删除掉这个节点，2，是插入这个节点
            //如果移动的节点和参考节点都不存在呢
            //if (a == null/* || this==null*/)
            //{
            //    Console.WriteLine("你输入的信息有误！");
            //    //return false;
            //}
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
            //    return true;
        }


        //交换现有的节点Swap
        //可能要分两种情况讨论，这个问题
        //1.如果交换的两个节点如果是相邻的两个节点，那么只需要将后一个节点查到前一个节点的前面即可，后者说把前一个节点放在后一个节点的后面
        //2.如果交换的两个节点不相邻，那么就需要有两个参考点，两个节点的前面的节点为参考点
        public void Swap(DLinkedNode node)
        {
            //首先第一步应该是判断两个节点是否相邻,还需要细分，他们谁在前，谁在后
            if (this.Next == node/*||this.Previous==node*/)
            {
                this.Move(node, Position.behind);
            }
            else if (this.Previous == node)
            {
                this.Move(node, Position.front);
            }
            else
            {
                //现在考虑不相邻怎么办，谁前谁后不用考虑，但是如果出现首尾参与的交换呢，参考点可能会是null  
                //第一步先把一个节点移到另一个节点的后面再说,不对,需要有个中间变量,来存储移动前，前后的信息
                DLinkedNode thisNext = this.Next;
                DLinkedNode thisPre = this.Previous;
                this.Move(node, Position.behind);
                //后面为空，说明起先是尾部在移动，就需要以前面的点作为参考点
                if (thisNext == null)
                {
                    node.Move(thisPre, Position.behind);
                }
                else
                {
                    node.Move(thisNext, Position.front);
                }
            }

        }

        //这里是自动生成的实现接口
        public IEnumerator GetEnumerator()
        {
            //throw new NotImplementedException();
            return new NodeEnumerator();
        }
        public class NodeEnumerator : IEnumerator
        {
            //private static DLinkedNode node1;
            //private static DLinkedNode node2;
            //private static DLinkedNode node3;
            //private static DLinkedNode node4;
            //private static DLinkedNode node5;

            //先创建一个链表再说

            //DLinkedNode node1 = new DLinkedNode() { Value = 1 };
            //DLinkedNode node2 = new DLinkedNode() { Value = 2 };
            //DLinkedNode node3 = new DLinkedNode() { Value = 3 };
            //DLinkedNode node4 = new DLinkedNode() { Value = 4 };
            //DLinkedNode node5 = new DLinkedNode() { Value = 5 };

            //如果是节点集合，就不是foreach链表了，但是如果不是集合，item就为空，
            //DLinkedNode[] nodes = new DLinkedNode[] { node1, node2, node3, node4, node5 };
            //DLinkedNode[] nodes = new DLinkedNode[] {};
            //List<DLinkedNode> nodes = new List<DLinkedNode>();
            int[] a = new int[] { 1, 2, 3, 4, 5 };
            private int index=-1;

            public object Current
            {
                get
                {
                    return a[index];
                }
            }
            public bool MoveNext()
            {
                index++;
                return index<a.Length;
            }
            public void Reset()
            {
                throw new NotImplementedException();
            }
        }
    }
}
