using Bibliotheek.business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; 
using MySql.Data;
using MySql;
using Bibliotheek.business;

namespace Bibliotheek.persistence
{
    public class BoekMapper
    {
        // declaratie van de variabelen
        private readonly string _connectionString;

        public BoekMapper()
        {
            _connectionString = "server=localhost;user=root;database=bibliotheek;port=3306;password=1234";
        }

        //Methode voor het weergeven van de boeken

        public List<Boek> GetBoeken()
        {
            //instantie van de lijst
            List<Boek> boeken = new List<Boek>();

            //verbinding maken met de database
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                //sql statement
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM tblboeken", conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                //lezen van de gegevens
                while (reader.Read())
                {
                    //instantie van de boek
                    Boek boek = new Boek
                    {
                        Boekid = reader.GetInt32("boekID"),
                        Titel = reader.GetString("titel"),
                        Auteur = reader.GetString("auteur"),
                    };
                    boeken.Add(boek);
                }
            }
            return boeken;
        }

        //Methode voor het toevoegen van een boek

        public void AddBoek(int ISBN, int paginas, string titel, int genreID, string uitgever, string auteur, string taal, int graad)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("INSERT INTO tblboeken (isbn, paginas, titel, genreid, uitgever, auteur, taal, graad) VALUES (@ISBN, @paginas, @titel, @genreID, @uitgever, @auteur, @taal, @graad)", connection);
                command.Parameters.AddWithValue("@ISBN", ISBN);
                command.Parameters.AddWithValue("@paginas", paginas);
                command.Parameters.AddWithValue("@titel", titel);
                command.Parameters.AddWithValue("@genreID", genreID);
                command.Parameters.AddWithValue("@uitgever", uitgever);
                command.Parameters.AddWithValue("@auteur", auteur);
                command.Parameters.AddWithValue("@taal", taal);
                command.Parameters.AddWithValue("@graad", graad);

                command.ExecuteNonQuery();
            }
        }

        public void UpdateBoek(Boek boek)
        {
            string query = "UPDATE tblboeken SET " +
                           "titel = @Titel, " +
                           "ISBN = @ISBN, " +
                           "paginas = @Paginas, " +
                           "genreID = @GenreID, " +
                           "uitgever = @Uitgever, " +
                           "auteur = @Auteur, " +
                           "taal = @Taal, " +
                           "graad = @Graad " +
                           "WHERE boekID = @BoekID";

            using (var connection = new MySqlConnection(_connectionString))
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@BoekID", boek.Boekid);
                command.Parameters.AddWithValue("@Titel", boek.Titel);
                command.Parameters.AddWithValue("@ISBN", boek.Isbn);
                command.Parameters.AddWithValue("@Paginas", boek.Paginas);
                command.Parameters.AddWithValue("@GenreID", boek.Genreid);
                command.Parameters.AddWithValue("@Uitgever", boek.Uitgever);
                command.Parameters.AddWithValue("@Auteur", boek.Auteur);
                command.Parameters.AddWithValue("@Taal", boek.Taal);
                command.Parameters.AddWithValue("@Graad", boek.Graad);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }


        public Boek GetBoekById(int boekID)
        {
            string query = "SELECT * FROM tblboeken WHERE boekID = @BoekID";

            using (var connection = new MySqlConnection(_connectionString))
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@BoekID", boekID);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Boek
                        {
                            Boekid = boekID,
                            Titel = reader["Titel"].ToString(),
                            Isbn = int.Parse(reader["ISBN"].ToString()),
                            Paginas = int.Parse(reader["Paginas"].ToString()),
                            Genreid = int.Parse(reader["GenreID"].ToString()),
                            Uitgever = reader["Uitgever"].ToString(),
                            Auteur = reader["Auteur"].ToString(),
                            Taal = reader["Taal"].ToString(),
                            Graad = int.Parse(reader["Graad"].ToString())
                        };
                    }
                }
            }
            return null;
        }

        //Methode voor het verwijderen van een boek

        public void DeleteBoek(int boekID)
        {
            using (var connection = new MySqlConnection(_connectionString))
            using (var command = new MySqlCommand("DELETE FROM tblboeken WHERE boekID = @BoekID", connection))
            {
                command.Parameters.AddWithValue("@BoekID", boekID);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
