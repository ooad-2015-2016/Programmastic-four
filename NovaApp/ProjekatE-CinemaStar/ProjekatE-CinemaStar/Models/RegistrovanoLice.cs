using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatE_CinemaStar.Models
{
    class RegistrovanoLice : Korisnik
    {
        Boolean ljubiteljFilma;

        public RegistrovanoLice() : base()
        {

        }

        public RegistrovanoLice(string i, string p, string ki, string m, string l, DateTime dr, Boolean ljf) : base(i, p, ki, m, l, dr)
        {
            this.ljubiteljFilma = ljf;
        }

        public bool LjubiteljFilma
        {
            get
            {
                return ljubiteljFilma;
            }

            set
            {
                ljubiteljFilma = value;
            }
        }
    }
}
