using Bibliotheek.business;
using Bibliotheek.persistence;
using MySql.Data.MySqlClient;

namespace Presentatie_Bibliotheek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private Controller _controller = new Controller();




        private void LogIn_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // rechten systeem
            string email = tbNaam.Text;
            string password = tbWachtwoord.Text;

            var _gebruikermapper = new Bibliotheek.persistence.GebruikerMapper();
            int? rechtId = _gebruikermapper.GetRechtId(email, password);

            if (rechtId.HasValue)
            {
                MessageBox.Show("Login successful!");
                Form nextForm = rechtId switch
                {
                    1 => new frmLeerling(),
                    2 => new Leeraar(),
                    _ => null
                };
                if (nextForm != null)
                {
                    nextForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Unknown RechtID.");
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}