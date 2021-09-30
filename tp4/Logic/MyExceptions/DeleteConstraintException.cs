using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
<<<<<<< HEAD
    public class DeleteConstraintException : Exception
=======
    public class DeleteConstraintException: Exception
>>>>>>> 2ace80db213e0f0150c7642ba71835822d14d3fe
    {
        public override string Message => "This record cannot be deleted";
    }
}
