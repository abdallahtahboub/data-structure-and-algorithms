using System;

namespace data_structure_and_algorithms
{
    class LinkedList
    {
        Node Head = null;
        Node Tail = null;
        int Size = 0;


        public void AddLast(int data)
        {
            if (Size == 0)
            {
                Node node = new Node();
                node.Data = data;
                Head = node;
                Tail = node;
                Size++;

            }
            else
            {
                Node node = new Node();
                node.Data = data;
                Tail.next = node;
                Tail = node;
                Size++;

            }
        }


        public void AddFirst(int data)
        {
            Node node = new Node();

            node.Data = data;
            node.next = Head;
            Head = node;

        }


        public Node Find(int data)
        {

            Node node = Head;

            while (node != null)
            {
                if (node.Data == data)
                {

                    return node;

                }

                node = node.next;

            }
            return null;

        }

        public void AddAfter(int oldData, int newData)
        {

            Node isThere = Find(oldData);

            if (isThere != null)
            {
                Node node = new Node();

                node.Data = newData;
                node.next = isThere.next; // isThere.next = b ---> the node after the inserted new node.
                isThere.next = node;
                Size++;


            }

        }

        public void remove(Node p)
        {
            Node node = Head;
            while (node.next != p)
            {

                node = node.next;
            }

            node.next = node.next.next;
            Size--;

        }


        public void Print()
        {
            Node node = Head;
            while (node != null)
            {

                Console.WriteLine(node.Data);

                node = node.next;


            }


        }





    }
}