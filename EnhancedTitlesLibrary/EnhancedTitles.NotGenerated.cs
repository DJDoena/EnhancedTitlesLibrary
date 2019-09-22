using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

// xsd.exe /c /l:cs /f /n:DoenaSoft.DVDProfiler.EnhancedTitles EnhancedTitles.xsd

namespace DoenaSoft.DVDProfiler.EnhancedTitles
{
    public sealed partial class EnhancedTitlesList
    {
        private static XmlSerializer _xmlSerializer;

        [XmlIgnore]
        public static XmlSerializer XmlSerializer
        {
            get
            {
                if (_xmlSerializer == null)
                {
                    _xmlSerializer = new XmlSerializer(typeof(EnhancedTitlesList));
                }

                return _xmlSerializer;
            }
        }

        public static EnhancedTitlesList Deserialize(string fileName)
        {
            using (var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                var instance = (EnhancedTitlesList)(XmlSerializer.Deserialize(fs));

                return instance;
            }
        }

        public static void Serialize(EnhancedTitlesList instance, string fileName)
        {
            using (var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.Read))
            {
                using (var xtw = new XmlTextWriter(fs, Encoding.UTF8))
                {
                    xtw.Formatting = Formatting.Indented;
                    xtw.Namespaces = false;

                    var ns = new XmlSerializerNamespaces();
                    ns.Add(string.Empty, string.Empty);

                    XmlSerializer.Serialize(xtw, instance, ns);
                }
            }
        }

        public void Serialize(string fileName)
        {
            Serialize(this, fileName);
        }
    }

    public sealed partial class EnhancedTitles
    {
        private static XmlSerializer _xmlSerializer;

        [XmlIgnore]
        public static XmlSerializer XmlSerializer
        {
            get
            {
                if (_xmlSerializer == null)
                {
                    _xmlSerializer = new XmlSerializer(typeof(EnhancedTitles));
                }

                return _xmlSerializer;
            }
        }

        public static EnhancedTitles Deserialize(string fileName)
        {
            using (var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                var instance = (EnhancedTitles)(XmlSerializer.Deserialize(fs));

                return instance;
            }
        }

        public static void Serialize(EnhancedTitles instance
            , string fileName)
        {
            using (var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.Read))
            {
                using (var xtw = new XmlTextWriter(fs, Encoding.UTF8))
                {
                    xtw.Formatting = Formatting.Indented;
                    xtw.Namespaces = false;

                    var ns = new XmlSerializerNamespaces();
                    ns.Add(string.Empty, string.Empty);

                    XmlSerializer.Serialize(xtw, instance, ns);
                }
            }
        }

        public void Serialize(string fileName)
        {
            Serialize(this, fileName);
        }
    }
}