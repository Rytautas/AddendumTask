using System.Collections.Generic;
using System;
using AddendumTask.Classes;
using AddendumTask.Interfaces;

namespace AddendumTask
{
    class Program
    {
        static void Main(string[] args)
        {
            IReader reader = new XmlReader();
            List<Entry> entries = reader.Read("data.xml");

            ConsoleUserInterface ui = new ConsoleUserInterface();
            DateTime[] range = ui.init();

            List<Entry> entriesInRange = DateOperations.Intersection(entries, range[0], range[1]);
            List<Entry> sortedEntries = ValueOperations.SortByAscending(entriesInRange);
            double avgInRange = ValueOperations.FindAverage(entriesInRange);
            int maxInRange = ValueOperations.FindMax(entriesInRange);

            IWriter writer = new FileWriter();
            writer.AddToWrite("Entries in range " + range[0].ToString("yyyy/MM/dd") + " - " + range[1].ToString("yyyy/MM/dd") + ":");
            foreach (Entry entry in entriesInRange)
            {
                writer.AddToWrite("Date: " + entry.Date.ToString("yyyy/MM/dd") + "  Value: " + entry.Value);
            }

            writer.AddToWrite("Sorted by value in ascending order:");
            foreach (Entry entry in sortedEntries)
            {
                writer.AddToWrite("Date: " + entry.Date.ToString("yyyy/MM/dd") + "  Value: " + entry.Value);
            }

            writer.AddToWrite("Average value: " + avgInRange);
            writer.AddToWrite("Max value: " + maxInRange);

            writer.Write();
        }
    }
}
