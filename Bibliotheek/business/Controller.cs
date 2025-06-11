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
        private LeningMapper _leningmapper;
        private List<Boek> _boekenlijst;
        private List<Gebruiker> _gebruikerslijst;
        private List<Lening> _leningenlijst;


        public List<Boek> GetBoeken
        {
            get { return _boekenlijst; }
            set { _boekenlijst = value; }
        }

        public List<Gebruiker> GetGebruikers
        {
            get { return _gebruikerslijst; }
            set { _gebruikerslijst = value; }
        }

        public List<Lening> GetLeningen
        {
            get { return _leningenlijst; }
            set { _leningenlijst = value; }
        }


        public Controller()
        {
            _boekmapper = new BoekMapper();
            _gebruikerMapper = new GebruikerMapper();  
            _boekenlijst = _boekmapper.GetBoeken();
            _gebruikerslijst = _gebruikerMapper.GetGebruikers();
            _leningmapper = new LeningMapper();
            _leningenlijst = _leningmapper.GetLening();
        }

        public void AddBoek(int ISBN, int paginas, string titel, int genreID, string uitgever, string auteur, string taal, int graad)
        {
            _boekmapper.AddBoek(ISBN, paginas, titel, genreID, uitgever, auteur, taal, graad);
            _boekenlijst = _boekmapper.GetBoeken();

        }

        public void AddLening(int gebruikerID, int boekID, string datumin, string datumout)
        {
            try
            {
                _leningmapper.AddLening(gebruikerID, boekID, datumin, datumout);
                _leningenlijst = _leningmapper.GetLening();
            }
            catch (Exception ex)
            {
                // Log de fout of geef een aangepaste foutmelding
                throw new Exception("Er is een fout opgetreden tijdens het toevoegen van de lening.", ex);
            }
        }

        public void AddGebruiker(string naam, string gebruikersnaam, string voornaam, string email, string wachtwoord, string rechtID)
        {
            try
            {
                _gebruikerMapper.AddGebruiker(wachtwoord, gebruikersnaam, naam, voornaam, email, rechtID);
                _gebruikerslijst = _gebruikerMapper.GetGebruikers();
            }
            catch (Exception ex)
            {
                // Log de fout of geef een aangepaste foutmelding
                throw new Exception("Er is een fout opgetreden tijdens het toevoegen van de gebruiker.", ex);
            }
        }

        public void UpdateBoek(int boekID, int ISBN, int paginas, string titel, int genreID, string uitgever, string auteur, string taal, int graad)
        {
            try
            {
                // Roep de updatefunctie aan in de BoekMapper
                _boekmapper.UpdateBoek(new Boek
                {
                    Boekid = boekID,
                    Isbn = ISBN,
                    Paginas = paginas,
                    Titel = titel,
                    Genreid = genreID,
                    Uitgever = uitgever,
                    Auteur = auteur,
                    Taal = taal,
                    Graad = graad
                });

                // Ververs de lijst met boeken
                RefreshList();
            }
            catch (Exception ex)
            {
                // Log de fout of geef een aangepaste foutmelding
                throw new Exception("Er is een fout opgetreden tijdens het updaten van het boek.", ex);
            }
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

        public Boek GetBoekById(int boekID)
        {
            return _boekmapper.GetBoekById(boekID);
        }

        public Gebruiker GetGebruikerById(int gebruikerID)
        {
            return _gebruikerMapper.GetGebruikerByID(gebruikerID);
        }

        public void UpdateBoek(Boek boek)
        {
            try
            {
                // Roep de update-methode aan in de BoekMapper
                _boekmapper.UpdateBoek(boek);
            }
            catch (Exception ex)
            {
                throw new Exception("Er is een fout opgetreden tijdens het updaten van het boek.", ex);
            }
        }

        public void UpdateGebruiker(Gebruiker gebruiker)
        {
            try
            {
                _gebruikerMapper.UpdateGebruiker(gebruiker);
                _gebruikerslijst = _gebruikerMapper.GetGebruikers();
            }
            catch (Exception ex)
            {
                throw new Exception("Er is een fout opgetreden tijdens het updaten van de gebruiker.", ex);
            }
        }


        public void DeleteGebruiker(int gebruikerID)
        {
            try
            {
                _gebruikerMapper.DeleteGebruiker(gebruikerID);
                _gebruikerslijst = _gebruikerMapper.GetGebruikers();
            }
            catch (Exception ex)
            {
                throw new Exception("Er is een fout opgetreden tijdens het verwijderen van de gebruiker.", ex);
            }
        }


        public void DeleteBoek(int boekID)
        {
            try
            {
                _boekmapper.DeleteBoek(boekID);
                RefreshList();
            }
            catch (Exception ex)
            {
                throw new Exception("Er is een fout opgetreden tijdens het verwijderen van het boek.", ex);
            }
        }

        public void SearchBoeken(string zoekterm)
        {
            if (string.IsNullOrEmpty(zoekterm))
            {
                _boekenlijst = _boekmapper.GetBoeken();
            }
            else
            {
                _boekenlijst = _boekmapper.SearchBoekenByTitle(zoekterm);
            }
        }



    }
}
