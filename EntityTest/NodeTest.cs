using NUnit.Framework;
using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityTest
{

    class NodeTest
    {
        [SetUp]
        public void Setup()
        {
        }



        [Test]
        public void NodePosition()
        {
            //搭建测试环境
            //创建五个节点
            DLinkedNode node1 = new DLinkedNode();
            DLinkedNode node2 = new DLinkedNode();
            DLinkedNode node3 = new DLinkedNode();
            DLinkedNode node4 = new DLinkedNode();
            DLinkedNode node5 = new DLinkedNode();

            //创建链表
            node2.InsertAfter(node1);
            node3.InsertAfter(node2);
            node4.InsertAfter(node3);
            node5.InsertAfter(node4);

            //开始测试，各个节点的位置特征和相互的联系

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

        public void InsertTest()
        {
            //搭建测试环境
            //创建五个节点
            DLinkedNode node1 = new DLinkedNode();
            DLinkedNode node2 = new DLinkedNode();
            DLinkedNode node3 = new DLinkedNode();
            DLinkedNode node4 = new DLinkedNode();
            DLinkedNode node5 = new DLinkedNode();

            //创建链表
            node2.InsertAfter(node1);
            node3.InsertAfter(node2);
            node4.InsertAfter(node3);
            node5.InsertAfter(node4);

            //当前链表的情况 1 2 3 4 5
            //开始测试前后中三插

            //检查在链表的最前面插入一个值
            //把7插到1的前面
            //6 1 2 3 4 5
            DLinkedNode node6 = new DLinkedNode();
            node6.InsertBefore(node1);
            Assert.AreEqual(node6.Next, node1);
            Assert.AreEqual(node1.Previous, node6);


            //检查在链表中间后面插入一个值
            //把7插到2后面，即3的前面
            //6 1 2 7 3 4 5
            DLinkedNode node7 = new DLinkedNode();
            node7.InsertAfter(node2);
            Assert.AreEqual(node2.Next, node7);
            Assert.AreEqual(node7.Previous, node2);
            Assert.AreEqual(node7.Next, node3);
            Assert.AreEqual(node3.Previous, node7);

            //检查在链表中间后面插入一个值
            //把8插到2前面，即1的后面
            //6 1 8 2 7 3 4 5
            DLinkedNode node8 = new DLinkedNode();
            node7.InsertBefore(node2);
            Assert.AreEqual(node8.Next, node2);
            Assert.AreEqual(node2.Previous, node8);
            Assert.AreEqual(node1.Next, node8);
            Assert.AreEqual(node8.Previous, node1);

            //检查在链表最后面插入一个值
            //把9插到5前面
            //6 1 8 2 7 3 4 5 9
            DLinkedNode node9 = new DLinkedNode();
            node9.InsertAfter(node5);
            Assert.AreEqual(node5.Next, node9);
            Assert.AreEqual(node9.Previous, node5);
        }

    }
}
