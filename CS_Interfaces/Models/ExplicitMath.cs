using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Interfaces.Models
{
    /// <summary>
    /// Explicit Implementation
    /// </summary>
    public class ExplicitMath : IMath, INewMath
    {
        int IMath.Add(int x, int y)
        {
            return x + y;
        }

        int INewMath.Add(int x, int y)
        {
            return (x * x) + 2 * x * y + (y * y);
        }

        int IMath.Multiply(int x, int y) 
        { 
            return x* y;
        }

        int INewMath.Multiply(int x, int y)
        {
            return (x * x) * 2 * x * y + (y * y);
        }
    }
}
