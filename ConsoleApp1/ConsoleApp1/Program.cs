using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class A
    {
        public virtual void print()
        {
            Console.Write("A");
        }
    }
    public class B : A
    {
        public override void print()
        {
            Console.Write("B");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A obj = new A();
            obj.print();
            Console.ReadKey();
        }
    }
}
