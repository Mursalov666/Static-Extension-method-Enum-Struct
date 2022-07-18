using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public static class Extention
    {
        public static bool CheckNotRoboteCode(this string notRoboteCode)
        {
            if(notRoboteCode.Length == 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
