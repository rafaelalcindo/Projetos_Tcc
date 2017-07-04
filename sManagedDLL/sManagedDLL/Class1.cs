using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sManagedDLL
{
    public interface ICalculator
    {
        int Add(int Number1, int Number2);
    };

    public class ManagedClass:ICalculator
    {        
        public int Add(int Number1, int Number2)
        {
            return Number1 + Number2;       
        }
    }
}
