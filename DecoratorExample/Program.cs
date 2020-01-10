using DecoratorExample.Lib;
using System;
using System.Collections.Generic;

namespace DecoratorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loading from only Base");

            LoadBase();

            Console.WriteLine("Loading with decorators");

            LoadWithDecorators();

            Console.ReadLine();
        }

        private static void LoadWithDecorators()
        {
            DABase decd;
            EMFetcher concrete = new EMFetcher();
            DBDecorator dbdec = new DBDecorator();
            dbdec.SetComponent(concrete);
            CacheDecorator cachedec = new CacheDecorator();
            cachedec.SetComponent(dbdec);
            MemCacheDecorator memdec = new MemCacheDecorator();
            memdec.SetComponent(cachedec);

            decd = memdec;

            var results = new Dictionary<string, string>();

            decd.Load("loan", ref results);
            foreach (var a in results)
            {
                Console.WriteLine(a.Value);
            }
        }

        private static void LoadBase()
        {
            DABase concrete = new EMFetcher();
            var results = new Dictionary<string, string>();
            concrete.Load("loan", ref results);
            foreach (var a in results)
            {
                Console.WriteLine(a.Value);
            }
        }
    }
}
