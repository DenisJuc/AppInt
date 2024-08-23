using System;

namespace Exercice_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Livre[] livres = new Livre[3];

            livres[0] = new Livre("Calculus 1", "John Stewart", "BIO", 492, 2023);
            livres[1] = new Livre("How to Aim", "TenZ", "VALO", 102, 2022);
            livres[2] = new Livre("Introduction to Programming", "Aymen Khlif", "BDEB", 2, 2019);
            // livres[3] = new Livre("Calculus 1", "John Stewart", "BIO", 492, 2023);
            // livres[4] = new Livre("Calculus 1", "John Stewart", "BIO", 492, 2023);

            foreach(var livre in livres)
            {
                Console.WriteLine(livre.ToString());
            }
        }
    }
}