using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo1
{
    class Program
    {

        public static void Main(string[] args) {
            Mod1 test = new Mod1();
            string postfix = test.convertToPostfix("((tu,ami)*(@,les)+)*,(enteró)*((b,c,d),.)");
            Console.WriteLine(postfix);
        }
    }
}
