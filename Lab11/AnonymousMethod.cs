using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAnonymousMethod
{
    class Program
    {
        public delegate string HelloDelegate (string name);

        static void Main(string[] args)
        {
            HelloDelegate obj = delegate(string val)
            {
                return "Hello " + val + "!";
            };

            string str = obj.Invoke("Mubashir");
            Console.WriteLine(str);

            Console.ReadLine();

        }
    }
}
