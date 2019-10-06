using System;
using System.Collections.Generic;

namespace AddendumTask.Classes
{
    public class Entry
    {
        public DateTime Date { get; set; }
        public int Value { get; set; }
    }

    public class Root
    {
        public List<Entry> entry { get; set; }
    }

    public class RootObject
    {
        public Root root { get; set; }
    }
}
