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
using Net.Code.ADONet;

namespace MusicBandAssistant
{
    public partial class MusicTheatre : MetroFramework.Forms.MetroForm
    {
        //Set default state
        EntityState objState = EntityState.Unchanged;
        public MusicTheatre()
        {
            InitializeComponent();
        }

        private void MusicTheatre_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mabDataSet.Instrument' table. You can move, or remove it, as needed.
            this.instrumentTableAdapter.Fill(this.mabDataSet.Instrument);
            // TODO: This line of code loads data into the 'mabDataSet.BendInfo' table. You can move, or remove it, as needed.
            this.bendInfoTableAdapter.Fill(this.mabDataSet.BendInfo);
            //Connect to sql database
            using (var db = Db.FromConfig("cn"))
            {
                bendInfoBindingSource.DataSource = db.Sql("select *from BendInfo").AsEnumerable<Muzicar>();
            }
            pContainer.Enabled = false;
            Muzicar obj = bendInfoBindingSource.Current as Muzicar;
            if (obj != null)
            {
                if (!string.IsNullOrEmpty(obj.SlikaUrl))
                    pic.Image = Image.FromFile(obj.SlikaUrl);//Load image to PictureBox
            }

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg|PNG|*.png", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pic.Image = Image.FromFile(ofd.FileName);
                    //Get current object
                    Muzicar obj = bendInfoBindingSource.Current as Muzicar;
                    if (obj != null)
                        obj.SlikaUrl = ofd.FileName;
                }
            }
        }
        void ClearInput()
        {
            txtMuzicarID.Text = null;
            txtIme.Text = null;
            txtPrezime.Text = null;
            txtKontakt.Text = null;
            txtJmbg.Text = null;
            instrumentComboBox.Text = null;
            pic.Image = null;
            txtAdresa.Text= null;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            objState = EntityState.Added;
            pic.Image = null;
            pContainer.Enabled = true;
            bendInfoBindingSource.Add(new Muzicar());
            bendInfoBindingSource.MoveLast();
            txtIme.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            objState = EntityState.Changed;
            pContainer.Enabled = true;
            txtIme.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                objState = EntityState.Deleted;
                try
                {
                    Muzicar obj = bendInfoBindingSource.Current as Muzicar;
                    if (obj != null)
                    {
                        using (var db = Db.FromConfig("cn"))
                        {
                            db.Sql("delete from BendInfo where MuzicarID = @MuzicarID").WithParameters(new { MuzicarID = obj.MuzicarID }).AsNonQuery();
                            bendInfoBindingSource.RemoveCurrent();
                            pContainer.Enabled = false;
                            ClearInput();
                            objState = EntityState.Unchanged;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pContainer.Enabled = false;
            //Reset binding source
            bendInfoBindingSource.ResetBindings(false);
            this.MusicTheatre_Load(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                bendInfoBindingSource.EndEdit();
                //Get current object
                Muzicar obj = bendInfoBindingSource.Current as Muzicar;
                if (obj != null)
                {
                    using (var db = Db.FromConfig("cn"))
                    {
                        if (objState == EntityState.Added)
                        {
                            //Execute sql insert query
                            obj.MuzicarID = db.Sql("insert into BendInfo(Ime, Prezime, Kontakt, Jmbg, SlikaUrl,Adresa, InstrumentID) values(@Ime, @Prezime, @Kontakt,@InstrumentID, @Jmbg, @SlikaUrl, @InstrumentID);select SCOPE_IDENTITY()").WithParameters(new { Ime = obj.Ime, Prezime = obj.Prezime, Jmbg = obj.Jmbg, SlikaUrl = obj.SlikaUrl, Kontakt = obj.Kontakt, InstrumentID = obj.InstrumentID }).AsScalar<int>();
                        }
                        else if (objState == EntityState.Changed)
                        {
                            //Execute stored procedure update
                            db.StoredProcedure("MuzicariUpdate").WithParameters(new { MuzicarID = obj.MuzicarID, Ime = obj.Ime, InstrumentID = obj.InstrumentID, Prezime = obj.Prezime, Jmbg = obj.Jmbg, SlikaUrl = obj.SlikaUrl, Kontakt = obj.Kontakt,Adresa=obj.Adresa }).AsNonQuery();
                        }
                        metroGrid.Refresh();
                        pContainer.Enabled = false;
                        objState = EntityState.Unchanged;
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Muzicar obj = bendInfoBindingSource.Current as Muzicar;//Get current object
            if (obj != null)
            {
                if (!string.IsNullOrEmpty(obj.SlikaUrl))
                    pic.Image = Image.FromFile(obj.SlikaUrl);//Load image to PictureBox
            }
        }
    }
}


