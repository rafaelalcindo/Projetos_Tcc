using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using RGiesecke.DllExport;
using System.Runtime.InteropServices;

namespace LibraryCsharp
{
    public class Class1
    {
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        delegate int FuncaoAdicionar();

        
        [DllExport("addUp@8", CallingConvention = CallingConvention.StdCall)]
        static int addUp(int num1, int num2)
        {
            return num1 + num2;
        }

        [DllExport("minus@8", CallingConvention = CallingConvention.StdCall)]
        public static int minus(int num1, int num2)
        {
            return num1 - num2;
        }

        [DllExport("multiple@8", CallingConvention = CallingConvention.StdCall)]
        public static int multiple(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
