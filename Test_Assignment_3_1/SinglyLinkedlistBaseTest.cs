using Assignment_3_skeleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Assignment_3
{
    public class SinglyLinkedListBaseTest
    {
       private SinglyLinkedListBase sll;

        [SetUp]
        public void Setup()
        {
            sll = new SinglyLinkedListBase();
        }

        [TearDown]
        public void TearDown()
        {
            sll.Clear(); // Clear the list after each test
        }

        [Test]
        public void TestIsEmpty1()
        {
            Assert.IsTrue(sll.IsEmpty());
        }

        [Test]
        public void TestIsEmpty2()
        {
            Assert.AreEqual(0, sll.Size());
        }

        [Test]
        public void TestSize()
        {
            sll.Prepend(4);
            sll.Prepend(10);
            sll.Prepend(60);
            sll.Prepend(5);

            Assert.AreEqual(4, sll.Size());
        }

        [Test]
        public void TestAppend()
        {
            sll.Append(1);
            sll.Append(2);
            sll.Append(3);

            Assert.AreEqual(3, sll.Size());
        }

        [Test]
        public void TestPrepend()
        {
            sll.Prepend(1);
            sll.Prepend(2);
            sll.Prepend(3);

            Assert.AreEqual(3, sll.Size());
        }

        [Test]
        public void TestClear()
        {
            sll.Append(1);
            sll.Append(2);
            sll.Append(3);

            sll.Clear();

            Assert.IsTrue(sll.IsEmpty());
            Assert.AreEqual(0, sll.Size());
        }

        [Test]
        public void TestDelete()
        {
            sll.Append(1);
            sll.Append(2);

            sll.Delete(0);
            Assert.AreEqual(1, sll.Size());
        }

        [Test]
        public void TestRetrieve()
        {
            sll.Append(1);
            Assert.AreEqual(1, sll.Retrieve(0));
        }

        [Test]
        public void TestContain()
        {
            sll.Append(1);
            Assert.IsTrue(sll.Contains(1));
        }

        [Test]
        public void TestIndexOf()
        {
            sll.Append(1);
            sll.Append(2);
            Assert.AreEqual(0, sll.IndexOf(1));
        }
    }
}
