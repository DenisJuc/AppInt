using System.Xml;

namespace ConversionXML
{
    public interface IConversionXML
    {
        // to xml
        public XmlElement VersXML(XmlElement doc);

        // from xml
        public void DeXML(XmlElement doc);
    }
}
