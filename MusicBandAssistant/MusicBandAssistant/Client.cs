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
    public partial class Client : MetroFramework.Forms.MetroForm
    {
        SqlConnection konekcija = new SqlConnection(Konekcija.kon);
        public Client()
        {
            InitializeComponent();
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
        }
    

        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mabDataSet);

        }

        private void Client_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mabDataSet.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.mabDataSet.Clients);

        }
        private void btnBrisi_Click(object sender, EventArgs e)
        {
            if (clientsDataGridView.SelectedRows.Count > 0)
            {
                try
                {
                    int index = clientsDataGridView.SelectedRows[0].Index;
                    int KlijentID = int.Parse(clientsDataGridView[0, index].Value.ToString());
                    string Ime = clientsDataGridView[1, index].Value.ToString();
                    int god = int.Parse(clientsDataGridView[2, index].Value.ToString());
                    string Termin = clientsDataGridView[3, index].Value.ToString();
                    clientsTableAdapter.Delete(KlijentID, Ime, god, Termin);
                    clientsDataGridView.Rows.RemoveAt(index); MessageBox.Show("uspesno obrisano");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else
            {
                MessageBox.Show("niste uspeli da obrisete");
            }
        }





        private void btnResetuj_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = "";
            radioButton1.Checked = radioButton2.Checked = radioButton3.Checked = radioButton4.Checked =radioButton5.Checked = radioButton6.Checked = radioButton7.Checked = radioButton8.Checked=radioButton9.Checked = radioButton10.Checked = radioButton11.Checked = radioButton12.Checked = false;
        }




        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = true;
            SqlDataAdapter dt = new SqlDataAdapter("select distinct Termin from Clients", konekcija); DataTable td = new DataTable(); dt.Fill(td);
            comboBox1.DataSource = td;
            comboBox1.DisplayMember = "Termin";
        }

        



        private void btnDodaj_Click_1(object sender, EventArgs e)
        {
            string s = "";
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            { if (radioButton1.Checked == true)
                { s = "Januar"; }
                if (radioButton2.Checked == true)
                { s = "Februar"; }
                if (radioButton3.Checked == true)
                { s = "Mart"; }
                if (radioButton4.Checked == true)
                { s = "April"; }
                if (radioButton5.Checked == true)
                { s = "Maj"; }
                if (radioButton6.Checked == true)
                { s = "Jun"; }
                if (radioButton7.Checked == true)
                { s = "Jul"; }
                if (radioButton8.Checked == true)
                { s = "Avgust"; }
                if (radioButton9.Checked == true)
                { s = "septemmbar"; }
                if (radioButton10.Checked == true)
                { s = "Oktobar"; }
                if (radioButton11.Checked == true)
                { s = "Novembar"; }
                if (radioButton12.Checked == true)
                { s = "Decembar"; }

                clientsTableAdapter.Insert(Convert.ToInt32(textBox1.Text), 
                    textBox2.Text, Convert.ToInt32(textBox3.Text), s);
                this.clientsTableAdapter.Fill(this.mabDataSet.Clients); }
            else { MessageBox.Show("morate uneti sva polja"); }
        }

        private void omoguciteUnosNovogKlijentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = false;
        }

        private void btnOmoguciUnos_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            konekcija.Open();
            try
            {
                using (SqlCommand koman = new SqlCommand("select Ime from Clients where Termin=@Termin", konekcija))
                {
                    koman.Parameters.Add(new SqlParameter("Termin", comboBox1.Text));
                    SqlDataReader rid = koman.ExecuteReader();
                    while (rid.Read())
                    {
                        richTextBox1.AppendText(rid.GetString(0));
                        richTextBox1.AppendText("\r\n");
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            konekcija.Close();
        }

        private void clanoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            MusicTheatre Grupa = new MusicTheatre();
           
            
            Grupa.Show();
        }
    }
}

