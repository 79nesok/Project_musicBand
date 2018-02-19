using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicBandAssistant
{
    class Klijent
    {
        public int KlijentID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public char Kontakt { get; set; }
        public string Lokacija { get; set; }
        public DateTime Datum { get; set; }
        public float Cena { get; set; }
        public string Email { get; set; }
        public string Info { get; set; }
    }
}
