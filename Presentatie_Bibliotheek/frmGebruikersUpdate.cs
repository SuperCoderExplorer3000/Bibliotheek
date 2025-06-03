using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibliotheek.business;
using Bibliotheek.persistence;

namespace Presentatie_Bibliotheek
{
    public partial class frmGebruikersUpdate : Form
    {
        public frmGebruikersUpdate()
        {
            InitializeComponent();
        }

        Controller _controller = new Controller();

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Haal het GebruikerID op uit de textbox
                int gebruikerID = int.Parse(tbGebruikersID.Text);
                // Haal de bestaande gebruiker op via de controller
                var gebruiker = _controller.GetGebruikerById(gebruikerID);
                if (gebruiker == null)
                {
                    MessageBox.Show("Gebruiker niet gevonden.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Update alleen de velden die zijn ingevuld
                gebruiker.Naam = string.IsNullOrWhiteSpace(tbNaam.Text) ? gebruiker.Naam : tbNaam.Text;
                gebruiker.Gebruikersnaam = string.IsNullOrWhiteSpace(tbGebruikersnaam.Text) ? gebruiker.Gebruikersnaam : tbGebruikersnaam.Text;
                gebruiker.Voornaam = string.IsNullOrWhiteSpace(tbVoornaam.Text) ? gebruiker.Voornaam : tbVoornaam.Text;
                gebruiker.Email = string.IsNullOrWhiteSpace(tbEmail.Text) ? gebruiker.Email : tbEmail.Text;
                gebruiker.Wachtwoord = string.IsNullOrWhiteSpace(tbWachtwoord.Text) ? gebruiker.Wachtwoord : tbWachtwoord.Text;
                
                gebruiker.RechtID = string.IsNullOrWhiteSpace(tbRechtID.Text) ? gebruiker.RechtID : int.Parse(tbRechtID.Text);
               
                // Roep de update-methode aan in de controller
                _controller.UpdateGebruiker(gebruiker);
                MessageBox.Show("Gebruiker succesvol bijgewerkt.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
