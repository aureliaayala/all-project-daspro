using System;
using System.Collections.Generic;

namespace TebakKata
{
    class program
    {
        static string kataMisteri = "aladdin";
        static int kesempatan = 5;
        static List<string> tebakanPemain = new List<string>();
        static void Main(string[] args)
        {
            Intro();
            MulaiMain();
        }
        static void Intro()
        {
            Console.WriteLine("Selamat datang, hari ini kita akan bermain tebak kata...");
            Console.WriteLine($"Kamu punya {kesempatan} kesempatan untuk menebak kata misteri hari ini.");
            Console.WriteLine("Petunjuknya adalah kata ini merupakan nama film animasi.");
            Console.WriteLine($"Kata tersebut terdiri dari {kataMisteri.Length} huruf.");
            Console.WriteLine("Film apakah yang dimaksud?");
        }

        static void MulaiMain()
        {
            while (kesempatan>0)
            {
                Console.Write("Apa saja karakter tebakanmu? (a-z) : ");
                string input = Console.ReadLine();
                tebakanPemain.Add(input);

                if(cekjawaban(kataMisteri,tebakanPemain))
                {
                    Console.WriteLine("Selamat anda berhasil");
                    Console.WriteLine($"Kata misteri hari ini adalah {kataMisteri}");
                    break;
                }

                else if(kataMisteri.Contains(input))
                {
                    Console.WriteLine("Huruf itu ada di dalam kata ini");
                    Console.WriteLine("Silahkan tebak huruf lainnya...");
                    Console.WriteLine(cekhuruf(kataMisteri, tebakanPemain));
                }

                else
                {
                    Console.WriteLine("Huruf itu tidak ada dalam kata ini");
                    kesempatan--;
                    Console.WriteLine($"Kesempatan anda tinggal {kesempatan}");
                }

                if(kesempatan==0)
                {
                    showend();
                    break;
                }

                static bool cekjawaban(string kataMisteri, List<string> list)
                {
                    bool status = false;
                    for(int i = 0; i < kataMisteri.Length; i++)
                    {
                        string c = Convert.ToString(kataMisteri[i]);
                        if(list.Contains(c))
                        {
                            status = true;
                        }
                        else
                        {
                            return status = false;
                        }
                    }
                    return status;
                }
                static string cekhuruf(string kataMisteri, List<string> list)
                {
                    string x = "";
                    for(int i = 0; i<kataMisteri.Length; i++)
                    {
                        string c = Convert.ToString(kataMisteri[i]);
                        if(list.Contains(c))
                        {
                            x = x + c;
                        }
                        else
                        {
                            x = x + " _";
                        }
                    }
                    return x;
                }
                static void showend()
                {
                    if(kesempatan == 0)
                    {
                        Console.WriteLine("Permainan berakhir");
                        Console.WriteLine($"Kata misteri sebenarnya adalah {kataMisteri}");
                    }
                }
            }
        }
    }
}