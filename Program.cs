using System;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList obj = new SingleLinkedList();
            obj.AddEmptyList(30);
            obj.AddLast(30);
            obj.AddLast(60);
            obj.AddLast(70);
            obj.begining(10);
            int X;
            Console.WriteLine("Ënter the position");
            X = int.Parse(Console.ReadLine());
            obj.AtPosition(90, 20);
            obj.AddBefore(80, 90);
            obj.DeleteFirst();
            obj.Display();
        }
    }
}
