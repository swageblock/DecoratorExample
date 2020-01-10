﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorExample.Lib
{
    class MemCacheDecorator : DABase
    {

        protected DABase _fetcher;
        public void SetComponent(DABase fetcher)
        {
            _fetcher = fetcher;
        }
        public override void Load(string param, ref Dictionary<string, string> keyValuePairs)
        {
            keyValuePairs.Add(this.ToString(), $"{param} ran and loaded from MemDecorator");
            if (_fetcher != null) _fetcher.Load(param, ref keyValuePairs);
        }


    }
}
