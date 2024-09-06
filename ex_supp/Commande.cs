using System;
using System.Net.Http.Headers;
using System.Text;

namespace ex_supp
{
    class Commande
    {
        int Id { get; set; }
        string NomProduit { get; set; }
        DateTime DateCommande { get; set; }

        public Commande(int id, string nom, DateTime date)
        {
            Id = id;
            NomProduit = nom;
            DateCommande = date;
        }
        public string toString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Id : {Id}");
            sb.AppendLine($"Nom : {NomProduit}");
            sb.AppendLine($"Date : {DateCommande}");
            return sb.ToString();
        }

    }
}
