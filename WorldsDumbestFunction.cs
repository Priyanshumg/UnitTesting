using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    internal class WorldsDumbestFunction
    {
        public string CheckNumber(int num)
        {
            if (num == 0)
            {
                return "Result is 0".ToLower();
            }
            else
            {
                return "Result is not 0".ToLower();
            }
        }
    }
}
