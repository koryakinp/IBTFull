using System;
using System.Collections.Generic;
using System.IO;
using System.Resources;

namespace IBTFull
{
    public static class Extensions
    {
        private static Random rng = new Random();

        public static MemoryStream GetMemoryStream(this ResourceManager resourceManager, String name)
        {
            object resource = resourceManager.GetObject(name);

            if (resource is byte[])
            {
                return new MemoryStream((byte[])resource);
            }
            else
            {
                throw new InvalidCastException("The specified resource is not a binary resource.");
            }
        }

        public static void Shuffle<T>(this List<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}