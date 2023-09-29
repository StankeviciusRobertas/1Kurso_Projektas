namespace _1Kurso_Projektas
{
    public class Projektas
    {        
        static void Main(string[] args)
        {
            string choise = "";
            while (choise != "exit")
            { 
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Sveiki atvyke i protmusio zaidima!!");
            Console.WriteLine("Jog pradetumete privaloti prisiregistruoti.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();            
            
            //Kvieciam Login() metoda, ir grazinam su out, ir galime tada naudoti ji kitur kaip fullName rezultata
            Login(out string userName, out string userSurname);
                string fullName = userName + " " + userSurname;
                Console.WriteLine($"Prisijunges vartotojas: {fullName}");
            int totalScore = 0;
                // kvieciame Meniu, paduodami pilna varda ir total score
            Console.Clear();
            Meniu(fullName, ref totalScore, ref choise);                
            }            
        }
        
        public static void Result(ref int totalScore, string fullName)
        {
            Console.Clear();
            Console.WriteLine($"Zaidejas - {fullName}");
            Console.WriteLine($"Jusu galutinis rezultatas: {totalScore}");
            Console.WriteLine("Iveskit '1' grysti i meniu");
            string pasirinkimas = Console.ReadLine();
            if (pasirinkimas == "1")
            {
                return;
            }

        }
        public static void Questions(ref int totalScore)
        {
            Console.Clear();
            string answer = "";
            int score = 0;            
            totalScore = 0;
            
                Console.WriteLine("Pradedam: ");
                Console.WriteLine("Pirmas klausimas");
                Console.WriteLine("Kuriais metais krikštatėvis buvo išleistas pirmą kartą?");
                Console.WriteLine("a. 1972 "); // teisingas
                Console.WriteLine("b. 1980 ");
                Console.WriteLine("c. 1990 ");
                Console.WriteLine("d. 2001");
                answer = Console.ReadLine();

                switch (answer)
                {
                    case "a":
                    totalScore++;
                        Console.WriteLine("Atsakymas teisingas");
                        break;
                    default:
                        Console.WriteLine("atsakymas neteisngas");
                        break;
                }
                
                Console.WriteLine("Antras klausimas");
                Console.WriteLine("Kokia yra didžiausia molekulė, kuri yra žmogaus kūno dalis?");
                Console.WriteLine("a. molekule ");
                Console.WriteLine("b. kintamasis ");
                Console.WriteLine("c. 1 chromosoma "); // teisingas
                Console.WriteLine("d. neutrinas");
                answer = Console.ReadLine();

                switch (answer)
                {
                    case "c":
                    totalScore++;
                        Console.WriteLine("Atsakymas teisingas");
                        break;
                    default:
                        Console.WriteLine("atsakymas neteisngas");
                        break;
                }
                

                Console.WriteLine("Trecias klausimas");
                Console.WriteLine("Kiek širdžių turi aštuonkojis?");
                Console.WriteLine("a. dvi ");
                Console.WriteLine("b. trys ");// teisingas
                Console.WriteLine("c. astuonias ");
                Console.WriteLine("d. viena");
                answer = Console.ReadLine();

                switch (answer)
                {
                    case "b":
                    totalScore++;
                        Console.WriteLine("Atsakymas teisingas");
                        break;
                    default:
                        Console.WriteLine("atsakymas neteisngas");
                        break;
                }
                

                Console.WriteLine("Ketvirtas klausimas");
                Console.WriteLine("Kokia vidutinė Veneros paviršiaus temperatūra??");
                Console.WriteLine("a. 1000 ");
                Console.WriteLine("b. 640 ");
                Console.WriteLine("c. 150 ");
                Console.WriteLine("d. 460 "); // teisingas
                answer = Console.ReadLine();

                switch (answer)
                {
                    case "d":
                    totalScore++;
                        Console.WriteLine("Atsakymas teisingas 460 C");
                        break;
                    default:
                        Console.WriteLine("atsakymas neteisngas");
                        break;
                }
            Console.Clear();          
            
        }
        public static void Rules()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Sveikiname prisijungus prie 'Laimek drambli' protmūšio programos");
                Console.WriteLine("Šis protmūšis jums leidžia pasirinkti iš 1 klausimų kategorijų.");
                Console.WriteLine("Pasirinkus kategoriją pradėsite žaidimą ir turėsite pasirinkti iš 4 galimų variantų, kuris yra jūsų klausimui teisingas atsakymas.“");
                Console.WriteLine("Iveskit '1' grysti i meniu");
                string pasirinkimas = Console.ReadLine();
                if (pasirinkimas == "1")
                {
                    return;
                }
            }
        }
        public static void Meniu(string fullName, ref int totalScore, ref string choise)
        {            
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Sveiki, jus prisijungete kaip: {fullName}");
                Console.WriteLine($"Jusu rezultatas: {totalScore}");
                Console.WriteLine("==============================================");
                Console.WriteLine("Meniu: ");
                Console.WriteLine("1. Prisijungti is naujo, iveskite '1' ");
                Console.WriteLine("2. Zaidimo taisykles, iveskite '2' ");
                Console.WriteLine("3. Zaidimo rezultatai ir dalyviu perziura, iveskite '3' ");
                Console.WriteLine("4. Pradeti zaidima, iveskite 'start game' ");
                Console.WriteLine("5. Iseiti is zaidimo, iveskit 'exit' ");
                Console.WriteLine("==============================================");
                string pasirinkimas = Console.ReadLine();
                switch (pasirinkimas)
                {
                    case "1":
                        // Prisijungimas                                                 
                        Console.Clear();
                        return;                                             
                    case "2":
                        // Taisykles
                        Rules();
                        break;
                    case "start game":
                        Questions(ref totalScore);
                        break;
                    case "exit":
                        choise = "exit";
                        return;
                    case "3":
                        Result(ref totalScore, fullName);
                        break;
                    case "q":
                        return;
                }
            }


            }
        public static void Login(out string userName, out string userSurname)
        {
            //ivedamas vardas pavarde
            Console.WriteLine("Iveskite savo varda: ");
            userName = Console.ReadLine();
            Console.WriteLine("Iveskite savo pavarde: ");
            userSurname = Console.ReadLine();            
        }        
    }
}