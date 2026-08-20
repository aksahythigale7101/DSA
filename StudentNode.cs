using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    class StudentNode
    {
        public int DATA;
        public StudentNode Next;
        public StudentNode(int data)
        {
            this.DATA = data;
            Next = null;
        }
    }


    class StudentData
    {

        StudentNode head;

        /*
        public void AssigneData()
        {

            StudentNode s1 = new StudentNode(101);
            StudentNode s2 = new StudentNode(102);
            StudentNode s3 = new StudentNode(103);

            s1.Next = s2;
            s2.Next = s3;
            current = s1;
            display();
        }

        public void display()
        {
            while (current != null)
            {
                Console.Write(current.DATA+ "  ");
                current = current.Next;
            }
        }
        */

        public void AssigneData(int d)
        {
            StudentNode n = new StudentNode(d);

            if (head == null)
            {
                head = n;
                return;
            }

            StudentNode temp = head;

            while (temp.Next != null)
            {

                temp = temp.Next;
            }

            temp.Next = n;
        }

        public void InsertAtPosition(StudentNode _head, int data, int position)
        {
            StudentNode newNode = new StudentNode(data);



            /* first inserion at begining *********
            StudentNode temp = new StudentNode(500);
            temp.Next = head;
            head = temp;
            */


            /* last insertion
            StudentNode newnode = new StudentNode(500);
            StudentNode temp = head;
            while (temp.Next != null)
            {

                temp = temp.Next;
            }
            temp.Next = newnode;
            */





            // Insert at first position
            if (position == 1)
            {
                newNode.Next = _head;
                _head = newNode;
                return;
            }

            StudentNode temp = _head;

            // Move to (position - 1)th node
            for (int i = 1; i < position - 1 && temp != null; i++)
            {
                temp = temp.Next;
            }

            if (temp == null)
            {
                Console.WriteLine("Invalid Position");
                return;
            }

            newNode.Next = temp.Next;
            temp.Next = newNode;


        }



        void DeleteNodes(StudentNode _head, int data, int position)
        {


            ////FirstNodeDelete

            //StudentNode temp =_head.Next;
            // head = _head.Next;



            /* Last Delete
            StudentNode lastDelete = _head;
            while(lastDelete.Next.Next!=null)
            {
                lastDelete = lastDelete.Next;
            }
            lastDelete.Next = null;
            */





            //delete at value pass
            StudentNode DeleteValue = _head;
            while (DeleteValue.Next != null && DeleteValue.Next.DATA != data)
            {

                DeleteValue = DeleteValue.Next;


            }


            DeleteValue.Next = DeleteValue.Next.Next;
        }



        private void ReverseLinkList()
        {

            StudentNode prev = null;

            StudentNode current = head;

            StudentNode next = null;



            //10,20,30,40,50
            while (current != null)
            {
                next = current.Next;

                current.Next = prev;

                prev = current;

                current = next;
            }


            head = prev;

        }


        void FindMiddleNode()
        {
            StudentNode slow = head;

            StudentNode fast = head;


            while (fast.Next != null && fast.Next.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            Console.WriteLine(slow.DATA);

        }

        void DetectedLoop()//Detect Loop (Floyd's Cycle Detection Algorithm)
        {
            StudentNode slow = head;

            StudentNode fast = head;


            while (fast.Next != null && fast.Next.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
                if (slow == fast)
                {
                    Console.WriteLine("Loop Found");
                }
            }

            Console.WriteLine("No Loop");



        }

        public void Display()
        {
            StudentNode temp = head;

            while (temp != null)
            {
                Console.Write(temp.DATA + " -> ");
                temp = temp.Next;
            }



            Console.WriteLine("null");
        }


        public void SetData()
        {

            AssigneData(10);
            AssigneData(20);
            AssigneData(30);
            AssigneData(40);
            // AssigneData(50);
            AssigneData(60);

            Display();

            Console.WriteLine();


            // InsertAtPosition(head,50,5);
            // DeleteNodes(head, 30, 5);
            //ReverseLinkList();
            FindMiddleNode();
            //DetectedLoop();
            // Display();
        }



    }
}
