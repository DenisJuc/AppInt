using System;

namespace ex_supp
{
    class Program
    {
        public static void Main(String[] args)
        {
            Stack<Commande> commandes = new Stack<Commande>();

            for (int i = 0; i < 5; i++)
            {
                Commande com = new Commande(i+1, "Pizza", DateTime.Now);
                commandes.Push(com);
               
            }

            AnnulerDerniereCommande(commandes);



        }
        public static void AnnulerDerniereCommande(Stack<Commande> stack)
        {
            if (stack.Count > 0)
            {
                Commande commande = stack.Pop();
                Console.WriteLine(commande.toString());
            }
            else
            {
                Console.WriteLine("Pas de commandes");
            }
            Console.WriteLine("----- Etat des commandes -----");
            foreach (Commande com in stack)
            {
                Console.WriteLine(com.toString());
            }    
        }
    }
}
