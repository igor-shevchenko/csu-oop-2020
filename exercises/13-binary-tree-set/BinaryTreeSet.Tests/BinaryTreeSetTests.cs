using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BinaryTreeSet;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryTreeSet.Tests
{
    [TestClass]
    public class BinaryTreeSetTests
    {
        [TestMethod]
        public void TestAddAndGet()
        {
            var set = new BinaryTreeSet<int>();

            set.Add(1);

            Assert.IsTrue(set.Contains(1));
        }

        [TestMethod]
        public void TestAddMultipleAndGet()
        {
            var set = new BinaryTreeSet<int>();

            set.Add(8);
            set.Add(3);
            set.Add(6);
            set.Add(4);

            Assert.IsTrue(set.Contains(4));
        }

        [TestMethod]
        public void TestDontAddAndDontGet()
        {
            var set = new BinaryTreeSet<int>();
           
            Assert.IsFalse(set.Contains(1));
        }

        [TestMethod]
        public void TestCountEmpty()
        {
            var set = new BinaryTreeSet<int>();
           
            Assert.AreEqual(0, set.Count);
        }

        [TestMethod]
        public void TestCount()
        {
            var set = new BinaryTreeSet<int>();

            set.Add(1);
            set.Add(2);
            set.Add(3);
           
            Assert.AreEqual(3, set.Count);
        }

        [TestMethod]
        public void TestDontCountTwice()
        {
            var set = new BinaryTreeSet<int>();

            set.Add(1);
            set.Add(1);

            Assert.AreEqual(1, set.Count);
        }

        [TestMethod]
        public void TestReturnList()
        {
            var set = new BinaryTreeSet<int>();

            set.Add(1);
            set.Add(2);
            set.Add(3);

            CollectionAssert.AreEqual(new[] {1, 2, 3}, set.ToList());
        }

        [TestMethod]
        public void TestRemoveNotAdded()
        {
            var set = new BinaryTreeSet<int>();

            Assert.IsFalse(set.Remove(1));;
        }

        [TestMethod]
        public void TestRemoves()
        {
            var set = new BinaryTreeSet<int>();
            set.Add(1);

            Assert.IsTrue(set.Remove(1));;
            Assert.AreEqual(0, set.Count);;
        }

        [TestMethod]
        public void TestRemovesWihDeepTree()
        {
            var set = new BinaryTreeSet<string>();
            set.Add("D");
            set.Add("C");
            set.Add("B");
            set.Add("G");
            set.Add("E");
            set.Add("F");

            Assert.IsTrue(set.Remove("D"));;
            Assert.AreEqual(5, set.Count);;
        }


        [TestMethod]
        public void TestIntersects()
        {
            var set = new BinaryTreeSet<int>();

            set.Add(1);
            set.Add(2);
            set.Add(3);

            set.IntersectWith(new[] {2, 3, 4, 5});

            CollectionAssert.AreEqual(new[] { 2, 3 }, set.ToList());
        }
    }
}
