using System.Diagnostics;
using System.Text;

namespace ExerciseModule2
{
    class Program()
    {
        const uint NOMBRE_ITERATIONS = 100000; // Le nombre d'itérations
        public static void Main(string[] args)
        {
            TestInsertionsFin();
        }
        public static void TestInsertionsFin()
        {
            const uint nb_insertions = 125000;

            Stopwatch sw = new Stopwatch();
            List<int> list = new List<int>();
            LinkedList<int> linkedlist = new LinkedList<int>();

            sw.Start();
            // Insertions par la fin
            for (int i = 0; i < nb_insertions; i++)
            {
                list.Add(i);
            }
            sw.Stop();
            Console.Write($"Nombre de millisecondes pour remplir List<> par la fin: {sw.ElapsedMilliseconds}");
            Console.WriteLine("\n");
            sw.Restart();
            for (int i = 0; i < nb_insertions; i++)
            {
                linkedlist.AddLast(i);
            }
            Console.WriteLine($"Nombre de millisecondes pour remplir LinkedList<> par la fin : {sw.ElapsedMilliseconds}");



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
    }
}