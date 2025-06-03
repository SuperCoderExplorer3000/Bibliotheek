using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheek.business
{
    public class Boek
    {
        //klassevariabelen
        private int _boekid;
        private int _isbn;
        private int _paginas;
        private string _titel;
        private int _genreid;
        private string _uitgever;
        private string _auteur;
        private string _taal;
        private int _graad;

        //properties

        public int Boekid
        {
            get { return _boekid; }
            set { _boekid = value; }
        }

        public int Isbn
        {
            get { return _isbn; }
            set { _isbn = value; }
        }

        public int Paginas
        {
            get { return _paginas; }
            set { _paginas = value; }
        }

        public string Titel
        {
            get { return _titel; }
            set { _titel = value; }
        }

        public int Genreid
        {
            get { return _genreid; }
            set { _genreid = value; }
        }

        public string Uitgever
        {
            get { return _uitgever; }
            set { _uitgever = value; }
        }

        public string Auteur
        {
            get { return _auteur; }
            set { _auteur = value; }
        }

        public string Taal
        {
            get { return _taal; }
            set { _taal = value; }
        }

        public int Graad
        {
            get { return _graad; }
            set { _graad = value; }
        }

        //default constructor
        public Boek()
        {
            Titel = "";
            Uitgever = "";
            Auteur = "";
            Taal = "";
            Graad = 0;
            Paginas = 0;
            Genreid = 0;
            Isbn = 0;
            Boekid = 0;
        }

        //constructor met parameters voor het weergeven van de boeken    
        public Boek(string titel, string auteur)
        {
            Titel = titel;
            Auteur = auteur;
        }

        //constructor met parameters voor het toevoegen van de boeken

        public Boek(int isbn, int paginas, string titel, int genreid, string uitgever, string auteur, string taal, int graad)
        {
            Isbn = isbn;
            Paginas = paginas;
            Titel = titel;
            Genreid = genreid;
            Uitgever = uitgever;
            Auteur = auteur;
            Taal = taal;
            Graad = graad;
        }

        //constructor met parameters voor het wijzigen van de boeken    

        public Boek(int boekid, int isbn, int paginas, string titel, int genreid, string uitgever, string auteur, string taal, int graad)
        {
            Boekid = boekid;
            Isbn = isbn;
            Paginas = paginas;
            Titel = titel;
            Genreid = genreid;
            Uitgever = uitgever;
            Auteur = auteur;
            Taal = taal;
            Graad = graad;
        }

        //override string
        public override string ToString()
        {
            return Boekid + ". " + Titel + " - " + Auteur;
        }
    }
}
