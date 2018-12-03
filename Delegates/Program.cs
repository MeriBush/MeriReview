using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void HelloMethodDelegate(string delMessage);

    public class Program
    {
        public static void Main(string[] args)
        {
            //DelegateRepository delegateRepo = new DelegateRepository();  Why won't it acknowledge my repo???? WHY?!?!?!?!?!


            HelloMethodDelegate del = new HelloMethodDelegate(HelloMethod);
            del("Hello from HelloMethod via HelloMethodDelegate");

            Console.ReadLine();
        }

        public static void HelloMethod(string methodMessage)
        {
            Console.WriteLine(methodMessage);
        }
    }
}
