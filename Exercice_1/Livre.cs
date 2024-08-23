using System.Text;

namespace Exercice_1
{
    internal class Livre
    {
        private int _pages;
        public string Titre { get; }
        public string Auteur { get; }
        public string Editeur { get; }
        public int Pages
        {
            get
            {
                return _pages;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Nombre de pages doit etre plus grand que 0");
                }
                _pages = value;
            }
        }
        private int Annee { get; }

        public Livre(string titre, string auteur, string editeur, int nb_pages, int anee)
        {

            Titre = titre;
            Auteur = auteur;
            Editeur = editeur;
            Pages = nb_pages;
            Annee = anee;
        }

        public override string ToString()
        {   
            StringBuilder sb = new StringBuilder();
            sb.Append($"Titre: {Titre}").Append(" ");
            sb.Append($"Auteur: {Auteur}").Append(" ");
            sb.Append($"Editeur: {Editeur}").Append(" ");
            sb.Append($"Pages: {Pages}").Append(" ");
            sb.Append($"Annee: {Annee}");
            return sb.ToString();
        }
    }
}
