using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatE_CinemaStar.Models
{
    class VrijemeProjekcije
    {
        DateTime pocetak, kraj;
        int zauzetaMjesta;

        public VrijemeProjekcije()
        {

        }
        
        public DateTime Kraj
        {
            get
            {
                return kraj;
            }

            set
            {
                kraj = value;
            }
        }

        public DateTime Pocetak
        {
            get
            {
                return pocetak;
            }

            set
            {
                pocetak = value;
            }
        }

        public int ZauzetaMjesta
        {
            get
            {
                return zauzetaMjesta;
            }

            set
            {
                zauzetaMjesta = value;
            }
        }
    }
}
