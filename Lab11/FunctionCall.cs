using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionCall
{
    //1. Define a delegated
    public delegate void myDelegate(string x);

    class Program
    {
        //non-static
        public void SayHello(string name)
        {
            Console.WriteLine("Hello " + name + "!");
        }

        //static
        public static void GoodBye (string name )
        {
            Console.WriteLine("GoodBye " + name + "!");
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            //2. Create an instance
            myDelegate hello = new myDelegate(p.SayHello);

            
            p.SayHello("Mubashir");

            Program.GoodBye("Mubashir");

           //3. Call the delegate with parameters
            //hello.Invoke("I am a Delegate");
            hello("I am a delegate");

            Console.ReadLine();
        }
    }
}
