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
    public class GebruikerMapper
    {
        // declaratie van de variabelen
        private readonly string _connectionString;

        public GebruikerMapper()
        {
            _connectionString = "server=localhost;user=root;database=bibliotheek;port=3306;password=1234";
        }

        public bool LogIn(string gebruikersnaam, string wachtwoord)
        {
            // Controleer of de gebruikersnaam en het wachtwoord niet leeg zijn
            if (string.IsNullOrWhiteSpace(gebruikersnaam) || string.IsNullOrWhiteSpace(wachtwoord))
            {
                throw new ArgumentException("Gebruikersnaam en wachtwoord mogen niet leeg zijn.");
            }

            // SQL-query om de gebruiker te zoeken
            string query = "SELECT COUNT(*) FROM tblgebruikers WHERE gebruikersnaam = @gebruikersnaam AND wachtwoord = @wachtwoord";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Voeg parameters toe om SQL-injectie te voorkomen
                        command.Parameters.AddWithValue("@gebruikersnaam", gebruikersnaam);
                        command.Parameters.AddWithValue("@wachtwoord", wachtwoord);

                        // Voer de query uit en controleer of er een match is
                        int count = Convert.ToInt32(command.ExecuteScalar());
                        return count > 0; // True als de gebruiker bestaat, anders false
                    }
                }
            }
            catch (Exception ex)
            {
                // Log de fout of gooi deze opnieuw
                throw new Exception("Er is een fout opgetreden bij het inloggen.", ex);
            }
        }

        public int? GetRechtId(string email, string password)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT rechtID FROM tblgebruikers WHERE gebruikersnaam = @email AND wachtwoord = @password";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);

                    var result = cmd.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int rechtId))
                        return rechtId;
                    else
                        return null;
                }
            }
        }

        // methode voor het weergeven van de gebruiker
        public List<Gebruiker> GetGebruikers()
        {
            //instantie van de lijst
            List<Gebruiker> gebruikers = new List<Gebruiker>();

            //verbinding maken met de database
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                //sql statement
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM tblgebruikers", conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                //lezen van de gegevens
                while (reader.Read())
                {
                    //instantie van de boek
                    Gebruiker gebruiker = new Gebruiker
                    {
                        GebruikerID = reader.GetInt32("gebruikersID"),
                        Gebruikersnaam = reader.GetString("gebruikersnaam"),
                        Naam = reader.GetString("naam"),
                        Voornaam = reader.GetString("voornaam"),
                        Email = reader.GetString("email")
                    };
                    gebruikers.Add(gebruiker);
                }
            }
            return gebruikers;
        }

        // methode voor het toevoegen van een gebruiker

        public void AddGebruiker(string wachtwoord, string gebruikersnaam, string naam, string voornaam, string email, string rechtID)
        {
            // verbinding maken met de database
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                // sql statement
                MySqlCommand cmd = new MySqlCommand("INSERT INTO tblgebruikers (wachtwoord,gebruikersnaam, naam, voornaam, email, rechtID) VALUES (@wachtwoord, @gebruikersnaam, @naam, @voornaam, @email, @rechtID)", conn);
                // toevoegen van de parameters
                cmd.Parameters.AddWithValue("@wachtwoord", wachtwoord);
                cmd.Parameters.AddWithValue("@rechtID", rechtID);
                cmd.Parameters.AddWithValue("@gebruikersnaam", gebruikersnaam);
                cmd.Parameters.AddWithValue("@naam", naam);
                cmd.Parameters.AddWithValue("@voornaam", voornaam);
                cmd.Parameters.AddWithValue("@email", email);
                // uitvoeren van de query
                cmd.ExecuteNonQuery();
            }

        }

        //methode voor het verwijderen van een gebruiker
        public void DeleteGebruiker(int gebruikerID)
        {
            // verbinding maken met de database
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                // sql statement
                MySqlCommand cmd = new MySqlCommand("DELETE FROM tblgebruikers WHERE gebruikersID = @gebruikerID", conn);
                // toevoegen van de parameter
                cmd.Parameters.AddWithValue("@gebruikerID", gebruikerID);
                // uitvoeren van de query
                cmd.ExecuteNonQuery();
            }
        }

        //methode voor het updaten van een gebruiker

        public void UpdateGebruiker(Gebruiker gebruiker)
        {
            string query = "UPDATE tblgebruikers SET " +
                           "wachtwoord = @Wachtwoord, " +
                           "gebruikersnaam = @Gebruikersnaam, " +
                           "naam = @Naam, " +
                           "voornaam = @Voornaam, " +
                           "email = @Email, " +
                           "rechtID = @RechtID " +
                           "WHERE gebruikersID = @GebruikersID";

            using (var connection = new MySqlConnection(_connectionString))
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@GebruikersID", gebruiker.GebruikerID);
                command.Parameters.AddWithValue("@Wachtwoord", gebruiker.Wachtwoord);
                command.Parameters.AddWithValue("@Gebruikersnaam", gebruiker.Gebruikersnaam);
                command.Parameters.AddWithValue("@Naam", gebruiker.Naam);
                command.Parameters.AddWithValue("@Voornaam", gebruiker.Voornaam);
                command.Parameters.AddWithValue("@Email", gebruiker.Email);
                command.Parameters.AddWithValue("@RechtID", gebruiker.RechtID);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public Gebruiker GetGebruikerByID(int gebruikersID)
        {
            string query = "SELECT * FROM tblgebruikers WHERE gebruikersID = @GebruikersID";

            using (var connection = new MySqlConnection(_connectionString))
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@GebruikersID", gebruikersID);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Gebruiker
                        {
                            GebruikerID = reader.GetInt32("gebruikersID"),
                            Wachtwoord = reader["Wachtwoord"].ToString(),
                            Gebruikersnaam = reader["Gebruikersnaam"].ToString(),
                            Naam = reader["Naam"].ToString(),
                            Voornaam = reader["Voornaam"].ToString(),
                            Email = reader["Email"].ToString(),
                            RechtID = int.Parse(reader["RechtID"].ToString())
                            
                        };
                    }
                }
            }
            return null;
        }
    }

}
