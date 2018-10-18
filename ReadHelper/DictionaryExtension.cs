using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadHelper
{
    public static class DictionaryExtension
    {
        public static string GetKey(this Dictionary<string, string> Langs, string Value)
        {
            return Langs.Where(item => item.Value.Equals(Value)).Select(item => item.Key).First().ToString();
        }
    }
}
