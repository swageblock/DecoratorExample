using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorExample.Lib
{
    public abstract class DABase
    {
        public abstract void Load(string param, ref Dictionary<string, string> keyValuePairs);
    }
}
