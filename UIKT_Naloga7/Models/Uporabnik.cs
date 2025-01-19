using System.ComponentModel.DataAnnotations;

namespace UIKT_Naloga7.Models
{
    public class Uporabnik
    {
        [Display(Name = "Uporabniško ime")]
        public string UporabniskoIme { get; set; }

        [DataType(DataType.Password)]
        public string Geslo { get; set; }

        public List<Prosnja> Prosnje { get; set; }

        public Uporabnik(string uporabniskoIme, string geslo)
        {
            UporabniskoIme = uporabniskoIme;
            Geslo = geslo;
            Prosnje = new List<Prosnja>();
        }

        public Uporabnik()
        {
            UporabniskoIme = "";
        }
    }
}
