using System;
using System.Collections.Generic;
using System.Linq;

namespace AddendumTask.Classes
{
    public class DateOperations
    {
        public static List<Entry> FindByDate(List<Entry> entries, DateTime date)
        {
            return entries.Where(e => e.Date == date).ToList();
        }

        public static List<Entry> Intersection(List<Entry> entries, DateTime lowerBound, DateTime upperBound)
        {
            return entries.Where(e => e.Date <= upperBound && e.Date >= lowerBound).ToList();
        }
    }
}
