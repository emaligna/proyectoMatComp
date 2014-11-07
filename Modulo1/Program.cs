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
            infixToPostfix test = new infixToPostfix();
            Console.WriteLine(test.convertToPostfix("(a+b)*"));
        }
    }
}
