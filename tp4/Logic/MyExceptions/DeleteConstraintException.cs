using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class DeleteConstraintException: Exception
    {
        public override string Message => "This record cannot be deleted";
    }
}
