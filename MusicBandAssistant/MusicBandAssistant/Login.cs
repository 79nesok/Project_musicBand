using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MusicBandAssistant
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        string connectionString = @"Data Source=DESKTOP-0GV615K;Initial Catalog = Mab; Integrated Security = True";
        public Login()
        {
            InitializeComponent();
            CenterToScreen();
            panel1.Enabled = false;
            panel2.Enabled = false;
        }

        private void btnRegLogin_Click(object sender, EventArgs e)
        {
            if (tbKorisnickoIme.Text == "" || tbLozinka.Text == "")
                MessageBox.Show("Popunite obavezna polja");
            else if (tbLozinka.Text != tbPotvrdiLozinku.Text)
                MessageBox.Show("Uneta lozinka nije tacna");
            else
            {
                using (SqlConnection kon = new SqlConnection(connectionString))
                {

                    kon.Open();
                    SqlCommand komanda = new SqlCommand("dodajKorisnika", kon);
                    komanda.CommandType = CommandType.StoredProcedure;
                    komanda.Parameters.AddWithValue("@Ime", tbIme.Text.Trim());
                    komanda.Parameters.AddWithValue("@Prezime", tbPrezime.Text.Trim());
                    komanda.Parameters.AddWithValue("@Kontakt", tbKontakt.Text.Trim());
                    komanda.Parameters.AddWithValue("@Grad", tbGrad.Text.Trim());
                    komanda.Parameters.AddWithValue("@KorisnickoIme", tbKorisnickoIme.Text.Trim());
                    komanda.Parameters.AddWithValue("@Lozinka", tbLozinka.Text.Trim());
                    komanda.ExecuteNonQuery();
                    MessageBox.Show("Uspesno ste se Ulogovali/registrovali");
                    Clear();

                }
            }
            void Clear()
            {
                tbIme.Text = tbPrezime.Text = tbKontakt.Text = tbGrad.Text = tbKorisnickoIme.Text = tbLozinka.Text = tbPotvrdiLozinku.Text = "";

            }
        }

        private void registracijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            panel2.Enabled = true;
        }

        private void registrovaniKorisniciLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            panel2.Enabled = true;
        }

        private void administratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminLogin frm = new AdminLogin();
            frm.Show();
        }
    }
}
