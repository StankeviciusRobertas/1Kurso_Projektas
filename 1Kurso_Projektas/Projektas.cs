namespace _1Kurso_Projektas
{
    public class Projektas
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Sveiki atvyke i protmusio zaidima!!");
            Console.WriteLine("Jog pradetumete privaloti prisiregistruoti.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            string choise = "";
            
            // Prisijungimas 
            Console.WriteLine("Prisijungimo langas");
            Console.WriteLine("Iveskit savo varda: ");
            Dictionary<string, string> users = new Dictionary<string, string>();
            string userName = Console.ReadLine();
            Console.WriteLine("Iveskit savo pavarde: ");
            string userSurname = Console.ReadLine();

            string currentUser = userName + " " + userSurname;

            if (!users.ContainsKey(currentUser))
                {
                users.Add(currentUser, currentUser);
                Console.WriteLine("Sveikiname, Naujas varotojas uzregistruotas");
                }
            else
            {
                Console.WriteLine("Toks vartotojas jau yra, teskite zaidima su juo");
            }


            Console.Clear();
            Console.WriteLine($"Prisijunges: {currentUser}");
            
            // Meniu elementai
            Meniu();

            
            




        }

        public static void Meniu()
        {
            Console.WriteLine();
            Console.WriteLine("Meniu pasirinkimas: ");
            Console.WriteLine("1. Grysti i prisijungimo langa iveskite 'q' ");
            Console.WriteLine("2. Zaidimo taisykles, iveskite '2' ");
            Console.WriteLine("3. Zaidimo rezultatai ir dalyviu perziura, iveskite 'rezultatai' ");
            Console.WriteLine("4. Pradeti zaidima, iveskite 'start game' ");
            Console.WriteLine("5. Iseiti is zaidimo, iveskit 'exit' ");
        }
        public static Dictionary<string, string> Login(Dictionary<string, string> name, Dictionary<string, string> surname)
        {            
            Dictionary<string, string> nameSurname = new Dictionary<string, string>();
            return nameSurname;
        }
    }
}