using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public static class DivisionExtensions
    {
        public static int DivideByZero(this int dividend)
        {
            return dividend.Divide(0);
        }
        public static int Divide(this int dividend, int divisor)
        {
            return dividend / divisor;
        }
    }
}
