using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatE_CinemaStar.Models
{
    class Raspored
    {
        int brojFilmova;
        Film filmovi;

        public Raspored()
        {

        }

        public Raspored(int bf, Film f)
        {
            this.brojFilmova = bf;
            this.filmovi = f;
        }

        public int BrojFilmova
        {
            get
            {
                return brojFilmova;
            }

            set
            {
                brojFilmova = value;
            }
        }

        internal Film Filmovi
        {
            get
            {
                return filmovi;
            }

            set
            {
                filmovi = value;
            }
        }
        
    }
}
