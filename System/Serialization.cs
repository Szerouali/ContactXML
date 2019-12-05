using System.Xml.Serialization;

namespace System
{
    internal class Serialization
    {
        internal class XmlSerializer : Xml.Serialization.XmlSerializer
        {
            public XmlSerializer(Type type) : base(type)
            {
            }
        }
    }
}