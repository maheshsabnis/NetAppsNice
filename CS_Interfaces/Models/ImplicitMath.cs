using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Interfaces.Models
{
    /// <summary>
    /// Class implementing interface implicitly
    /// </summary>
    public class ImplicitMath : IMath
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
 
        public int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}
