namespace Assignment_3_skeleton
{
    public class SinglyLinkedListBase : ILinkedListADT
    {

        //Define reference to the firts node
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
    }
}