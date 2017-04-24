using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

// xsd.exe /c /l:cs EnhancedTitles.xsd /n:DoenaSoft.DVDProfiler.EnhancedTitles

namespace DoenaSoft.DVDProfiler.EnhancedTitles
{
    public sealed partial class EnhancedTitlesList
    {
        private static XmlSerializer s_XmlSerializer;

        [XmlIgnore]
        public static XmlSerializer XmlSerializer
        {
            get
            {
                if (s_XmlSerializer == null)
                {
                    s_XmlSerializer = new XmlSerializer(typeof(EnhancedTitlesList));
                }

                return (s_XmlSerializer);
            }
        }

        public static EnhancedTitlesList Deserialize(String fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                EnhancedTitlesList instance = (EnhancedTitlesList)(XmlSerializer.Deserialize(fs));

                return (instance);
            }
        }

        public static void Serialize(EnhancedTitlesList instance
            , String fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.Read))
            {
                using (XmlTextWriter xtw = new XmlTextWriter(fs, Encoding.UTF8))
                {
                    xtw.Formatting = Formatting.Indented;

                    XmlSerializer.Serialize(xtw, instance);
                }
            }
        }

        public void Serialize(String fileName)
        {
            Serialize(this, fileName);
        }
    }

    public sealed partial class EnhancedTitles
    {
        private static XmlSerializer s_XmlSerializer;

        [XmlIgnore]
        public static XmlSerializer XmlSerializer
        {
            get
            {
                if (s_XmlSerializer == null)
                {
                    s_XmlSerializer = new XmlSerializer(typeof(EnhancedTitles));
                }

                return (s_XmlSerializer);
            }
        }

        public static EnhancedTitles Deserialize(String fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                EnhancedTitles instance = (EnhancedTitles)(XmlSerializer.Deserialize(fs));

                return (instance);
            }
        }

        public static void Serialize(EnhancedTitles instance
            , String fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.Read))
            {
                using (XmlTextWriter xtw = new XmlTextWriter(fs, Encoding.UTF8))
                {
                    xtw.Formatting = Formatting.Indented;

                    XmlSerializer.Serialize(xtw, instance);
                }
            }
        }

        public void Serialize(String fileName)
        {
            Serialize(this, fileName);
        }
    }
}