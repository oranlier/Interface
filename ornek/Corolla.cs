
namespace ornek
{
    public class Corolla : IOtomobil
    {
        public Marka HangiMarkanınAraci()
        {
            return Marka.Toyota;
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
