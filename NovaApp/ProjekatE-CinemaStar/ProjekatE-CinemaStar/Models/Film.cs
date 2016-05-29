using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatE_CinemaStar.Models
{
    enum Zanr { komedija, horor, triler, akcija, scifi, avantura, romansa, drama, misterija, biografija };

    class Film
    {
        String nazivFilma, reziser;
        VrijemeProjekcije vrijeme;
        Zanr zanr;
        Glumac glumci;

        public Film()
        {
                
        }

        public Film(string n, Zanr z, VrijemeProjekcije v, string r, Glumac g)
        {
            this.nazivFilma = n;
            this.zanr = z;
            this.vrijeme = v;
            this.reziser = r;
            this.glumci = g;
        }

        public string NazivFilma
        {
            get
            {
                return nazivFilma;
            }

            set
            {
                nazivFilma = value;
            }
        }

        public string Reziser
        {
            get
            {
                return reziser;
            }

            set
            {
                reziser = value;
            }
        }

        internal VrijemeProjekcije Vrijeme
        {
            get
            {
                return vrijeme;
            }

            set
            {
                vrijeme = value;
            }
        }

        private Zanr Zanr1
        {
            get
            {
                return zanr;
            }

            set
            {
                zanr = value;
            }
        }

        internal Glumac Glumci
        {
            get
            {
                return glumci;
            }

            set
            {
                glumci = value;
            }
        }
    }
}
