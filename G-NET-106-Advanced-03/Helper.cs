
using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_106_Advanced_03
{
    internal class Helper
    {
        public static void PrintCollection<t> (string title , IEnumerable<t> collection){

            Console.WriteLine(title);
            Console.WriteLine(string.Join(", " , collection));
        
        }
    }
}
