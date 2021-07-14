using System;

namespace ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            Focus focus=new Focus();
            Console.WriteLine(focus.HangiMarkanınAraci().ToString());
            Console.WriteLine(focus.KacTekerlektenOlusur());
            Console.WriteLine(focus.standartRengiNe().ToString());

            Civic civic = new Civic();
            
            Console.WriteLine(civic.HangiMarkanınAraci().ToString());
            Console.WriteLine(civic.KacTekerlektenOlusur());
            Console.WriteLine(civic.standartRengiNe().ToString());
        }
    }
}
