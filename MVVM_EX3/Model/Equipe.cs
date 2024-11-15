using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Model
{
    public class Equipe
    {
        public string Nom { get; set; }
        public ObservableCollection<Joueur> Joueurs { get; set; }

        public Equipe(string nom)
        {
            Nom = nom;
            Joueurs = new ObservableCollection<Joueur>();
        }

        public override string ToString() => Nom;

        public static ObservableCollection<Equipe> ChargerEquipesDepuisXML()
        {

            var equipes = new ObservableCollection<Equipe>();

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("equipes.xml");

            XmlNodeList equipeNodes = xmlDoc.SelectNodes("/Ligue/Equipes/Equipe");
            if (equipeNodes != null)
            {
                foreach (XmlNode equipeNode in equipeNodes)
                {
                    if (equipeNode.Attributes?["nom"] != null)
                    {
                        string nomEquipe = equipeNode.Attributes["nom"].Value;
                        Equipe equipe = new Equipe(nomEquipe);

                        XmlNodeList joueurNodes = equipeNode.SelectNodes("Joueur");
                        if (joueurNodes != null)
                        {
                            foreach (XmlNode joueurNode in joueurNodes)
                            {
                                equipe.Joueurs.Add(new Joueur(joueurNode.InnerText));
                            }
                        }
                        equipes.Add(equipe);
                    }
                }
            }
            return equipes;
        }

        public static void SauvegarderEquipes(ObservableCollection<Equipe> Equipes)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlElement root = xmlDoc.CreateElement("Ligue");
            XmlElement equipesElement = xmlDoc.CreateElement("Equipes");
            root.AppendChild(equipesElement);

            foreach (Equipe equipe in Equipes)
            {
                XmlElement equipeElement = xmlDoc.CreateElement("Equipe");
                equipeElement.SetAttribute("nom", equipe.Nom);

                foreach (Joueur joueur in equipe.Joueurs)
                {
                    XmlElement joueurElement = xmlDoc.CreateElement("Joueur");
                    joueurElement.InnerText = joueur.Nom;
                    equipeElement.AppendChild(joueurElement);
                }

                equipesElement.AppendChild(equipeElement);
            }

            xmlDoc.AppendChild(root);
            xmlDoc.Save("equipes.xml");
        }
    }

}
