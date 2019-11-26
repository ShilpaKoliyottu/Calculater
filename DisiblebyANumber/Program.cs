using Add;
using System;
using System.Collections.Generic;

namespace DisiblebyANumber
{
    class Program: Addition
    {
        static void Main(string[] args)
        {
            //string result=null;
            List<int> NumberList = new List<int>();
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    NumberList.Add(i);
                    //result +=i+",";
                }
            }
            //Console.WriteLine(result.TrimEnd(','));

            Console.WriteLine(string.Join(',', NumberList)); 

        }
    }
}
