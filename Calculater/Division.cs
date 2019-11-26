using Add;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculater
{
    class Division : Addition
    {
        public void Divide(decimal operater1, decimal operater2)
        {
            decimal result = operater1 / operater2;
            Console.WriteLine("result:{0}", result);
        }

        public void print()
        {
            Add(2.5m, 10.5m);
        }
    }
}
