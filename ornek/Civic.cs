
namespace ornek
{
    public class Civic : IOtomobil
    {
        public Marka HangiMarkan─▒nAraci()
        {
            return Marka.Honda;
        }

        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public Renk standartRengiNe()
        {
            return Renk.Gri;
        }
    }
}