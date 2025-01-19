namespace UIKT_Naloga7.Models
{
    public class Ministrstvo
    {
        public List<Prosnja> Prosnje { get; }

        public Ministrstvo()
        {
            Prosnje = new List<Prosnja>();

            foreach(Uporabnik uporabnik in Evidenca.Uporabniki)
            {
                foreach(Prosnja prosnja in uporabnik.Prosnje)
                {
                    if(prosnja.Stanje == "V obdelavi")
                    {
                        Prosnje.Add(prosnja);
                    }
                }
            }
        }
    }
}
