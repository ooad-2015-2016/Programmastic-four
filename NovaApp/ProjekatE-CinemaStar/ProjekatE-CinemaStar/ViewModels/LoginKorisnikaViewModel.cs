using ProjekatE_CinemaStar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjekatE_CinemaStar.ViewModels
{
    class LoginKorisnikaViewModel
    {
        Korisnik korisnik { get; set; }

        public ICommand potvrdiLogin { get; set; }

        public void ulogujSe()
        {
            potvrdiLogin = new RelayCommand<object>(potvrdi, mozeLiSePotvrditi);
        }
        
        public void potvrdi(object parametar)
        {
            var db = new OtpadDbContext();
            for(int i = 0; i < db.korisnici.Length(); i++)
            {
                if(db.korisnici[i] == korisnik.username)
                    NavigationService.Navigate(typeof(FormatExceptionZaKorisnike), new FormaZaKorisnikeViewModel());
                
            }
            
        }

        public bool mozeLiSePotvrditi(object par)
        {
            return true;
        }
    }
}
