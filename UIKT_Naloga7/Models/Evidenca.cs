namespace UIKT_Naloga7.Models
{
    public class Evidenca
    {
        public static List<Uporabnik> Uporabniki = new List<Uporabnik> { new Uporabnik("a", "a"), new Uporabnik("b", "b") };

        public static bool PreveriUporabnika(string uporabniskoIme, string geslo)
        {
            return Uporabniki.Any(x => x.UporabniskoIme == uporabniskoIme && x.Geslo == geslo);
        }
    }
}
