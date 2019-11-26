using System;
using System.Collections.Generic;
using System.Text;

namespace Add
{

    public class Addition
    {
        private const int yourage = 10;

        //public int Age
        //{
        //    get => yourage;
        //    //private set;
        //}

        
        public void Add(decimal operater1, decimal operater2)
            {
                decimal result = operater1 + operater2;
                Console.WriteLine("result:{0}", result);
            }
        }
    
}
