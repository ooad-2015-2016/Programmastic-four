using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatE_CinemaStar.Models
{
    enum Status { nepotvrdjeno, placeno, otkazano};
    enum NacinPlacanja { gotovina, kartica};
    class Rezervacija
    {
        string id;
        DateTime vrijemeProjekcije;
        NacinPlacanja placanje;
        Status status;

        public Rezervacija()
        {

        }

        public Rezervacija(string id, DateTime vp, NacinPlacanja p, Status s)
        {
            this.id = id;
            this.vrijemeProjekcije = vp;
            this.placanje = p;
            this.status = s;
        }

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public DateTime VrijemeProjekcije
        {
            get
            {
                return vrijemeProjekcije;
            }

            set
            {
                vrijemeProjekcije = value;
            }
        }

        internal NacinPlacanja Placanje
        {
            get
            {
                return placanje;
            }

            set
            {
                placanje = value;
            }
        }

        internal Status Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }
    }
}
