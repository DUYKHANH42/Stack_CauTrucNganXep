using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack(32);
            Console.WriteLine("Cho biet so nguyen N (he 10): ");
            int n = int.Parse(Console.ReadLine());
            int so = n;
            while(n>0)
            {
                stack.Push(n % 2);
                n = n / 2;
            }
            string kq = "";
            while (!stack.IsEmpty())
            {
               kq+= stack.Pop();
            }

            Console.WriteLine($"So nguyen {so} (he 10) la: {kq} (he 2) ") ;
            Console.ReadLine();
        }
    }
}
