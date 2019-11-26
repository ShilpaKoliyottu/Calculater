using System;
using System.Collections.Generic;
using System.Text;

namespace oops001
{
    interface IPen
    {
        string Price();

        int Out(int a);

        int Name { get; set; }
    }
    class Class1:IPen
    {

        public int Name { get; set; }
        public string  Price()
        {
            return "a";
        }
        public int a { get; set; }

        public Class1(int a)
        {
            this.a = a;
        }
        public Class1()
        {

        }
    }
    class Class2
    {
        Class1 Class1 = new Class1(23);

        Class1 a = new Class1();

        IPen pen = new Class1();
    }
}
