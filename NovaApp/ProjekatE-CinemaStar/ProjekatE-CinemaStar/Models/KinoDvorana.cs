using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatE_CinemaStar.Models
{
    class KinoDvorana
    {
        int brojSjedista, brojDvorane;

        public KinoDvorana()
        {

        }

        public KinoDvorana(int bs, int bd)
        {
            this.brojSjedista = bs;
            this.brojDvorane = bd;
        }

        public int BrojDvorane
        {
            get
            {
                return brojDvorane;
            }

            set
            {
                brojDvorane = value;
            }
        }

        public int BrojSjedista
        {
            get
            {
                return brojSjedista;
            }

            set
            {
                brojSjedista = value;
            }
        }
    }
}
