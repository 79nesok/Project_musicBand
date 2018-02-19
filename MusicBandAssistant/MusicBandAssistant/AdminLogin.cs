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
    public partial class AdminLogin : MetroFramework.Forms.MetroForm
    {
        string connectionString = @"Data Source=DESKTOP-0GV615K;Initial Catalog = Mab; Integrated Security = True";
        public AdminLogin()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbIme.Text == "" || tbLozinka.Text == "")
                MessageBox.Show("Obavezno popunite polja");
            else if (tbLozinka.Text != tbPonoviLozinku.Text)
                MessageBox.Show("Uneta lozinka nije tacna");
            else
            {
                using (SqlConnection kon = new SqlConnection(connectionString))
                {

                    kon.Open();
                    SqlCommand komanda = new SqlCommand("adminLogin", kon);
                    komanda.CommandType = CommandType.StoredProcedure;
                    komanda.Parameters.AddWithValue("@Ime", tbIme.Text.Trim());
                    komanda.Parameters.AddWithValue("@Lozinka", tbLozinka.Text.Trim());
                    komanda.ExecuteNonQuery();
                    MessageBox.Show("Uspesno ste se Ulogovali kao Administrator");
                    Clear();
                    Client frm = new Client();
                    this.Hide();
                    frm.Show();

                }
            }
            void Clear()
            {
                tbIme.Text = tbLozinka.Text = tbPonoviLozinku.Text = "";

            }
        }
    }
}
