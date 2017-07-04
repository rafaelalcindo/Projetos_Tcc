using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ImportDlls
{
    class Program
    {
        int num = 4, num2 = 5;
        [DllImport("TestLib.dll")]
        
        public static extern void DisplayHelloFromDLL();

        static void Main(string[] args)
        {
            int num = 4, num2 = 5;
            Console.WriteLine("This is C# program");
            DisplayHelloFromDLL();
            Console.ReadKey();
        }
    }
}
