using AddendumTask.Interfaces;
using System.Collections.Generic;
using System.IO;

namespace AddendumTask.Classes
{
    class FileWriter : IWriter
    {
        public List<string> _output = new List<string>();

        public void AddToWrite(string text)
        {
            _output.Add(text);
        }

        public void Write()
        {
            using(StreamWriter wr = new StreamWriter("result.txt"))
            {
                foreach(string line in _output)
                {
                    wr.WriteLine(line);
                }
            }
        }
    }
}
