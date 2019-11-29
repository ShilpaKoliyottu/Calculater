using System;
using System.Collections.Generic;

namespace Febinocci
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);

            for (int i = 0; i < 10; i++)
            {
                numList.Add(numList[i] + numList[i + 1]);

                Console.WriteLine(numList[i]);
            }
            Febinocci(10);

        }



        public static void Febinocci(int i)
        {
            List<int> numList = new List<int>();
            numList.Add(numList[i] + numList[i - 1]);
            Console.WriteLine(numList[i]);
            i = i - 1;
            if (i != 0) 
            {
                Febinocci(i - 1);
            }
            
        }
    }
}
