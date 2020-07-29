using System;
using System.Collections.Generic;
using System.Text;

namespace DaftarMakanan.MenuClass
{
    public class DaftarMakanan4 : DaftarMenu
    {
        public override void Makanan()
        {
            Console.WriteLine("=    =                                              =");
            Console.WriteLine("= 4. = Burger Ungu                                  =");
        }

        public override void Minuman()
        {
            Console.WriteLine("=    = Milktea Ungu                                 =");
        }


        public override void Harga()
        {
            Console.Write("=    = Harga : Rp25.000                             =");
        }
    }
}
