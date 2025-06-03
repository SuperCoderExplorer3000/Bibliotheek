using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheek.business
{
    public class Gebruiker
    {
        //instantievariabelen
        private int gebruikerID;
        private string wachtwoord;
        private string gebruikersnaam;
        private string naam;
        private string voornaam;
        private string email;
        private int rechtID;

        //properties

        public int GebruikerID
        {
            get { return gebruikerID; }
            set { gebruikerID = value; }
        }
        public string Wachtwoord
        {
            get { return wachtwoord; }
            set { wachtwoord = value; }
        }

        public string Gebruikersnaam
        {
            get { return gebruikersnaam; }
            set { gebruikersnaam = value; }
        }

        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }

        public string Voornaam
        {
            get { return voornaam; }
            set { voornaam = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public int RechtID
        {
            get { return rechtID; }
            set { rechtID = value; }
        }

        //default construtor

        public Gebruiker()
        {
            GebruikerID = 0;
            Wachtwoord = string.Empty;
            Gebruikersnaam = string.Empty;
            Naam = string.Empty;
            Voornaam = string.Empty;
            Email = string.Empty;
            RechtID = 0;
        }

        //constructor voor het inloggen

        public Gebruiker(string gebruikersnaam, string wachtwoord)
        {
            Gebruikersnaam = gebruikersnaam;
            Wachtwoord = wachtwoord;
        }

        //constructor voor het toevoegen van een gebruiker

        public Gebruiker(string wachtwoord, string gebruikersnaam, string naam, string voornaam, string email, int rechtID)
        {
            Wachtwoord = wachtwoord;
            Gebruikersnaam = gebruikersnaam;
            Naam = naam;
            Voornaam = voornaam;
            Email = email;
            RechtID = rechtID;

        }

        //overide string voor het weergeven van de gebruiker
        public override string ToString()
        {
            return $"{GebruikerID}. {Voornaam} {Naam} ({Gebruikersnaam}) - Email: {Email}";
        }
    }
}
