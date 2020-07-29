using System;
using System.Collections.Generic;
using System.Text;

namespace DaftarMakanan.MenuClass
{
    public class DaftarMakanan2 : DaftarMenu
    {
        public override void Makanan()
        {
            Console.WriteLine("=    =                                              ="); 
            Console.WriteLine("= 2. = Soto Ungu                                    =");
        }


        public override void Minuman()
        {
            Console.WriteLine("=    = Milkshake Ungu                               =");
        }


        public override void Harga()
        {
            Console.Write("=    = Harga : Rp22.000                             =");
        }

 
    }
}
