using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibliotheek.business;
using Bibliotheek.persistence;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Bibliotheek.persistence
{
    public class LeningMapper
    {
        //variabelen
        private readonly string _connectionString;

        public LeningMapper()
        {
            _connectionString = "server=localhost;user=root;database=bibliotheek;port=3306;password=1234";
        }

        public void AddLening(int gebruikerid, int boekid, string datumin, string datumout)
        {
            //verbinding maken met de database
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                //sql statement
                MySqlCommand cmd = new MySqlCommand("INSERT INTO tblleningen (gebruikerID, boekID, datumIN, datumUIT) VALUES (@gebruikerid, @boekid, @datumin, @datumout)", conn);
                //toevoegen van de parameters
                cmd.Parameters.AddWithValue("@gebruikerid", gebruikerid);
                cmd.Parameters.AddWithValue("@boekid", boekid);
                cmd.Parameters.AddWithValue("@datumin", datumin);
                cmd.Parameters.AddWithValue("@datumout", datumout);
                //uitvoeren van de query    
                cmd.ExecuteNonQuery();
            }
        }

        public List<Lening> GetLening()
        {
            //instantie van de lijst
            List<Lening> leningen = new List<Lening>();
            //verbinding maken met de database
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                //sql statement
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM tblleningen", conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                //lezen van de gegevens
                while (reader.Read())
                {
                    //instantie van de lening
                    Lening lening = new Lening
                    {
                        LeningID = reader.GetInt32("leningID"),
                        DatumIN = reader.GetString("datumIN"),
                        DatumOUT = reader.GetString("datumUIT"),
                        GebruikerID = reader.GetInt32("gebruikerID"),
                        BoekID = reader.GetInt32("boekID"),

                    };
                    leningen.Add(lening);
                }
            }
            return leningen;

        }

        
    }
}
