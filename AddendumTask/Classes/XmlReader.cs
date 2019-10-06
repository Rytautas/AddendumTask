using Newtonsoft.Json;
using System.IO;
using System.Xml;
using AddendumTask.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace AddendumTask.Classes
{
    class XmlReader : IReader
    {
        public List<Entry> Read(string fileName)
        {
            string xml;
            XmlDocument doc = new XmlDocument();

            using (StreamReader reader = new StreamReader(fileName))
            {
                xml = reader.ReadToEnd();
                doc.LoadXml(xml);
            }

            string json = JsonConvert.SerializeXmlNode(doc);

            List<Entry> entries = JsonConvert.DeserializeObject<RootObject>(json).root.entry;
            return entries.OrderBy(e => e.Date).ToList();
        }
    }
}
