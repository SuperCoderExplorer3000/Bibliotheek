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
    public partial class frmVoegToe : Form
    {
        public frmVoegToe()
        {
            InitializeComponent();
             // Replace with the actual initialization logic.
        }
        Controller _controller = new Controller();

        private void btnAddBoek_Click(object sender, EventArgs e)
        {
            string titel = tbTitel.Text;
            string uitgever = tbUitgever.Text;
            string auteur = tbAuteur.Text;
            string taal = tbTaal.Text;

            if (!int.TryParse(tbISBN.Text, out int isbn))
            {
                MessageBox.Show("Voer een geldig ISBN-nummer in.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(tbPaginas.Text, out int paginas))
            {
                MessageBox.Show("Voer een geldig aantal pagina's in.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(tbGenreID.Text, out int genreID))
            {
                MessageBox.Show("Voer een geldige genre ID in.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(tbGraad.Text, out int graad))
            {
                MessageBox.Show("Voer een geldige graad in.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _controller.AddBoek(isbn, paginas, titel, genreID, uitgever, auteur, taal, graad);
            _controller.RefreshList();
            this.DialogResult = DialogResult.OK;

            MessageBox.Show("het boek: " + titel + "is toegevoegd");
        }
    }
}
