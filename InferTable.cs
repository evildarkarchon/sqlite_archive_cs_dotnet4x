using System;
using System.Collections.Generic;
using System.Text;

namespace sqlite_archive_cs
{
    class InferTable
    {
        public string Clean(ref string input)
        {
            string Out = input.Replace(".", "_").Replace(" ", "_").Replace(@"'", "_").Replace(",", "").Replace("/", "_").Replace(@"\", "_").Replace(",", "_").Replace("#", "");
            return Out;
        }
        public string Clean(ref string input, bool lowercase)
        {
            string Out = input.Replace(".", "_").Replace(" ", "_").Replace(@"'", "_").Replace(",", "").Replace("/", "_").Replace(@"\", "_").Replace(",", "_").Replace("#", "");
            if (lowercase)
            {
                return Out.ToLower();
            }
            else
            {
                return Out;
            }
        }
    }
}
