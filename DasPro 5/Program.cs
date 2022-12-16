using System;

namespace BattleTank
{
    class Program
    {
        static void Main(string[] args)
        {
            //inisialisasi variabel yang dibutuhkan
            int panjangArea = 5;
            char rumput = '~';
            char tank = 't';
            char hit = 'X';
            char miss = 'O';
            int jumlahTank = 3;

            char[,] playArea = buatRuang(panjangArea, rumput, tank, jumlahTank);

            printArea(playArea, rumput, tank);
            int jumlahTankTersembunyi = jumlahTank;

            //gameplay
            while(jumlahTankTersembunyi>0)
            {
                int[] tebakanKoordinat = getKoordinatTebakan(panjangArea);
                char updateTampilanArea = verifikasiTebakan(tebakanKoordinat, area, tank, rumput, hit, miss);
                if(updateTampilanArea == hit)
                {
                    jumlahTankTersembunyi--;
                }
                ruangan = updateRuangan(rumput, tebakanKoordinat, updateTampilanArea);
                printArea(ruangan, rumput, tank);
            }

            Console.WriteLine("Game Over, Byebye...");
            Console.Read();
        }

        static char[,] buatRuang(int panjangArea, char rumput, char tank, int jumlahTank)
        {
            char[,] ruangan = new char[panjangArea,panjangArea];

            for(int baris=0;baris<panjangArea;baris++)
            {
                for(int kolom=0;kolom<panjangArea;kolom++)
                {
                    ruangan[baris,kolom] = rumput;
                }
            }

            return letakkanTank(ruangan, jumlahTank, rumput, tank);
        }

        static char[,] letakkanTank(char[,] ruangan, int jumlahTank, char rumput, char tank)
        {
            int letakTank = 0;
            int panjangArea = 5;
            
            while(letakTank<jumlahTank)
            {
                int[] lokasiTank = tentukanKoordinatTank(panjangArea);
                char posisi = ruangan[lokasiTank[0],lokasiTank[1]];

                if(posisi==rumput)
                {
                    ruangan[lokasiTank[0],lokasiTank[1]] = tank;
                    letakTank++;
                }
            }

            return ruangan;
        }

        //menentukan posisi koordinat tank (x,y)
        static int[] tentukanKoordinatTank(int panjangArea)
        {
            Random rng = new Random();
            int[] koordinat = new int[2];
            for(int i=0;i<koordinat.Length;i++)
            {
                koordinat[i] = rng.Next(panjangArea);//x = random(0,4) ; y = random(0,4)
            }

            return koordinat;
        }

        //menampilkan area permainan ke console
        static void printArea(char[,] ruangan, char rumput, char tank)
        {
            Console.Write(" ");
            for(int i=0;i<5;i++)
            {
                Console.Write(i+1+" ");// 1 2 3 4 5
            }

            for(int baris=0;baris<5;baris++)
            {
                Console.Write(baris + 1 +" ");
                for(int kolom=0;kolom<5;kolom++)
                {
                    char posisi = playArea[baris,kolom];
                    if(posisi == tank)
                    {
                        Console.Write(rumput + " ");
                    }
                    else
                    {
                        Console.Write(posisi + " ");
                    }

                }
                Console.WriteLine();
            }
        }
        //tebakan koordinat pemain
        static int[] getKoordinatTebakan(int panjangArea)
        {
            int baris;
            int kolom;

            do
            {
                Console.Write("Pilih Baris: ");
                baris = Convert.ToInt32(Console.ReadLine());
            }
            while(baris<0 || baris>panjangArea + 1);
            
            do
            {
                Console.Write("Pilih Kolom : ");
                kolom = Convert.ToInt32(Console.ReadLine());
            }
            while (kolom<0 || kolom>panjangArea + 1);

            return new[] {baris-1, kolom-1;}
        }

        static char verifikasiTebakan(int [] tebakanKoordinat, char[,] ruangan, char tank, char runput, char miss, char hit)
        {
            string pesan;
            int baris = tebakanKoordinat[0];
            int kolom = tebakanKoordinat[1];
            char target = ruang[baris, kolom];

            if(target == tank)
            {
                pesan = "Tepat sasaran, tank meledak!";
                target = hit;
            }
            else if(target == rumput)
            {
                pesan = "Sayang sekali, tembakan meleset!";
                target = miss;
            }
            else
            {
                pesan = "Area ini aman!";
            }

            Console.WriteLine(pesan);
            Console.WriteLine("   ");
            return target;
        }

        static char[,] updateRuangan(char[,] ruangan,int[] tebakanKoordinat, char updateTampilanArea)
        {
            int baris = tebakanKoordinat[0];
            int kolom = tebakanKoordinat[1];
            ruang[baris, kolom] = updateTampilanArea;
            return ruang;
        }
    }
}