using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibliotheek.persistence; 

namespace Bibliotheek.business
{
    public class Controller
    {
        private BoekMapper _boekmapper;
        private GebruikerMapper _gebruikerMapper;
        private List<Boek> _boekenlijst;

        public List<Boek> GetBoeken
        {
            get { return _boekenlijst; }
            set { _boekenlijst = value; }
        }

        public Controller()
        {
            _boekmapper = new BoekMapper();
            _gebruikerMapper = new GebruikerMapper(); // Initialize _gebruikerMapper  
            _boekenlijst = _boekmapper.GetBoeken();
        }

        public void AddBoek(int ISBN, int paginas, string titel, int genreID, string uitgever, string auteur, string taal, int graad)
        {
            _boekmapper.AddBoek(ISBN, paginas, titel, genreID, uitgever, auteur, taal, graad);
            _boekenlijst = _boekmapper.GetBoeken();

        }

        //Methode voor het refreshen van de lijst

        public void RefreshList()
        {
            _boekenlijst = _boekmapper.GetBoeken();
        }

        // Toegevoegde methode voor inloggen
        public bool LogIn(string gebruikersnaam, string wachtwoord)
        {
            try
            {
                return _gebruikerMapper.LogIn(gebruikersnaam, wachtwoord);
            }
            catch (Exception ex)
            {
                // Log de fout of geef een aangepaste foutmelding
                throw new Exception("Er is een fout opgetreden tijdens het inloggen.", ex);
            }
        }

        public bool ValidateLogin(string email, string password)
        {
            if ( _gebruikerMapper == null)
            {
                _gebruikerMapper = new persistence.GebruikerMapper();
            }
            return _gebruikerMapper.LogIn(email, password);
        }

    }
}
