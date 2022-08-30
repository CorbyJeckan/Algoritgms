using System;

namespace Thread2447455
{
    internal class Program
    {
        private static void Main()
        {
            DoublyLinkedList<string> linkedList = new DoublyLinkedList<string>();
            // добавление элементов
            linkedList.Add("Bob");
            linkedList.Add("Bill");
            linkedList.Add("Tom");
            linkedList.AddFirst("Kate");

            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }

            linkedList.Remove("Bill");

            // перебор с последнего элементаs
            foreach (var t in linkedList.BackEnumerator())
            {
                Console.WriteLine(t);
            }

            Console.ReadKey();
        }
    }
}
