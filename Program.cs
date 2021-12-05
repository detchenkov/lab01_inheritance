using System;

namespace lab01_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Base a = new Base();
            Base b = new A();

            Console.WriteLine(a.GetInfo());
            Console.WriteLine(b.GetInfo());
        }
    }

    class Base
    {
        public virtual string GetInfo()
        {
            return "Base class";
        }
    }
    class A : Base
    {
        public override string GetInfo()
        {
            return "A class";
        }
    }

}

