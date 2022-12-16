using System;

namespace uts
{
    class program
    {
        static void Main(string[] args)
        {
            string nama;
            string nim;
            string konsentrasi;

            Console.Write("Nama : ");
            nama = Console.ReadLine();
            Console.Write("NIM : ");
            nim = Console.ReadLine();
            Console.Write("Konsentrasi : ");
            konsentrasi = Console.ReadLine();

            Console.WriteLine("|**************************************|");
            Console.WriteLine("{0,-7} {1,32}","|Nama :", nama+"|");
            Console.WriteLine("{0,-7} {1,32}","|", nim+"|");
            Console.WriteLine("|--------------------------------------|");
            Console.WriteLine("{0,-7} {1,32}","|", konsentrasi+"|");
            Console.WriteLine("|**************************************|");
            Console.WriteLine("");
        }
    }
}
