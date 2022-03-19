
namespace Przykładowa_aplikacja.Models
{
    public class Student
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public string ImieiNazwisko
        {
            get
            {
                return Imie + " " + Nazwisko;
            }

        }
    }
}