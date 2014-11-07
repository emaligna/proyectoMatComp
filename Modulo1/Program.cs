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
            string postfix = test.convertToPostfix("(bb)*a(bb)+c");
            Console.WriteLine(postfix);
        }
    }
}
