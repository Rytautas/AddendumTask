using System.Collections.Generic;
using AddendumTask.Classes;

namespace AddendumTask.Interfaces
{
    interface IReader
    {
        public List<Entry> Read(string fileName);
    }
}
