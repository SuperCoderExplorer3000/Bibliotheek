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

    }

}
