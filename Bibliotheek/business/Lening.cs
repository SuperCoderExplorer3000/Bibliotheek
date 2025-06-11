using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheek.business
{
    public class Lening
    {
        //klassevariabelen
        private int leningID;
        private string datumIN;
        private string datumOUT;
        private int gebruikerID;
        private int boekID;

        //properties
        public int LeningID
        {
            get { return leningID; }
            set { leningID = value; }
        }

        public string DatumIN
        {
            get { return datumIN; }
            set {  datumIN = value; }
        }

        public string DatumOUT
        {
            get { return datumOUT; }
            set { datumOUT = value; }
        }

        public int GebruikerID
        {
            get { return gebruikerID; }
            set { gebruikerID = value; }
        }

        public int BoekID
        {
            get { return boekID; }
            set { boekID = value; }
        }

        //constructors
        //default constructor

        public Lening()
        {
            LeningID = 0;
            DatumIN = string.Empty;
            DatumOUT = string.Empty;
            GebruikerID = 0;
            BoekID = 0;
        }

        //toevoegen lening constructor
        public Lening(int gebruikerid, int boekid, string datumin, string datumout)
        {
            GebruikerID = gebruikerid;
            BoekID = boekid;
            DatumIN = datumin;
            DatumOUT = datumout;
        }

        //override sting

        public override string ToString()
        {
            return $"{LeningID}. gebruiker: {GebruikerID}, boek: {boekID}";
        }
    }
}
