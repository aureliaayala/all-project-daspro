using System;

namespace uts
{
    class program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            string player;
            string komputer;
            int random;
            int skorPlayer = 0;
            int skorKomputer = 0;
            bool a = false;

            random = rng.Next(1,4);

            Console.Write("Tekan enter untuk mulai");

            while(!a)
            {
                Console.Write("Choose [b]atu, [g]unting, [k]ertas, or [e]xit : ");
                player = Console.ReadLine();

                switch (random)
                {
                    case 1:
                        komputer = "Batu";
                        Console.WriteLine("Komputer memilih batu");
                        if(player == "b")
                        {
                            Console.WriteLine("Seri.");
                        }
                        else if(player == "g")
                        {
                            Console.WriteLine("Kalah...");
                            skorKomputer++;
                        }
                        else if(player == "k")
                        {
                            Console.WriteLine("Menang!");
                            skorPlayer++;
                        }
                        else
                        {
                            Console.WriteLine("bye...");
                            a = false;
                        }
                        break;
                    case 2:
                        komputer = "Gunting";
                        Console.WriteLine("Komputer memilih gunting");
                        if(player == "b")
                        {
                            Console.WriteLine("Menang!");
                            skorPlayer++;
                        }
                        else if(player == "g")
                        {
                            Console.WriteLine("Seri.");
                        }
                        else if(player == "k")
                        {
                            Console.WriteLine("Kalah...");
                            skorKomputer++;
                        }
                        else
                        {
                            Console.WriteLine("bye...");
                            a = false;
                        }
                        break;
                    case 3:
                        komputer = "Kertas";
                        Console.WriteLine("Komputer memilih kertas");
                        if(player == "b")
                        {
                            Console.WriteLine("kalah...");
                            skorKomputer++;
                        }
                        else if(player == "g")
                        {
                            Console.WriteLine("Menang!");
                            skorPlayer++;
                        }
                        else if(player == "k")
                        {
                            Console.WriteLine("Seri.");
                        }
                        else
                        {
                            Console.WriteLine("bye...");
                            a = true;
                        }
                        break;

                }

                Console.WriteLine("skor player : "+skorPlayer+", skor komputer : "+skorKomputer);
                Console.WriteLine("Tekan enter untuk melanjutkan permainan.");
                Console.ReadLine();
            }
            
        }
    }
}