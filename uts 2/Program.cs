using System;

namespace uts
{
    class program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int jawaban;
            int tebakan;
            bool playGame = false;

            jawaban = rng.Next(1,101);

            while(!playGame)
            {
                Console.Write("Tebak angka antara 1-100 : ");
                tebakan = Convert.ToInt32(Console.ReadLine());

                if(tebakan > jawaban)
                {
                    Console.WriteLine("Salah. Nilai terlalu tinggi.");
                }

                else if(tebakan < jawaban)
                {
                    Console.WriteLine("Salah. Nilai terlalu rendah.");
                }

                else
                {
                    Console.WriteLine("Anda benar!");
                    playGame = true;
                }
            }

            Console.WriteLine("Bye...");
        }
    }
}
