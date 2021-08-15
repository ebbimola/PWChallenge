using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWChallenge.CustomException
{
    public class DriverNotFound :Exception
    {
        public DriverNotFound(string msg) : base(msg)
        {
            
        }
    }
}
