using System;
using System.Collections.Generic;
using System.Text;


namespace DaftarMakanan.MenuClass
{
    public class DaftarMakanan1 : DaftarMenu
    {
        public override void Makanan()
        {
            Console.WriteLine("=    =                                              =");
            Console.WriteLine("= 1. = Nasi Goreng Ungu                             =");
        }


        public override void Minuman()
        {
            Console.WriteLine("=    = Jus Ungu                                     =");
        }


        public override void Harga()
        {
            Console.Write("=    = Harga : Rp20.000                             =");
        }

    }
}
