using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatE_CinemaStar.Models
{
    enum StatusUposlenika { sef, radnik}

    class Uposlenik : Korisnik
    {
        StatusUposlenika statusUposlenika;
        DateTime pocetakRada;

        public Uposlenik() : base()
        {

        }

        public Uposlenik(string i, string p, string ki, string m, string l, DateTime dr, StatusUposlenika s, DateTime pr) : base(i, p, koi, m, l, dr)
        {
            this.statusUposlenika = s;
            this.pocetakRada = pr;
        }

        internal StatusUposlenika StatusUposlenika
        {
            get
            {
                return statusUposlenika;
            }

            set
            {
                statusUposlenika = value;
            }
        }

        public DateTime PocetakRada
        {
            get
            {
                return pocetakRada;
            }

            set
            {
                pocetakRada = value;
            }
        }
    }
}
