using System;

namespace Assignment_3_skeleton
{
    public class SinglyLinkedListBase : ILinkedListADT
    {

        /        //Define reference to the firts node
        private Node head;
        private int listSize;

        //SLL constructor
        public SinglyLinkedListBase()
        {
            head = null;
        }

        public bool IsEmpty()
        {
            if (head is null)
            {
                return true;
            }
            return false;
        }

        public void Clear()
        {
            head = null;
            listSize = 0;
        }

        public void Prepend(object data)
        {
            //Create new node
            Node newNode = new Node(data);
            //Set the new node to the head
            newNode.Next = head;
            //Update head to the next node
            head = newNode;

            //Update listSize
            listSize++;
        }

        public void Append(object data)
        {
            Node newNode = new Node(data);
            if (head is null)
            {
                //Update head to the newNode;
                head = newNode;
                listSize++;
                return;
            }

            //Interate through the SLL
            Node currentNode = head;
            while (currentNode.Next != null)
            {
                // Go to the next node 
                currentNode = currentNode.Next;
            }

            // Update the last node to point to the new node
            currentNode.Next = newNode;

            //Update listSize
            listSize++;
        }

        public int Size()
        {
            //Checking if SLL is empty
            if (head is null)
            {
                return 0;
            }
            return listSize;
        }

        public void Insert(object data, int index)
        {
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

        public Object Retrieve(int index)
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
            return currentNode.Data != null ? currentNode.Data : null;
        }

        public int IndexOf(Object data)
        {
            int index = 0;
            Node currentNode = head;

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

        public bool Contains(Object data)
        {
            return IndexOf(data) != -1;
        }
    }
}
