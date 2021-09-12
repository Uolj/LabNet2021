using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CustomException:Exception
    {
        public CustomException(string message):base(message)
        {
        }

        public override string Message => $"Now this is my exception B¬| --> {base.Message}";
    }
}
