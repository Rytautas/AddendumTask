using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AddendumTask.Classes
{
    public class ValueOperations
    {
        public static double FindAverage(List<Entry> entries)
        {
            return entries.Average(e => e.Value);
        }

        public static int FindMax(List<Entry> entries)
        {
            return entries.Max(e => e.Value);
        }

        public static List<Entry> SortByAscending(List<Entry> entries)
        {
            return entries.OrderBy(e => e.Value).ToList();
        }

        public static List<Entry> SortByDescending(List<Entry> entries)
        {
            return entries.OrderByDescending(e => e.Value).ToList();
        }
    }
}
