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
    }
}
