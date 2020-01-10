using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorExample.Lib
{
    class EMFetcher : DABase
    {
        public override void Load(string param, ref Dictionary<string, string> keyValuePairs)
        {
            keyValuePairs.Add(param, $"{param} ran and loaded from EMFetcher");
        }
    }
}
