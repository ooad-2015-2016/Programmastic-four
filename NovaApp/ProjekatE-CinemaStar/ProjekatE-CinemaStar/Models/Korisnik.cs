using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatE_CinemaStar.Models
{
    class Korisnik
    {
        string ime, prezime, korisnickoIme, mail, lozinka;
        DateTime datumRegistracije;

        public Korisnik()
        {

        }

        public Korisnik(string i, string p, string ki, string m, string l, DateTime dr)
        {
            this.ime = i;
            this.prezime = p;
            this.korisnickoIme = ki;
            this.mail = m;
            this.lozinka = l;
            this.datumRegistracije = dr;
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

        public string KorisnickoIme
        {
            get
            {
                return korisnickoIme;
            }

            set
            {
                korisnickoIme = value;
            }
        }

        public string Mail
        {
            get
            {
                return mail;
            }

            set
            {
                mail = value;
            }
        }

        public string Lozinka
        {
            get
            {
                return lozinka;
            }

            set
            {
                lozinka = value;
            }
        }

        public DateTime DatumRegistracije
        {
            get
            {
                return datumRegistracije;
            }

            set
            {
                datumRegistracije = value;
            }
        }
    }
}
