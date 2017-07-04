using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace CallC
{
    class Program
    {

        [DllImport("C:\\Projetos\\CppClassDll\\Debug\\CppClassDll.dll")]
        public static extern double sumTwo(double var_x, double var_y);

        static void Main(string[] args)
        {
            double var_x = 5;
            double var_y = 30;

            double result = sumTwo(var_x, var_y);
        }
    }
}
