using NUnit.Framework;
using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityTest
{

    class NodeTest
    {
        DLinkedNode node1, node2, node3, node4, node5;
        [SetUp]
        public void Setup()
        {
            //搭建测试环境
            //创建五个节点
            node1 = new DLinkedNode();
            node2 = new DLinkedNode();
            node3 = new DLinkedNode();
            node4 = new DLinkedNode();
            node5 = new DLinkedNode();

            //创建链表
            node2.InsertAfter(node1);
            node3.InsertAfter(node2);
            node4.InsertAfter(node3);
            node5.InsertAfter(node4);
        }



        [Test]
        public void SetupTest()
        {

            //对起初设置的节点进行测试

            Assert.IsTrue(node1.IsHead);//node1是头
            Assert.AreEqual(node1.Next, node2);
            Assert.IsFalse(node1.IsTail);//node1不是尾

            Assert.IsFalse(node2.IsHead);//node2不是头
            Assert.AreEqual(node2.Previous, node1);
            Assert.AreEqual(node2.Next, node3);
            Assert.IsFalse(node2.IsTail);//node2不是尾

            Assert.IsFalse(node3.IsHead);//node3不是头
            Assert.AreEqual(node3.Previous, node2);
            Assert.AreEqual(node3.Next, node4);
            Assert.IsFalse(node3.IsTail);//node3不是尾

            Assert.IsFalse(node4.IsHead);//node4不是头
            Assert.AreEqual(node4.Previous, node3);
            Assert.AreEqual(node4.Next, node5);
            Assert.IsFalse(node4.IsTail);//node4不是尾

            Assert.IsFalse(node5.IsHead);//node5不是头
            Assert.AreEqual(node5.Previous, node4);
            Assert.IsTrue(node5.IsTail);//node5是尾
        }

        /// <summary>
        /// 分四类，对插入函数InsertBefore和InsertAfter进行测试
        /// </summary>
        [Test]
        //在链表前面添加一个节点,[6] 1 2 3 4 5
        public void InsertBefore_Head_Test()
        {
            DLinkedNode node6 = new DLinkedNode();
            node6.InsertBefore(node1);
            Assert.AreEqual(node6.Next, node1);
            Assert.AreEqual(node1.Previous, node6);
        }

        [Test]
        //在链表中间一个节点前面添加一个节点 1 [6] 2 3 4 5
        public void InsertBefore_Mid_Test()
        {
            DLinkedNode node6 = new DLinkedNode();
            node6.InsertBefore(node2);
            Assert.AreEqual(node6.Next, node2);
            Assert.AreEqual(node2.Previous, node6);
            Assert.AreEqual(node1.Next, node6);
            Assert.AreEqual(node6.Previous, node1);
        }


        //在链表中间一个节点的后面添加一个节点 1 2 [6] 3 4 5
        [Test]
        public void InsertAfter_Mid_Test()
        {
            DLinkedNode node6 = new DLinkedNode();
            node6.InsertAfter(node2);
            Assert.AreEqual(node2.Next, node6);
            Assert.AreEqual(node6.Previous, node2);
            Assert.AreEqual(node6.Next, node3);
            Assert.AreEqual(node3.Previous, node6);
        }


        //在链表的最后面添加一个节点 1 2 3 4 5 [6]
        [Test]
        public void InsertAfter_Tail_Test()
        {
            DLinkedNode node6 = new DLinkedNode();
            node6.InsertAfter(node5);
            Assert.AreEqual(node5.Next, node6);
            Assert.AreEqual(node6.Previous, node5);
        }


        /// <summary>
        /// 分三种情况来，测试删除函数Delete
        /// </summary>

        //把链表的第一个去掉 （1） 2 3 4 5
        [Test]
        public void Delete_Head_Test()
        {
            //判断第二个是否为头，以及其他节点是否受到影响
            node1.Detele();

            Assert.IsTrue(node2.IsHead);//node2是头
            Assert.AreEqual(node2.Next, node3);
            Assert.IsFalse(node2.IsTail);//node2不是尾

            Assert.IsFalse(node3.IsHead);//node3不是头
            Assert.AreEqual(node3.Previous, node2);
            Assert.AreEqual(node3.Next, node4);
            Assert.IsFalse(node3.IsTail);//node3不是尾

            Assert.IsFalse(node4.IsHead);//node4不是头
            Assert.AreEqual(node4.Previous, node3);
            Assert.AreEqual(node4.Next, node5);
            Assert.IsFalse(node4.IsTail);//node4不是尾

            Assert.IsFalse(node5.IsHead);//node5不是头
            Assert.AreEqual(node5.Previous, node4);
            Assert.IsTrue(node5.IsTail);//node5是尾
        }

        [Test]
        //把链表的中间一个去电 1 2 （3） 4 5
        public void Delete_Mid_Test()
        {
            node3.Detele();
            // 2的后一个是4,4的前一个是2，其他不变
            Assert.IsTrue(node1.IsHead);//node1是头
            Assert.AreEqual(node1.Next, node2);
            Assert.IsFalse(node1.IsTail);//node1不是尾

            Assert.IsFalse(node2.IsHead);//node2不是头
            Assert.AreEqual(node2.Previous, node1);
            Assert.AreEqual(node2.Next, node4);
            Assert.IsFalse(node2.IsTail);//node2不是尾

            Assert.IsFalse(node4.IsHead);//node4不是头
            Assert.AreEqual(node4.Previous, node2);
            Assert.AreEqual(node4.Next, node5);
            Assert.IsFalse(node4.IsTail);//node4不是尾

            Assert.IsFalse(node5.IsHead);//node5不是头
            Assert.AreEqual(node5.Previous, node4);
            Assert.IsTrue(node5.IsTail);//node5是尾
        }

        [Test]
        //把最后的那个节点去掉 1 2 3 4 （5）
        public void Delete_Tail_Test()
        {
            node5.Detele();
            Assert.IsTrue(node1.IsHead);//node1是头
            Assert.AreEqual(node1.Next, node2);
            Assert.IsFalse(node1.IsTail);//node1不是尾

            Assert.IsFalse(node2.IsHead);//node2不是头
            Assert.AreEqual(node2.Previous, node1);
            Assert.AreEqual(node2.Next, node3);
            Assert.IsFalse(node2.IsTail);//node2不是尾

            Assert.IsFalse(node3.IsHead);//node3不是头
            Assert.AreEqual(node3.Previous, node2);
            Assert.AreEqual(node3.Next, node4);
            Assert.IsFalse(node3.IsTail);//node3不是尾

            Assert.IsFalse(node4.IsHead);//node4不是头
            Assert.AreEqual(node4.Previous, node3);
            Assert.IsTrue(node4.IsTail);//node4是尾
        }



        /// <summary>
        /// 下面这个是用来测试，链表某个节点的移动，
        /// 
        /// </summary>
        [Test]
        //用来测试现有的节点插到另一个节点的后面
        public void Move_After_Test()
        {
            //居然测试通过了
            //将node1移动到node3的后面 即为 2  3 [1] 4 5
         node1.Move(node3, DLinkedNode.Position.behind);
            //受影响的节点为1 2 3 4
           
            Assert.IsTrue(node2.IsHead);//node2是头
            Assert.AreEqual(node2.Next, node3);
            Assert.IsFalse(node2.IsTail);//node2不是尾

            Assert.IsFalse(node3.IsHead);//node3不是头
            Assert.AreEqual(node3.Previous, node2);
            Assert.AreEqual(node3.Next, node1);//node3的下一个是node1
            Assert.IsFalse(node3.IsTail);//node3不是尾

            Assert.IsFalse(node1.IsHead);//node1不是头
            Assert.AreEqual(node1.Previous, node3);
            Assert.AreEqual(node1.Next, node4);
            Assert.IsFalse(node1.IsTail);//node1不是尾

            Assert.IsFalse(node4.IsHead);//node4不是头
            Assert.AreEqual(node4.Previous, node1);//node4的前一个是node1
            Assert.AreEqual(node4.Next, node5);
            Assert.IsFalse(node4.IsTail);//node4不是尾

            Assert.IsFalse(node5.IsHead);//node5不是头
            Assert.AreEqual(node5.Previous, node4);
            Assert.IsTrue(node5.IsTail);//node5是尾
        }


        [Test]
        //用来测试现有的节点插到另一个节点的后面
        public void Move_Before_Test()
        {
            //居然测试通过了
            //将node1移动到node3的前面,  //将node1移动到node3的后面 即为 2  [1]  3  4 5
           node1.Move(node3, DLinkedNode.Position.front);
            //受影响的节点为1 2 3 4
          
            Assert.IsTrue(node2.IsHead);//node2是头
            Assert.AreEqual(node2.Next, node1);//node2的后一个就是node1
            Assert.IsFalse(node2.IsTail);//node2不是尾

            Assert.IsFalse(node1.IsHead);//node1不是头
            Assert.AreEqual(node1.Previous, node2);
            Assert.AreEqual(node1.Next, node3); //node1的后一个就是node3
            Assert.IsFalse(node1.IsTail);//node1不是尾

            Assert.IsFalse(node3.IsHead);//node3不是头
            Assert.AreEqual(node3.Previous, node1);
            Assert.AreEqual(node3.Next, node4);//node3的下一个是node1
            Assert.IsFalse(node3.IsTail);//node3不是尾



            Assert.IsFalse(node4.IsHead);//node4不是头
            Assert.AreEqual(node4.Previous, node3);//node4的前一个是node1
            Assert.AreEqual(node4.Next, node5);
            Assert.IsFalse(node4.IsTail);//node4不是尾

            Assert.IsFalse(node5.IsHead);//node5不是头
            Assert.AreEqual(node5.Previous, node4);
            Assert.IsTrue(node5.IsTail);//node5是尾
        }

      
        /// <summary>
        /// 下面是测试两个节点互相交换，分三种情况进行检测，1，有第一参与，2，有最后一个参与，3，两者都没有
        /// </summary>
        [Test]
        //第一个与中间的节点4交换 1 2 3 4 5 --》4 2 3 1 5
        public void Swap_Head_Test()
        {
            node1.Swap(node4);

            Assert.IsTrue(node4.IsHead);//node4是头
            Assert.AreEqual(node4.Next, node2);
            Assert.IsFalse(node4.IsTail);//node4不是尾

            Assert.IsFalse(node2.IsHead);//node2不是头
            Assert.AreEqual(node2.Previous, node4);
            Assert.AreEqual(node2.Next, node3);
            Assert.IsFalse(node2.IsTail);//node2不是尾

            Assert.IsFalse(node3.IsHead);//node3不是头
            Assert.AreEqual(node3.Previous, node2);
            Assert.AreEqual(node3.Next, node1);
            Assert.IsFalse(node3.IsTail);//node3不是尾

            Assert.IsFalse(node1.IsHead);//node1不是头
            Assert.AreEqual(node1.Previous, node3);
            Assert.AreEqual(node1.Next, node5);
            Assert.IsFalse(node1.IsTail);//node1不是尾

            Assert.IsFalse(node5.IsHead);//node5不是头
            Assert.AreEqual(node5.Previous, node1);
            Assert.IsTrue(node5.IsTail);//node5是尾
        }


        [Test]
        //最后一个与中间交换1 2 3 4 5  --》 1  2 5 4 3
        public void Swap_Tail_Test() 
        {
            node5.Swap(node3);

            Assert.IsTrue(node1.IsHead);//node1是头
            Assert.AreEqual(node1.Next, node2);
            Assert.IsFalse(node1.IsTail);//node1不是尾

            Assert.IsFalse(node2.IsHead);//node2不是头
            Assert.AreEqual(node2.Previous, node1);
            Assert.AreEqual(node2.Next, node5);
            Assert.IsFalse(node2.IsTail);//node2不是尾

            Assert.IsFalse(node5.IsHead);//node5不是头
            Assert.AreEqual(node5.Previous, node2);
            Assert.AreEqual(node5.Next, node4);
            Assert.IsFalse(node5.IsTail);//node5不是尾

            Assert.IsFalse(node4.IsHead);//node4不是头
            Assert.AreEqual(node4.Previous, node5);
            Assert.AreEqual(node4.Next, node3);
            Assert.IsFalse(node4.IsTail);//node4不是尾

            Assert.IsFalse(node3.IsHead);//node3不是头
            Assert.AreEqual(node3.Previous, node4);
            Assert.IsTrue(node3.IsTail);//node3是尾
        }

        [Test]
        //头尾交换 1 2 3 4 5 --》5 2 3 4 1
        public void Swap_Head_Tail()
        {
            node1.Swap(node5);

            Assert.IsTrue(node5.IsHead);//node5是头
            Assert.AreEqual(node5.Next, node2);
            Assert.IsFalse(node5.IsTail);//node5不是尾

            Assert.IsFalse(node2.IsHead);//node2不是头
            Assert.AreEqual(node2.Previous, node5);
            Assert.AreEqual(node2.Next, node3);
            Assert.IsFalse(node2.IsTail);//node2不是尾

            Assert.IsFalse(node3.IsHead);//node3不是头
            Assert.AreEqual(node3.Previous, node2);
            Assert.AreEqual(node3.Next, node4);
            Assert.IsFalse(node3.IsTail);//node3不是尾

            Assert.IsFalse(node4.IsHead);//node4不是头
            Assert.AreEqual(node4.Previous, node3);
            Assert.AreEqual(node4.Next, node1);
            Assert.IsFalse(node4.IsTail);//node4不是尾

            Assert.IsFalse(node1.IsHead);//node5不是头
            Assert.AreEqual(node1.Previous, node4);
            Assert.IsTrue(node1.IsTail);//node5是尾
        }

        [Test]
        //中间两个交换
        public void Swap_Mid_Test()
        {
            node2.Swap(node4);

            Assert.IsTrue(node1.IsHead);//node1是头
            Assert.AreEqual(node1.Next, node4);
            Assert.IsFalse(node1.IsTail);//node1不是尾

            Assert.IsFalse(node4.IsHead);//node2不是头
            Assert.AreEqual(node4.Previous, node1);
            Assert.AreEqual(node4.Next, node3);
            Assert.IsFalse(node2.IsTail);//node2不是尾

            Assert.IsFalse(node3.IsHead);//node3不是头
            Assert.AreEqual(node3.Previous, node4);
            Assert.AreEqual(node3.Next, node2);
            Assert.IsFalse(node3.IsTail);//node3不是尾

            Assert.IsFalse(node2.IsHead);//node4不是头
            Assert.AreEqual(node2.Previous, node3);
            Assert.AreEqual(node2.Next, node5);
            Assert.IsFalse(node2.IsTail);//node4不是尾

            Assert.IsFalse(node5.IsHead);//node5不是头
            Assert.AreEqual(node5.Previous, node2);
            Assert.IsTrue(node5.IsTail);//node5是尾
        }



    }
}
