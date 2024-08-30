using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2_ClasseAffaire
{
    public class Livre
    {
        // Propriétés
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public string Editeur { get; set; }
        private int _nombreDePages;
        public int NombreDePages
        {
            get { return _nombreDePages; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Le nombre de pages doit être supérieur à 0.");
                }
                _nombreDePages = value;
            }
        }
        public int Annee { get; set; }
        // Constructeur
        public Livre(string titre, string auteur, string editeur, int
        nombreDePages, int annee)
        {
            Titre = titre;
            Auteur = auteur;
            Editeur = editeur;
            NombreDePages = nombreDePages; // Utilise le set, doncvérification automatique
            Annee = annee;
        }
        // Méthode ToString()
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Titre : {Titre}");
            sb.AppendLine($"Auteur : {Auteur}");
            sb.AppendLine($"Éditeur : {Editeur}");
            sb.AppendLine($"Nombre de pages : {NombreDePages}");
            sb.AppendLine($"Année : {Annee}");
            return sb.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Création d'un tableau de livres
            Livre[] livres = new Livre[5];
            try
            {
                // Initialisation des livres
                livres[0] = new Livre("Le Petit Prince", "Antoine de Saint - Exupéry", "Gallimard", 96, 1943);
                livres[1] = new Livre("1984", "George Orwell", "Secker & Warburg", 328, 1949);
                livres[2] = new Livre("L'Étranger", "Albert Camus", "Gallimard", 123, 1942);
                livres[3] = new Livre("Harry Potter à l'école des sorciers", "J.K.Rowling", "Bloomsbury", 223, 1997);
                livres[4] = new Livre("Don Quichotte", "Miguel de Cervantes", "Francisco de Robles", 1072, 1605);
                // Affichage des informations des livres
                foreach (var livre in livres)
                {
                    Console.WriteLine(livre.ToString());
                    Console.WriteLine();
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
