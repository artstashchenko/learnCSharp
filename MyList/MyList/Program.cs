using System;

namespace MyList
{
    class Program
    {
       static void Main(string[] args)
        {
            ListMethods myList = new ListMethods();

            myList.Add(1);
            myList.Add(0);
            myList.Add(2);
            myList.Add(7);
            myList.Add(3);
            myList.Add(7);

            myList.RemoveAt(3);

            Console.WriteLine("Item 0 is 1: {0}", myList.Get(0) == 1);
            Console.WriteLine("Item 0 is 0: {0}", myList.Get(1) == 0);
            Console.WriteLine("Item 0 is 2: {0}", myList.Get(2) == 2);
            Console.WriteLine("Item 0 is 3: {0}", myList.Get(3) == 3);
            Console.WriteLine("Item 0 is 7: {0}", myList.Get(4) == 7);
            Console.WriteLine("Item Count is 5: {0}", myList.Count() == 5);
        }
    }
}
