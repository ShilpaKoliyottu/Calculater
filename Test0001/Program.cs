using System;
using System.Collections.Generic;

namespace Test0001
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Item> list = new List<Item>();
            Item item1 = new Item();
            Item item2 = new Item();
            item1.count = 5;
            item2.count = 6;
            list.Add(item1);
            list.Add(item2);
            foreach (var item in list)
            {
                if (item.count == 5)
                {
                    item.count -= 1;
                }
            }
            foreach (var item in list)
            {
                Console.WriteLine(item.count);
            }
        }

    }
}
