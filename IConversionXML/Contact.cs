using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConversionXML
{
    internal class Contact : IConversionXML
    {
        public string Nom {  get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string Numero {  get; set; }
        public string Rue {  get; set; }
        public string Description { get; set; }

        public XmlElement VersXML(XmlElement doc)
        {
            
        }

        // from xml
        public void DeXML(XmlElement doc)
        {

        }
    }


}
