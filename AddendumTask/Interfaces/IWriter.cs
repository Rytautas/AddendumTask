using System;
using System.Collections.Generic;
using System.Text;

namespace AddendumTask.Interfaces
{
    interface IWriter
    {
        public void AddToWrite(string text);
        public void Write();
    }
}
