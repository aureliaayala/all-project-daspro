using System;

namespace daspro
{
    class program
    {
        static void Main(string[] args)
        {
            int daduPlayer;
            int daduComputer;
            int poinPlayer = 0;
            int poinComputer = 0;
            int ronde = 1;

            Random rng = new Random();

            Console.WriteLine("ADU DADU");
            Console.WriteLine("Mulai main...");
            Console.ReadLine();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ronde "+ronde++);

                daduComputer = rng.Next(1,7);
                Console.WriteLine("Nilai komputer: "+daduComputer);
                Console.WriteLine("Lempar dadu anda...");
                Console.ReadKey();

                daduPlayer = rng.Next(1,7);
                Console.WriteLine("Nilai anda: "+daduPlayer);

                if(daduPlayer > daduComputer)
                {
                    poinPlayer++;
                    Console.WriteLine("Player memenangkan ronde ini!");
                }
                else if(daduPlayer < daduComputer)
                {
                    poinComputer++;
                    Console.WriteLine("Computer memenangkan ronde ini!");
                }
                else
                {
                    Console.WriteLine("Ronde ini seri!");
                }

                Console.WriteLine("Skor - Anda: "+poinPlayer+". Komputer: "+poinComputer+".");
                Console.ReadLine();

            }
            
            if(poinPlayer > poinComputer)
            {
                Console.WriteLine("Anda menang!");
            }
            else if(poinPlayer < poinComputer)
            {
                Console.WriteLine("Anda Kalah...");
            }
            else
            {
                Console.WriteLine("Seri!");
            }

            Console.ReadLine();
        }
    }
}