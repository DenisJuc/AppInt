using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Xml;

class Program
{
    public static void Main()
    {
        AjouterContact();
    }

    static void ChercherInfos()
    {
        string filepath = "C:\\Users\\2249463\\Desktop\\appint\\XML\\Exercice_2\\contacts.xml";

        XmlDocument doc = new XmlDocument();

        doc.Load(filepath);

        XmlNodeList nodes = doc.GetElementsByTagName("contact");

        int nb_contacts = nodes.Count;
        int nb_simpsons = 0;

        StringBuilder adresse_ned = new StringBuilder();
        StringBuilder desc_charles = new StringBuilder();

        foreach (XmlNode node in nodes)
        {
            XmlElement? element = node as XmlElement;

            if (element.GetAttribute("nom").Equals("Simpson"))
            {
                nb_simpsons++;
            }
            else if (element.GetAttribute("nom").Equals("Flanders"))
            {
                string nom = element.GetAttribute("nom");
                string prenom = element.GetAttribute("prenom");
                XmlElement? adresse = element["adresse"];
                string numero = adresse.GetAttribute("numero");
                string rue = adresse.GetAttribute("rue");

                adresse_ned.Append("L'adresse de ");
                adresse_ned.Append(nom);
                adresse_ned.Append(" ");
                adresse_ned.Append(prenom);
                adresse_ned.Append(" est ");
                adresse_ned.Append(numero);
                adresse_ned.Append(" ");
                adresse_ned.Append(rue);
                Console.WriteLine(adresse_ned.ToString());
            }
            else if (element.GetAttribute("nom").Equals("Montgomery Burns"))
            {
                string nom = element.GetAttribute("nom");
                string prenom = element.GetAttribute("prenom");
                string desc = element["description"].InnerText.Trim();

                desc_charles.Append(prenom);
                desc_charles.Append(" ");
                desc_charles.Append(nom);
                desc_charles.Append(": ");
                desc_charles.Append(desc);
                Console.WriteLine(desc_charles.ToString());
            }
        }
        Console.WriteLine($"Nombre de contacts: {nb_contacts}");
        Console.WriteLine($"Nombre de simpsons : {nb_simpsons}");
    }

    static void AjouterContact()
    {
        string filepath = "C:\\Users\\2249463\\Desktop\\appint\\XML\\Exercice_2\\contacts.xml";

        XmlDocument doc = new XmlDocument();
        doc.Load(filepath);


        XmlElement root = doc.DocumentElement;


        XmlElement contact = doc.CreateElement("contact");
        contact.SetAttribute("nom", "Van Houten");
        contact.SetAttribute("prenom", "Milhouse");


        XmlElement adresse = doc.CreateElement("adresse");
        adresse.SetAttribute("numero", "316");
        adresse.SetAttribute("rue", "Pikeland Ave.");
        contact.AppendChild(adresse);


        XmlElement desc = doc.CreateElement("description");
        desc.InnerText = "Milhouse est le meilleur ami de Bart Simpson et est désespérément amoureux de sa sœur Lisa Simpson.";
        contact.AppendChild(desc);

        root.AppendChild(contact);


        doc.Save(filepath);

        Console.WriteLine("Contact ajoute");
    }
}