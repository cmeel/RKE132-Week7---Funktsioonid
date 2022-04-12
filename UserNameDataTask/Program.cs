using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnimi
            //programm küsib kasutajal sisestada numbrit 1-3
            //kui kasutaja sisestab 1, siis kuvatakse kasutaja eesnimi tagurpidi
            //kui kasutaja valib 2, siis kuvatakse kasutaja eesnime esimene täht
            //kui kasutaja valib 3, siis kuvatakse kasutaja eesnime pikkust

            Console.WriteLine("Sisesta oma eesnimi:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta number 1-3:");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            if (userNumber == 1)
            {
                NameLength(userName);
            }
            else if (userNumber == 2)
            {
                FirstLetter(userName);
            }
            else if (userNumber == 3)
            {
                BackwardName(userName);
            }
            else
            {
                Console.WriteLine("Kena päeva!");
            }
        }

        public static void NameLength(string userInput)
        {
            Console.WriteLine($"Sinu nimi on {userInput.Length} sümbolit pikk.");
        }

        public static void FirstLetter(string userInput)
        {
            Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}.");
        }

        public static void BackwardName(string userInput)
        {
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }
        }
    }
}
