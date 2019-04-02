using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp2
{
    public class Validation
    {
        bool status = false;

        public bool validation(int result)
        {
            if (result > 0)
            {
                status = true;
                Console.Write("Success");
            }
            else
            {
                Console.Write("Failed");
            }
            return status;
        }
    }
}
