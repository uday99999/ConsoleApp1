using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            b n = new b();
            n.n();
            PersonClass p = new PersonClass();
            p.getName("h");
        }

        class b : MmClass
        {
            public override void n()
            {
                Console.WriteLine("");
            }
        }
    }
}
