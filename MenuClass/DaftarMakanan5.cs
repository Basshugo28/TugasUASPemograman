using System;
using System.Collections.Generic;
using System.Text;


namespace DaftarMakanan.MenuClass
{
    public class DaftarMakanan5 : DaftarMenu
    {
        public override void Makanan()
        {
            Console.WriteLine("=    =                                              =");
            Console.WriteLine("= 5. = Kentang Ungu                                 =");
        }

        public override void Minuman()
        {
            Console.WriteLine("=    = Boba Icecream                                =");
        }

        public override void Harga()
        {
            Console.Write("=    = Harga : Rp18.000                             =");
        }
    }
}
