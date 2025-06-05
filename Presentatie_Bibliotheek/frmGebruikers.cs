using Bibliotheek.business;
using Bibliotheek.persistence;
using Microsoft.VisualBasic;
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
    public partial class frmGebruikers : Form
    {
        public frmGebruikers()
        {
            InitializeComponent();
        }

        private Controller _controller;


        private void frmGebruikers_Load(object sender, EventArgs e)
        {
            try
            {
                _controller = new Controller();
                lbGebruikers.DataSource = _controller.GetGebruikers;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoegToe_Click(object sender, EventArgs e)
        {
            frmGebruikersAdd frm = new frmGebruikersAdd();
            frm.ShowDialog();
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            //hier wil ik werken met een inputbox om de gebruiker te selecteren die verwijderd moet worden
            //input box om het boekID te vragen
            string input = Interaction.InputBox("Voer het GebruikerID in dat u wilt verwijderen:", "Gebruiker Verwijderen", "", -1, -1);
            //boek verwijderen via de controller
            if (int.TryParse(input, out int gebruikerID))
            {
                try
                {
                    _controller.DeleteGebruiker(gebruikerID);
                    lbGebruikers.DataSource = null;
                    lbGebruikers.DataSource = _controller.GetGebruikers;
                    MessageBox.Show("Gebruiker succesvol verwijderd.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Voer een geldig GebruikerID in.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmGebruikersUpdate frm = new frmGebruikersUpdate();
            frm.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Refresh de lijst van gebruikers
            try
            {
                _controller = new Controller();
                lbGebruikers.DataSource = _controller.GetGebruikers;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }
    }
}
