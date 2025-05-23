using Bibliotheek.business;
using Microsoft.VisualBasic.Logging;
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
    public partial class Leeraar : Form
    {
        public Leeraar()
        {
            InitializeComponent();
        }
        private Controller _controller;
        private void Leeraar_Load(object sender, EventArgs e)
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

        private void btnBoekToevoegen_Click(object sender, EventArgs e)
        {
            frmVoegToe frmAdd = new frmVoegToe();

            if (frmAdd.ShowDialog() == DialogResult.OK)
            {
                lbOverzicht.DataSource = null;
                lbOverzicht.DataSource = _controller.GetBoeken;
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
    }
}
