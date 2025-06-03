using Bibliotheek.business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentatie_Bibliotheek
{
    public partial class frmGebruikersAdd : Form
    {
        public frmGebruikersAdd()
        {
            InitializeComponent();
        }

        private Controller _controller = new Controller();

        private void button1_Click(object sender, EventArgs e)
        {
            string wachtwoord = tbWachtwoord.Text;  
            string gebruikersnaam = tbGebruikersnaam.Text;
            string naam = tbNaam.Text;
            string voornaam = tbVoornaam.Text;  
            string email = tbEmail.Text;

            if (!int.TryParse(tbRechtID.Text, out int rechtID))
            {
                MessageBox.Show("Voer een geldig recht ID in.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _controller.AddGebruiker(naam, gebruikersnaam, voornaam, email, wachtwoord, rechtID.ToString());
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("De gebruiker: " + gebruikersnaam + " is toegevoegd.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
