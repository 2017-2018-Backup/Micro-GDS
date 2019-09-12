using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace BatchPlotting
{
    [Serializable]
    public class BatchPlottingPublish
    {
        public BatchPlottingPublish()
        {

        }

        [XmlElement]
        public List<Drawing> Drawing { get; set; }

    }

    [Serializable]
    public class Drawing
    {
        public Drawing() { }

        [XmlElement]
        public string Name { get; set; }

        [XmlElement]
        public string Path { get; set; }

        [XmlElement]
        public bool isLeft { get; set; }
    }

    public static class Extension
    {
        public static string ToXMLString(this BatchPlottingPublish obj)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(BatchPlottingPublish));
            StringBuilder sb = new StringBuilder();
            using (XmlWriter xmlWriter = XmlWriter.Create(sb, new XmlWriterSettings() { Indent = true }))
            {
                xmlSerializer.Serialize(xmlWriter, obj);
            }
            return sb.ToString();
        }

        public static BatchPlottingPublish Create(string path)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(BatchPlottingPublish));
            TextReader reader = new StreamReader(path);
            object obj = deserializer.Deserialize(reader);
            reader.Close();
            return (BatchPlottingPublish)obj;
        }
    }
}
