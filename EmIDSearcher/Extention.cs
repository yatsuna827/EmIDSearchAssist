using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace EmIDSearcher
{
    static class Extention
    {
        public static string RegaxReplace(this string arg1, string pattern, string replacement)
        {
            return Regex.Replace(arg1, pattern, replacement);
        }

    }
}
