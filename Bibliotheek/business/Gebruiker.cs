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
        private string wachtwoord;
        private string gebruikersnaam;
        private string naam;
        private string voornaam;
        private string email;
        private int rechtID;

        //properties
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
    }
}
