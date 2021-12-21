using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dummy._1
{
    class Mainn
    {
        [Obsolete("This will show an error")]
        static void PrintDummy()
        {
            Console.WriteLine("doesn't print");
        }
        static void Main() 
        {
            Console.WriteLine("which one will show?");
            //PrintDummy();
        }
    }
}
