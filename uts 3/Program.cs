using System;

namespace uts
{
    class program
    {
        static void Main(string[] args)
        {
            int jumlahHari;
            int denda;

            Console.Write("Input jumlah hari peminjaman : ");
            jumlahHari = Convert.ToInt32(Console.ReadLine());

            if(jumlahHari > 30)
            {
                denda = 450000 + (jumlahHari-30)*30000;
                Console.WriteLine("Total denda : "+denda);
                Console.WriteLine("Keanggotaan anda dibatalkan.");
            }

            else if(jumlahHari > 10)
            {
                denda = 50000 + (jumlahHari-10)*20000;
                Console.WriteLine("Total denda : "+denda);
            }

            else if(jumlahHari > 5)
            {
                denda = jumlahHari*10000;
                Console.WriteLine("Total denda : "+denda);
            }

            else
            {
                denda = 0;
                Console.WriteLine("Total denda : "+denda);
            }
        }
    }
}