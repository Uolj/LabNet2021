using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class CharacterLimitExceededException:Exception
    {
        public override string Message => "Maximum character limit exceeded in one or more fields";
    }
}
