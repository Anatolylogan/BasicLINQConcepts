using System;
using System.Collections.Generic;
using System.Linq;
namespace BasicLINQConcepts
{
    public static class SortingRows
    {
        public static List<string> SortAlphabetically(List<string> words)
        {
            return words.OrderBy(word => word).ToList();
        }
    }
}