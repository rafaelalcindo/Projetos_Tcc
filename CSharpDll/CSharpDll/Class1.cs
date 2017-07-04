using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Windows;
using System.IO;

namespace CSharpDll
{
    public static class ManagedClass
    {
        public static void ShowValue(ref int value)
        {
            value = 3;
            return;
        }
    }
}
