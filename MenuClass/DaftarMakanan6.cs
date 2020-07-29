using System;
using System.Collections.Generic;
using System.Text;


namespace DaftarMakanan.MenuClass
{
    public class DaftarMakanan6 : DaftarMenu
    {
        public override void Makanan()
        {
            Console.WriteLine("=    =                                              =");
            Console.WriteLine("= 6. = Ayam Goreng Ungu                             =");
        }

        public override void Minuman()
        {
            Console.WriteLine("=    = Lemon Ice Ungu                               =");
        }

        public override void Harga()
        {
            Console.Write("=    = Harga : 14.000                               =");
        }
    }
}
