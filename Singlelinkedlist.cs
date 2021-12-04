using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp31
{
    public class SingleLinkedList
    {
        private Node Head;
        public SingleLinkedList()
        {
            this.Head = null;
        }
        public void Display()
        {
            Node p = Head;
            while (p != null)
            {
                Console.WriteLine(p.info);
                p = p.link;
            }
        }
        public void removeLast()
        {
            if (Head == null)
                return;
            if (Head.link == null)
            {
                Head = null;
                return;
            }
            Node p = Head;
            while (p.link.link != null)
            {
                p = p.link;
            }
            p.link = null;
        }

        public void RemoveAnyNode(int x)
        {
            if (Head == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }
            if (Head.info == x)
            {
                Head = Head.link;
                return;
            }

            Node p = Head;
            while (p.link != null)
            {
                if (p.link.info == x)
                    break;
                p = p.link;
            }
            if (p.link == null)
            {
                Console.WriteLine("Node not in list");
            }
            else
            {
                p.link = p.link;
            }
        }

        public void DeleteFirst()
        {
            if (Head == null)
                return; ;
            Head = Head.link;
        }

        public void AddBefore(int data, int x)
        {
            Node p = Head;
            while (p != null)
            {
                if (p.link.info == x)
                    break;
                p = p.link;
            }
            Node temp = new Node(data);
            temp.link = p.link;
            p.link = temp;
        }
        public void AtPosition(int data, int x)
        {
            Node p = Head;
            while (p != null)
            {
                if (p.info == x)
                    break;
                p = p.link;
            }

            if (p == null)
                Console.WriteLine("Node is Not Present");
            else
            {
                Node temp = new Node(data);
                temp.link = p.link;
                p.link = temp;
            }

        }
        public void begining(int data)
        {
            Node temp = new Node(data);
            temp.link = Head;
            Head = temp;
        }

        public void AddLast(int data)
        {
            Node p = Head;
            Node temp = new Node(data);
            if (Head == null)
            {
                Head = temp;
                return;
            }
            while (p.link != null)
            {
                p = p.link;
            }
            p.link = temp;
            Console.WriteLine("Node added in last: " + temp.info);
        }
        public void AddEmptyList(int data)
        {
            Node temp = new Node(data);
            Head = temp;
            Console.WriteLine("added item " + Head.info);
        }
    }


    public class Node
    {
        public int info;
        public Node link;
        public Node(int data)
        {
            this.info = data;
            link = null;
        }
    }
}