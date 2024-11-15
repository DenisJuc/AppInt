namespace Model
{
    public class Joueur
    {
        public string Nom { get; set; }

        public Joueur(string nom)
        {
            Nom = nom;
        }

        public override string ToString() => Nom;
    }

}
