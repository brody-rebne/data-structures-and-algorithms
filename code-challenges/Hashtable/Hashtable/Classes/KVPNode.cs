using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtable.Classes
{
    public class KVP
    {
        public string Key { get; set; }
        public string Value { get; set; }

        public KVP(string key, string value)
        {
            Key = key;
            Value = value;
        }
    }
}
