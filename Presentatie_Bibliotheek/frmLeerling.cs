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
    public partial class frmLeerling : Form
    {
        public frmLeerling()
        {
            InitializeComponent();
        }

        private Controller _controller;
        private void frmLeerling_Load(object sender, EventArgs e)
        {
            try
            {
                _controller = new Controller();
                lbOverzicht.DataSource = _controller.GetBoeken;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            // Filter de lijst van boeken op basis van de zoekterm
            string searchTerm = tbSearch.Text.ToLower();
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                lbOverzicht.DataSource = _controller.GetBoeken; // Toon alle boeken als de zoekterm leeg is
            }
            else
            {
                var boekengefilterd = _controller.GetBoeken
                    .Where(b => b.Titel.ToLower().Contains(searchTerm) ||
                                b.Auteur.ToLower().Contains(searchTerm) ||
                                b.Uitgever.ToLower().Contains(searchTerm) ||
                                b.Taal.ToLower().Contains(searchTerm))
                    .ToList();
                lbOverzicht.DataSource = boekengefilterd; // Toon de gefilterde lijst
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                _controller = new Controller();
                lbOverzicht.DataSource = _controller.GetBoeken;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUitloggen_Click(object sender, EventArgs e)
        {
            //sluit het huidige formulier en gaat terug naar het inlogscherm
            this.Close();
            Form1 loginForm = new Form1();
            loginForm.Show();
        }

        private void btnLenen_Click(object sender, EventArgs e)
        {
            LeningLeerling frm = new LeningLeerling();
           frm.Show();
        }
    }
}
