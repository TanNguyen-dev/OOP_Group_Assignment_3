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
        private List<User> users;
        private SinglyLinkedListBase sll;
        private readonly string testFileName = @"..\..\test_users.bin";

        [SetUp]
        public void Setup()
        {
            sll = new SinglyLinkedListBase();
        }

        [TearDown]
        public void TearDown()
        {
            this.users.Clear();
        }

        //Test the linked list is empty.
        [Test]
        public void TestIsEmpty1()
        {
            Assert.True(sll.IsEmpty());
        }

        //Test the linked list is empty.
        [Test]
        public void TestIsEmpty2()
        {
            Assert.AreEqual(0, sll.Size());
        }


        //Test to check the size.
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

            Assert.AreEqual(3, sll.Size()); // Check size after appending elements
        }

        [Test]
        public void TestPrepend()
        {
            sll.Prepend(1);
            sll.Prepend(2);
            sll.Prepend(3);

            Assert.AreEqual(3, sll.Size()); // Check size after prepending elements
        }

        [Test]
        public void TestClear()
        {
            sll.Append(1);
            sll.Append(2);
            sll.Append(3);

            sll.Clear();

            Assert.IsTrue(sll.IsEmpty()); // Check if the list is empty after clearing
            Assert.AreEqual(0, sll.Size()); // Check if size is zero after clearing
        }


    }
}
