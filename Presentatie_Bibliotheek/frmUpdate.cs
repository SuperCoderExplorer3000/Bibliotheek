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

    public partial class frmUpdate : Form
    {
        

        public frmUpdate()
        {
            InitializeComponent();

        }

        private void frmUpdate_Load(object sender, EventArgs e)
        {

        }
        Controller _controller = new Controller();
        

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                // Haal het BoekID op uit de textbox
                int boekID = int.Parse(tbBoekID.Text);

                // Haal het bestaande boek op via de controller
                var boek = _controller.GetBoekById(boekID);

                if (boek == null)
                {
                    MessageBox.Show("Boek niet gevonden.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Update alleen de velden die zijn ingevuld
                boek.Titel = string.IsNullOrWhiteSpace(tbTitel.Text) ? boek.Titel : tbTitel.Text;
                boek.Isbn = string.IsNullOrWhiteSpace(tbISBN.Text) ? boek.Isbn : int.Parse(tbISBN.Text);
                boek.Paginas = string.IsNullOrWhiteSpace(tbPaginas.Text) ? boek.Paginas : int.Parse(tbPaginas.Text);
                boek.Genreid = string.IsNullOrWhiteSpace(tbGenreID.Text) ? boek.Genreid : int.Parse(tbGenreID.Text);
                boek.Uitgever = string.IsNullOrWhiteSpace(tbUitgever.Text) ? boek.Uitgever : tbUitgever.Text;
                boek.Auteur = string.IsNullOrWhiteSpace(tbAuteur.Text) ? boek.Auteur : tbAuteur.Text;
                boek.Taal = string.IsNullOrWhiteSpace(tbTaal.Text) ? boek.Taal : tbTaal.Text;
                boek.Graad = string.IsNullOrWhiteSpace(tbGraad.Text) ? boek.Graad : int.Parse(tbGraad.Text);

                // Roep de update-methode aan in de controller
                _controller.UpdateBoek(boek);

                // Meld succes
                MessageBox.Show("Boek succesvol geüpdatet!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Controleer of alle velden correct zijn ingevuld.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Er is een fout opgetreden: {ex.Message}", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();

        }
    }
}
