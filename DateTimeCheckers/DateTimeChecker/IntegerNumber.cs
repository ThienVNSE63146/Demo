using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeChecker
{
    class IntegerNumber
    {
        public  Boolean CheckInt(String number)
        {
            try
            {
                int a = int.Parse(number);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
