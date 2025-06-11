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
using Bibliotheek.persistence; // Zorg ervoor dat deze namespace correct is, afhankelijk van je projectstructuur
using Bibliotheek.business; // Zorg ervoor dat deze namespace correct is, afhankelijk van je projectstructuur

namespace Presentatie_Bibliotheek
{
    public partial class LeningLeerling : Form
    {
        public LeningLeerling()
        {
            InitializeComponent();
        }

        Controller _controller = new Controller();
        private void btnLeen_Click(object sender, EventArgs e)
        {
            string datumin = dtpIn.Value.ToString("yyyy-MM-dd");
            string datumout = dtpOut.Value.ToString("yyyy-MM-dd");
            int gebruikerID = Convert.ToInt32(tbGebruikerID.Text);
            int boekID = Convert.ToInt32(tbBoekID.Text);

            try
            {
                _controller.AddLening(gebruikerID, boekID, datumin, datumout);
                MessageBox.Show("De lening is toegevoegd.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; // Optioneel: sluit het formulier met een OK-resultaat
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het toevoegen van de lening: " + ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
