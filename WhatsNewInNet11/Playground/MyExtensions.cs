using System;
using System.Collections.Generic;
using System.Text;

// This is Extension indexers
// Index into types you don't own, like string, int, etc. and add your own indexers to them.

namespace Playground
{
    public static class MyExtensions
    {
        extension<T>(IEnumerable<T> s)
        {
            public int Count => s.Count();
            public T this[int index] => s.ElementAt(index);
        }
    }
}
