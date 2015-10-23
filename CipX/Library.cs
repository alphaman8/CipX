using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace CipX
{
    class Library
    {

        public static string appDir =
            System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetModules()[0].FullyQualifiedName);

        public static string removeCrase(string txt)
        {
            txt = txt.Replace("\'", "");
            return txt;
        }

        public static bool IsNullOrEmpty(string s)
        {
            if (s == null || s.Trim().Length == 0)
            {
                return true;
            }
            return false;
        }
    }
}
