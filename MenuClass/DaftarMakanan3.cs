using System;
using System.Collections.Generic;
using System.Text;


namespace DaftarMakanan.MenuClass
{
    public class DaftarMakanan3 : DaftarMenu
    {
        public override void Makanan()
        {
            Console.WriteLine("=    =                                              =");
            Console.WriteLine("= 3. = Bakso ungu                                   =");
        }

        public override void Minuman()
        {
            Console.WriteLine("=    = IceTea Ungu                                  =");
        }


        public override void Harga()
        {
            Console.Write("=    =Harga : Rp18.000                              =");
        }

    }
}
