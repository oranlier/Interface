
namespace ornek
{
    public class Focus : IOtomobil
    {
        public Marka HangiMarkan─▒nAraci()
        {
            return Marka.Ford;
        }

        public int KacTekerlektenOlusur()
        {
            return 4;
        }
        public Renk standartRengiNe()
        {
            return Renk.Beyaz;
        }
    }
}