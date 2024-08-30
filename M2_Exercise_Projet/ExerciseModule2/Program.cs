using System.Diagnostics;
using System.Text;
using M2_ClasseAffaire;

namespace ExerciseModule2
{
    class Program()
    {
        static GenerateurLivre generaterLivre = new GenerateurLivre();
        const uint NOMBRE_ITERATIONS = 500000; // Le nombre d'itérations
        public static void Main(string[] args)
        {
            TestInsertionsFin();
            Console.WriteLine("-------------------------");
            TestInsertionsDebut();
            Console.WriteLine("-------------------------");
            Recherchelivre();
        }
        public static void TestInsertionsFin()
        {

            
            Stopwatch sw = new Stopwatch();


            sw.Start();
            List<int> list = new List<int>();
            // Insertions par la fin
            for (int i = 0; i < NOMBRE_ITERATIONS; i++)
            {
                list.Add(i);
            }
            sw.Stop();

            Console.Write($"Nombre de millisecondes pour remplir List<> par la fin: {sw.ElapsedMilliseconds}");
            Console.WriteLine("\n");
            sw.Restart();
            LinkedList<int> linkedlist = new LinkedList<int>();
            for (int i = 0; i < NOMBRE_ITERATIONS; i++)
            {
                linkedlist.AddLast(i);
            }
            sw.Stop();
            Console.WriteLine($"Nombre de millisecondes pour remplir LinkedList<> par la fin : {sw.ElapsedMilliseconds}");
        }
        public static void TestInsertionsDebut()
        {
            // Insertions au debut
            Stopwatch sw = new Stopwatch();
            sw.Start();
            List<int> list = new List<int>();
            for (int i = 0; i < NOMBRE_ITERATIONS; i++)
            {
                list.Insert(0, i);
            }
            sw.Stop();
            Console.WriteLine($"Nombre de milliseconds pour remplir List<> par le debut : {sw.ElapsedMilliseconds}");

            sw.Restart();
            LinkedList<int> linkedlist = new LinkedList<int>();
            for (int i = 0; i  <= NOMBRE_ITERATIONS; i++)
            {
                linkedlist.AddFirst(i);
            }
            sw.Stop();
            Console.WriteLine($"Nombre de millisecondes pour remplir LinkedList par le debut : {sw.ElapsedMilliseconds}");
        }
        public static void TestStringBuilder()
        {
            Stopwatch sw = new Stopwatch(); // Pour évaluer le temps des opérations
                                            // On va concaténer les nombres de 0 à NOMBRE ITERATIONS-1 dans une
                                            // chaîne de caractères
            sw.Start();
            string premiereChaine = "";
            for (int i = 0; i < NOMBRE_ITERATIONS; i++)
            {
                premiereChaine = premiereChaine + i + ' ';
            }
            sw.Stop();
            Console.WriteLine($"La concatenation a pris {sw.ElapsedMilliseconds} millisecondes");
            // On fait la même chose mais cette fois avec un StringBuilder
            sw.Restart();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < NOMBRE_ITERATIONS; i++)
            {
                sb.Append(i);
                sb.Append(' ');
            }
            string deuxiemeChaine = sb.ToString();
            sw.Stop();
            Console.WriteLine($"L'utilisation de StringBuilder a pris {sw.ElapsedMilliseconds} millisecondes");
        }
        void BrasserTableau(int[] tableau)
        {
            Random rng = new Random(); for (int i = 0; i < tableau.Length; i++)
            {
                int candidat = rng.Next(0, tableau.Length);
                int temp = tableau[candidat];
                tableau[candidat] = tableau[i];
                tableau[i] = temp;
            }
        }
        public static void Recherchelivre()
        {
            Stopwatch sw = new Stopwatch();
            
            sw.Start();
            SortedSet<Livre> livres = new SortedSet<Livre>();
            for (int i = 0; i < 40000; i++)
            {
                livres.Add(generaterLivre.CreerNouveauLivre());
            }
            sw.Stop();
            Console.WriteLine($"Ajout des livres dans un SortedSet : {sw.ElapsedMilliseconds}");
        }

    }
}