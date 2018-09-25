using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringCounter
{
    class Search
    {
        public int WordCount(string LongString,string KeyWord)
        {
            
            int count = Regex.Matches(LongString, KeyWord, RegexOptions.IgnoreCase).Count;
            return count;         
        }


    }
}
