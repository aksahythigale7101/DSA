using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    class Node
    {
        public int Data;
        public Node Next;

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }



    public class linkedList
    {

        public static void _mainMethod()
        {
            //creates node
            Node first = new Node(10);
            Node second = new Node(20);
            Node third = new Node(30);

            //connectes nood

            first.Next = second;
            second.Next = third;





            //print linked list
            // Node current = first;////


            //insertion at starting
            Node current = new Node(5);
            current.Next = first;
            first = current;


            //instertion at last
            Node lastnod = new Node(40);
            third.Next = lastnod;

            //insertion in middle
            Node middle = new Node(70);



            while (current != null)
            {

                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }
    }

}
