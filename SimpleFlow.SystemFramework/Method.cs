using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFlow.SystemFramework
{
    public class Method
    {
        public static bool IsNullOrTrimedEmpty(string s)
        {
            if (s == null)
            {
                return true;
            }
            if (s == string.Empty)
            {
                return true;
            }
            return s.Trim().Length == 0;
        }

    }
}
