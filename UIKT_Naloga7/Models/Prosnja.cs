using System.ComponentModel.DataAnnotations;

namespace UIKT_Naloga7.Models
{
    public class Prosnja
    {
        public string Ime { get; set; }
        public string Priimek { get; set; }

        [Display(Name = "Država")]
        public string Drzava { get; set; }
        public string Naslov { get; set; }
        public string Telefon { get; set; }

        [Display(Name = "Dokazilo o sprecializaciji in izobrazbi")]
        public string DokaziloSpecializacija { get; set; }

        [Display(Name = "Dokazila in reference o opravljanju strokovnih izpitov v tujini")]
        public string DokaziloReferenceIzpiti { get; set; }
        public string Naziv { get; set; }
        public string Datum { get; }
        public string Stanje { get; set; }

        public Prosnja(string ime, string priimek, string drzava, string naslov, string telefon, string dokaziloSpecializacija, string dokaziloReferenceIzpiti, string naziv)
        {
            Ime = ime;
            Priimek = priimek;
            Drzava = drzava;
            Naslov = naslov;
            Telefon = telefon;
            DokaziloSpecializacija = dokaziloSpecializacija;
            DokaziloReferenceIzpiti = dokaziloReferenceIzpiti;
            Naziv = naziv;
            Datum = DateTime.Now.ToString();
            Stanje = "V obdelavi";
        }

        public Prosnja()
        {
            Datum = DateTime.Now.ToString();
            Stanje = "V obdelavi";
        }
    }
}
