using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Logic
    {
        public static void ThrowException()
        {
            throw new Exception() ;
        }
        public static void ThrowCustomException(string message)
        {
            throw new CustomException(message);
        }
    }
}
