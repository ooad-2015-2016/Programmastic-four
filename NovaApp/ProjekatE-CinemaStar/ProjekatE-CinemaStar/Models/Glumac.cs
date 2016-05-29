using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatE_CinemaStar.Models
{
    class Glumac
    {
        String ime, prezime, najFilm;

        public Glumac()
        {

        }

        public Glumac(string i, string p, string nf)
        {
            this.ime = i;
            this.prezime = p;
            this.najFilm = nf;
        }

        public string Ime
        {
            get
            {
                return ime;
            }

            set
            {
                ime = value;
            }
        }

        public string NajFilm
        {
            get
            {
                return najFilm;
            }

            set
            {
                najFilm = value;
            }
        }

        public string Prezime
        {
            get
            {
                return prezime;
            }

            set
            {
                prezime = value;
            }
        }
    }
}
