using System;

namespace POSTerminal
{
    public class Program
    {
        static void Main(string[] args)
        {
            Product kush = new Product("kush", 40, 30, "Indica");
            Console.WriteLine(kush);
        }
    }
}
