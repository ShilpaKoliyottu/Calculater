using Add;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculater
{
    public class Multiplication : Addition
    {
        public void Multiply(decimal operater1, decimal operater2)
        {
            decimal result = operater1 * operater2;
            Console.WriteLine("result:{0}", result);

            var div = new Division();
            
        }
    }
}
