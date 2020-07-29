using System;
using DaftarMakanan.MenuClass;


namespace DaftarMakanan
{
    class Program 
{
    static void Main(string[] args)
    {

            Console.WriteLine("======================Resto Ungu=====================");
            Console.WriteLine("= NO = Kami menyediakan Anda menu paket makanan Kami=");
            Console.WriteLine("=    =                                              =");

        DaftarMenu Menuu;

        Menuu = new DaftarMakanan1();
            Menuu.Makanan();
            Menuu.Minuman();
            Menuu.Harga();


            Console.WriteLine();
        Menuu = new DaftarMakanan2();
            Menuu.Makanan();
            Menuu.Minuman();
            Menuu.Harga();

            
            Console.WriteLine();
        Menuu = new DaftarMakanan3();
            Menuu.Makanan();
            Menuu.Minuman();
            Menuu.Harga();

            
            Console.WriteLine();
        Menuu = new DaftarMakanan4();
            Menuu.Makanan();
            Menuu.Minuman();
            Menuu.Harga();


            
            Console.WriteLine();
        Menuu = new DaftarMakanan5();
            Menuu.Makanan();
            Menuu.Minuman();
            Menuu.Harga();



            Console.WriteLine();
        Menuu = new DaftarMakanan6();
            Menuu.Makanan();
            Menuu.Minuman();
            Menuu.Harga();

            Console.WriteLine();
            Console.WriteLine("=    =                                              =");
            Console.Write("=====================================================");




            Console.ReadKey();
    }
  }
}
