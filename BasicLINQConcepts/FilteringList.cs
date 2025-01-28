using System;
using System.Collections.Generic;
using System.Linq;
namespace BasicLINQConcepts
{
    public static class FiltringList
    {
        public static List<int> FilterGreaterThan(List<int> numbers, int threshold)
        {
            return numbers.Where(n => n > threshold).ToList();
        }
    }
}
