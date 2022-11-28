using System;

namespace Interface1
{
    class Program
    {
        interface Zaposleni
        {
            public abstract void RadSaStudentima();
            public abstract string Ime();
            public abstract long Jmbg();
            public abstract void Podaci(long jmbg, string ime);

        }
        class Profesor : Zaposleni
        {
            public long jmbg;
            public string ime;
            public Profesor(long jmbg, string ime)
            {
                this.jmbg = jmbg;
                this.ime = ime;
            }
            public void RadSaStudentima()
            {
                Console.WriteLine(" Konsultacije su sredom od 10 - 12 h ");
            }
            public long Jmbg()
            {
                return jmbg;
            }
            public string Ime()
            {
                return ime;
            }
            public void Podaci(long jmbg, string ime)
            {
                Console.WriteLine(" Podaci o profesoru");
                Console.WriteLine("Jmbg" + this.jmbg);
                Console.WriteLine(" Ime i prezime:" + ime);
            }
        }
        static void Main(string[] args)
        {
            Profesor prof = new Profesor(11111111111111, " Pera Peric");
            prof.Podaci(prof.Jmbg(), prof.Ime());
            prof.RadSaStudentima();
            Console.ReadKey();
        }
    }
}
