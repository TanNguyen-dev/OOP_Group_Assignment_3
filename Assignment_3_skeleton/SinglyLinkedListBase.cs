using System;

namespace Assignment_3_skeleton
{
    public class SinglyLinkedListBase : ILinkedListADT
    {

        private Node head;
        private int listSize;

        public SinglyLinkedListBase()
        {
            head = null;
            listSize = 0;
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public void Clear()
        {
            head = null;
            listSize = 0;
        }

        public void Prepend(object data)
        {
            Node newNode = new Node(data);
            newNode.Next = head;
            head = newNode;
            listSize++;
        }

        public void Append(object data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node currentNode = head;
                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Next = newNode;
            }
            listSize++;
        }

        public int Size()
        {
            return listSize;
        }

        public void Insert(object data, int index)
        {
            if (index < 0 || index > listSize)
            {
                throw new IndexOutOfRangeException("Index is out of bounds.");
            }
            if (index == 0)
            {
                Prepend(data);
            }
            else if (index == listSize)
            {
                Append(data);
            }
            else
            {
                Node newNode = new Node(data);
                Node prevNode = GetNodeAtIndex(index - 1);
                newNode.Next = prevNode.Next;
                prevNode.Next = newNode;
                listSize++;
            }
        }

        public void Replace(object data, int index)
        {
            Node node = GetNodeAtIndex(index);
            node.Data = data;
        }

        public void Delete(int index)
        {
            if (index < 0 || index >= listSize)
            {
                throw new IndexOutOfRangeException("Index is out of bounds.");
            }
            if (index == 0)
            {
                head = head.Next;
            }
            else
            {
                Node prevNode = GetNodeAtIndex(index - 1);
                prevNode.Next = prevNode.Next.Next;
            }
            listSize--;
        }

        private Node GetNodeAtIndex(int index)
        {
            if (index < 0 || index >= listSize)
            {
                throw new IndexOutOfRangeException("Index is out of bounds.");
            }
            Node currentNode = head;
            for (int i = 0; i < index; i++)
            {
                currentNode = currentNode.Next;
            }
            return currentNode;
        }

        public object Retrieve(int index)
        {
            return GetNodeAtIndex(index).Data;
        }

        public int IndexOf(object data)
        {
            Node currentNode = head;
            int index = 0;
            while (currentNode != null)
            {
                if ((currentNode.Data == null && data == null) || (currentNode.Data != null && currentNode.Data.Equals(data)))
                {
                    return index;
                }
                currentNode = currentNode.Next;
                index++;
            }
            return -1;
        }

        public bool Contains(object data)
        {
            return IndexOf(data) != -1;
        }
    }
}
