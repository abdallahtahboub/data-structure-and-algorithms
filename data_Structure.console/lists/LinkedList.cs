using System;

namespace data_structure_and_algorithms
{
    public class LinkedList
    {


        Node Head = null;
        Node Tail = null;
        int Size = 0;


        // Methode: AddLast -> Add nodes at the end of the list.

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
                Tail.Next = node;
                Tail = node;
                Size++;

            }




        }

        public void AddFirst(int data)
        {

            Node node = new Node();

            node.Data = data;
            node.Next = Head;
            Head = node;



        }

        public virtual Node Find(int data)
        {


            Node node = Head;
            while (node != null)
            {
                if (node.Data == data)
                {

                    return node;

                }

                node = node.Next;
            }

            return null;


        }


        // Add data after a specific eleement.
        public void AddAfter(int newElement, int oldElement)
        {


            Node element = Find(oldElement);
            if (element != null)
            {

                Node node = new Node();

                node.Data = newElement;
                node.Next = element.Next;
                element.Next = node;
                Size++;


            }



        }

        public void Print()
        {

            Node node = Head;

            while (node != null)
            {
                Console.Write(node.Data + " " + "->");
                node = node.Next;
            }

        }



    }
}