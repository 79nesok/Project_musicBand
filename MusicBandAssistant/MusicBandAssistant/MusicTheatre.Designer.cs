namespace MusicBandAssistant
{
    partial class MusicTheatre
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroGrid = new MetroFramework.Controls.MetroGrid();
            this.pContainer = new MetroFramework.Controls.MetroPanel();
            this.pic = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.mabDataSet = new MusicBandAssistant.MabDataSet();
            this.bendInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bendInfoTableAdapter = new MusicBandAssistant.MabDataSetTableAdapters.BendInfoTableAdapter();
            this.muzicarIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kontaktDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jmbgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instrumentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slikaUrlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableAdapterManager = new MusicBandAssistant.MabDataSetTableAdapters.TableAdapterManager();
            this.txtJmbg = new MetroFramework.Controls.MetroTextBox();
            this.txtKontakt = new MetroFramework.Controls.MetroTextBox();
            this.txtPrezime = new MetroFramework.Controls.MetroTextBox();
            this.txtSlikaUrl = new MetroFramework.Controls.MetroTextBox();
            this.txtIme = new MetroFramework.Controls.MetroTextBox();
            this.txtAdresa = new MetroFramework.Controls.MetroTextBox();
            this.txtMuzicarID = new MetroFramework.Controls.MetroTextBox();
            this.instrumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instrumentTableAdapter = new MusicBandAssistant.MabDataSetTableAdapters.InstrumentTableAdapter();
            this.instrumentComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid)).BeginInit();
            this.pContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mabDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bendInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroGrid
            // 
            this.metroGrid.AllowUserToResizeRows = false;
            this.metroGrid.AutoGenerateColumns = false;
            this.metroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.muzicarIDDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.kontaktDataGridViewTextBoxColumn,
            this.jmbgDataGridViewTextBoxColumn,
            this.instrumentIDDataGridViewTextBoxColumn,
            this.slikaUrlDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn});
            this.metroGrid.DataSource = this.bendInfoBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid.EnableHeadersVisualStyles = false;
            this.metroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid.Location = new System.Drawing.Point(-4, 63);
            this.metroGrid.Name = "metroGrid";
            this.metroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid.Size = new System.Drawing.Size(643, 483);
            this.metroGrid.TabIndex = 0;
            this.metroGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid_CellClick);
            // 
            // pContainer
            // 
            this.pContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pContainer.Controls.Add(this.label8);
            this.pContainer.Controls.Add(this.label7);
            this.pContainer.Controls.Add(this.label6);
            this.pContainer.Controls.Add(this.label5);
            this.pContainer.Controls.Add(this.label4);
            this.pContainer.Controls.Add(this.label3);
            this.pContainer.Controls.Add(this.label2);
            this.pContainer.Controls.Add(this.label1);
            this.pContainer.Controls.Add(this.instrumentComboBox);
            this.pContainer.Controls.Add(this.btnBrowse);
            this.pContainer.Controls.Add(this.pic);
            this.pContainer.Controls.Add(this.txtMuzicarID);
            this.pContainer.Controls.Add(this.txtAdresa);
            this.pContainer.Controls.Add(this.txtIme);
            this.pContainer.Controls.Add(this.txtSlikaUrl);
            this.pContainer.Controls.Add(this.txtPrezime);
            this.pContainer.Controls.Add(this.txtKontakt);
            this.pContainer.Controls.Add(this.txtJmbg);
            this.pContainer.HorizontalScrollbarBarColor = true;
            this.pContainer.HorizontalScrollbarHighlightOnWheel = false;
            this.pContainer.HorizontalScrollbarSize = 10;
            this.pContainer.Location = new System.Drawing.Point(645, 63);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(676, 483);
            this.pContainer.TabIndex = 1;
            this.pContainer.VerticalScrollbarBarColor = true;
            this.pContainer.VerticalScrollbarHighlightOnWheel = false;
            this.pContainer.VerticalScrollbarSize = 10;
            // 
            // pic
            // 
            this.pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic.Location = new System.Drawing.Point(30, 22);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(216, 195);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(49, 269);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(128, 44);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseSelectable = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1197, 567);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 47);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1012, 567);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 47);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(834, 567);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 47);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(645, 567);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(124, 47);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(484, 567);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 47);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // mabDataSet
            // 
            this.mabDataSet.DataSetName = "MabDataSet";
            this.mabDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bendInfoBindingSource
            // 
            this.bendInfoBindingSource.DataMember = "BendInfo";
            this.bendInfoBindingSource.DataSource = this.mabDataSet;
            // 
            // bendInfoTableAdapter
            // 
            this.bendInfoTableAdapter.ClearBeforeFill = true;
            // 
            // muzicarIDDataGridViewTextBoxColumn
            // 
            this.muzicarIDDataGridViewTextBoxColumn.DataPropertyName = "MuzicarID";
            this.muzicarIDDataGridViewTextBoxColumn.HeaderText = "MuzicarID";
            this.muzicarIDDataGridViewTextBoxColumn.Name = "muzicarIDDataGridViewTextBoxColumn";
            this.muzicarIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // kontaktDataGridViewTextBoxColumn
            // 
            this.kontaktDataGridViewTextBoxColumn.DataPropertyName = "Kontakt";
            this.kontaktDataGridViewTextBoxColumn.HeaderText = "Kontakt";
            this.kontaktDataGridViewTextBoxColumn.Name = "kontaktDataGridViewTextBoxColumn";
            // 
            // jmbgDataGridViewTextBoxColumn
            // 
            this.jmbgDataGridViewTextBoxColumn.DataPropertyName = "Jmbg";
            this.jmbgDataGridViewTextBoxColumn.HeaderText = "Jmbg";
            this.jmbgDataGridViewTextBoxColumn.Name = "jmbgDataGridViewTextBoxColumn";
            // 
            // instrumentIDDataGridViewTextBoxColumn
            // 
            this.instrumentIDDataGridViewTextBoxColumn.DataPropertyName = "InstrumentID";
            this.instrumentIDDataGridViewTextBoxColumn.HeaderText = "InstrumentID";
            this.instrumentIDDataGridViewTextBoxColumn.Name = "instrumentIDDataGridViewTextBoxColumn";
            // 
            // slikaUrlDataGridViewTextBoxColumn
            // 
            this.slikaUrlDataGridViewTextBoxColumn.DataPropertyName = "SlikaUrl";
            this.slikaUrlDataGridViewTextBoxColumn.HeaderText = "SlikaUrl";
            this.slikaUrlDataGridViewTextBoxColumn.Name = "slikaUrlDataGridViewTextBoxColumn";
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "Adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BendInfoTableAdapter = this.bendInfoTableAdapter;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.InstrumentTableAdapter = this.instrumentTableAdapter;
            this.tableAdapterManager.tbl_Admin_LoginTableAdapter = null;
            this.tableAdapterManager.tblKorisnikTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MusicBandAssistant.MabDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtJmbg
            // 
            // 
            // 
            // 
            this.txtJmbg.CustomButton.Image = null;
            this.txtJmbg.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txtJmbg.CustomButton.Name = "";
            this.txtJmbg.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtJmbg.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtJmbg.CustomButton.TabIndex = 1;
            this.txtJmbg.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtJmbg.CustomButton.UseSelectable = true;
            this.txtJmbg.CustomButton.Visible = false;
            this.txtJmbg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bendInfoBindingSource, "Jmbg", true));
            this.txtJmbg.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtJmbg.Lines = new string[0];
            this.txtJmbg.Location = new System.Drawing.Point(388, 241);
            this.txtJmbg.MaxLength = 32767;
            this.txtJmbg.Name = "txtJmbg";
            this.txtJmbg.PasswordChar = '\0';
            this.txtJmbg.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtJmbg.SelectedText = "";
            this.txtJmbg.SelectionLength = 0;
            this.txtJmbg.SelectionStart = 0;
            this.txtJmbg.ShortcutsEnabled = true;
            this.txtJmbg.Size = new System.Drawing.Size(205, 23);
            this.txtJmbg.TabIndex = 8;
            this.txtJmbg.UseSelectable = true;
            this.txtJmbg.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtJmbg.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtKontakt
            // 
            // 
            // 
            // 
            this.txtKontakt.CustomButton.Image = null;
            this.txtKontakt.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txtKontakt.CustomButton.Name = "";
            this.txtKontakt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtKontakt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKontakt.CustomButton.TabIndex = 1;
            this.txtKontakt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKontakt.CustomButton.UseSelectable = true;
            this.txtKontakt.CustomButton.Visible = false;
            this.txtKontakt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bendInfoBindingSource, "Kontakt", true));
            this.txtKontakt.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtKontakt.Lines = new string[0];
            this.txtKontakt.Location = new System.Drawing.Point(388, 187);
            this.txtKontakt.MaxLength = 32767;
            this.txtKontakt.Name = "txtKontakt";
            this.txtKontakt.PasswordChar = '\0';
            this.txtKontakt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKontakt.SelectedText = "";
            this.txtKontakt.SelectionLength = 0;
            this.txtKontakt.SelectionStart = 0;
            this.txtKontakt.ShortcutsEnabled = true;
            this.txtKontakt.Size = new System.Drawing.Size(205, 23);
            this.txtKontakt.TabIndex = 7;
            this.txtKontakt.UseSelectable = true;
            this.txtKontakt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKontakt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPrezime
            // 
            // 
            // 
            // 
            this.txtPrezime.CustomButton.Image = null;
            this.txtPrezime.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txtPrezime.CustomButton.Name = "";
            this.txtPrezime.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrezime.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrezime.CustomButton.TabIndex = 1;
            this.txtPrezime.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrezime.CustomButton.UseSelectable = true;
            this.txtPrezime.CustomButton.Visible = false;
            this.txtPrezime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bendInfoBindingSource, "Prezime", true));
            this.txtPrezime.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPrezime.Lines = new string[0];
            this.txtPrezime.Location = new System.Drawing.Point(388, 133);
            this.txtPrezime.MaxLength = 32767;
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.PasswordChar = '\0';
            this.txtPrezime.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrezime.SelectedText = "";
            this.txtPrezime.SelectionLength = 0;
            this.txtPrezime.SelectionStart = 0;
            this.txtPrezime.ShortcutsEnabled = true;
            this.txtPrezime.Size = new System.Drawing.Size(205, 23);
            this.txtPrezime.TabIndex = 6;
            this.txtPrezime.UseSelectable = true;
            this.txtPrezime.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrezime.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSlikaUrl
            // 
            // 
            // 
            // 
            this.txtSlikaUrl.CustomButton.Image = null;
            this.txtSlikaUrl.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txtSlikaUrl.CustomButton.Name = "";
            this.txtSlikaUrl.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSlikaUrl.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSlikaUrl.CustomButton.TabIndex = 1;
            this.txtSlikaUrl.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSlikaUrl.CustomButton.UseSelectable = true;
            this.txtSlikaUrl.CustomButton.Visible = false;
            this.txtSlikaUrl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bendInfoBindingSource, "SlikaUrl", true));
            this.txtSlikaUrl.Lines = new string[0];
            this.txtSlikaUrl.Location = new System.Drawing.Point(388, 347);
            this.txtSlikaUrl.MaxLength = 32767;
            this.txtSlikaUrl.Name = "txtSlikaUrl";
            this.txtSlikaUrl.PasswordChar = '\0';
            this.txtSlikaUrl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSlikaUrl.SelectedText = "";
            this.txtSlikaUrl.SelectionLength = 0;
            this.txtSlikaUrl.SelectionStart = 0;
            this.txtSlikaUrl.ShortcutsEnabled = true;
            this.txtSlikaUrl.Size = new System.Drawing.Size(205, 23);
            this.txtSlikaUrl.TabIndex = 10;
            this.txtSlikaUrl.UseSelectable = true;
            this.txtSlikaUrl.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSlikaUrl.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtIme
            // 
            // 
            // 
            // 
            this.txtIme.CustomButton.Image = null;
            this.txtIme.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txtIme.CustomButton.Name = "";
            this.txtIme.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIme.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIme.CustomButton.TabIndex = 1;
            this.txtIme.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIme.CustomButton.UseSelectable = true;
            this.txtIme.CustomButton.Visible = false;
            this.txtIme.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bendInfoBindingSource, "Ime", true));
            this.txtIme.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtIme.Lines = new string[0];
            this.txtIme.Location = new System.Drawing.Point(388, 79);
            this.txtIme.MaxLength = 32767;
            this.txtIme.Name = "txtIme";
            this.txtIme.PasswordChar = '\0';
            this.txtIme.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIme.SelectedText = "";
            this.txtIme.SelectionLength = 0;
            this.txtIme.SelectionStart = 0;
            this.txtIme.ShortcutsEnabled = true;
            this.txtIme.Size = new System.Drawing.Size(205, 23);
            this.txtIme.TabIndex = 5;
            this.txtIme.UseSelectable = true;
            this.txtIme.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIme.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAdresa
            // 
            // 
            // 
            // 
            this.txtAdresa.CustomButton.Image = null;
            this.txtAdresa.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txtAdresa.CustomButton.Name = "";
            this.txtAdresa.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAdresa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAdresa.CustomButton.TabIndex = 1;
            this.txtAdresa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAdresa.CustomButton.UseSelectable = true;
            this.txtAdresa.CustomButton.Visible = false;
            this.txtAdresa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bendInfoBindingSource, "Adresa", true));
            this.txtAdresa.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtAdresa.Lines = new string[0];
            this.txtAdresa.Location = new System.Drawing.Point(388, 401);
            this.txtAdresa.MaxLength = 32767;
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.PasswordChar = '\0';
            this.txtAdresa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdresa.SelectedText = "";
            this.txtAdresa.SelectionLength = 0;
            this.txtAdresa.SelectionStart = 0;
            this.txtAdresa.ShortcutsEnabled = true;
            this.txtAdresa.Size = new System.Drawing.Size(205, 23);
            this.txtAdresa.TabIndex = 11;
            this.txtAdresa.UseSelectable = true;
            this.txtAdresa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAdresa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMuzicarID
            // 
            // 
            // 
            // 
            this.txtMuzicarID.CustomButton.Image = null;
            this.txtMuzicarID.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txtMuzicarID.CustomButton.Name = "";
            this.txtMuzicarID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMuzicarID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMuzicarID.CustomButton.TabIndex = 1;
            this.txtMuzicarID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMuzicarID.CustomButton.UseSelectable = true;
            this.txtMuzicarID.CustomButton.Visible = false;
            this.txtMuzicarID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bendInfoBindingSource, "MuzicarID", true));
            this.txtMuzicarID.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtMuzicarID.Lines = new string[0];
            this.txtMuzicarID.Location = new System.Drawing.Point(388, 25);
            this.txtMuzicarID.MaxLength = 32767;
            this.txtMuzicarID.Name = "txtMuzicarID";
            this.txtMuzicarID.PasswordChar = '\0';
            this.txtMuzicarID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMuzicarID.SelectedText = "";
            this.txtMuzicarID.SelectionLength = 0;
            this.txtMuzicarID.SelectionStart = 0;
            this.txtMuzicarID.ShortcutsEnabled = true;
            this.txtMuzicarID.Size = new System.Drawing.Size(205, 23);
            this.txtMuzicarID.TabIndex = 4;
            this.txtMuzicarID.UseSelectable = true;
            this.txtMuzicarID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMuzicarID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // instrumentBindingSource
            // 
            this.instrumentBindingSource.DataMember = "Instrument";
            this.instrumentBindingSource.DataSource = this.mabDataSet;
            // 
            // instrumentTableAdapter
            // 
            this.instrumentTableAdapter.ClearBeforeFill = true;
            // 
            // instrumentComboBox
            // 
            this.instrumentComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instrumentBindingSource, "Instrument", true));
            this.instrumentComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.instrumentBindingSource, "Instrument", true));
            this.instrumentComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bendInfoBindingSource, "InstrumentID", true));
            this.instrumentComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instrumentComboBox.FormattingEnabled = true;
            this.instrumentComboBox.Location = new System.Drawing.Point(388, 295);
            this.instrumentComboBox.Name = "instrumentComboBox";
            this.instrumentComboBox.Size = new System.Drawing.Size(205, 29);
            this.instrumentComboBox.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Muzicar ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(323, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "IME :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(294, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "PREZIME :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(288, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "KONTAKT  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(313, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 21);
            this.label5.TabIndex = 25;
            this.label5.Text = "JMBG :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(253, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 21);
            this.label6.TabIndex = 26;
            this.label6.Text = "INSTRUMENT :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(274, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 21);
            this.label7.TabIndex = 27;
            this.label7.Text = "SLIKA / Url :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(287, 401);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 21);
            this.label8.TabIndex = 28;
            this.label8.Text = "ADRESA  :";
            // 
            // MusicTheatre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 669);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.metroGrid);
            this.Name = "MusicTheatre";
            this.Text = "MusicTheatre";
            this.Load += new System.EventHandler(this.MusicTheatre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid)).EndInit();
            this.pContainer.ResumeLayout(false);
            this.pContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mabDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bendInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGrid;
        private MetroFramework.Controls.MetroPanel pContainer;
        private MetroFramework.Controls.MetroButton btnBrowse;
        private System.Windows.Forms.PictureBox pic;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MabDataSet mabDataSet;
        private System.Windows.Forms.BindingSource bendInfoBindingSource;
        private MabDataSetTableAdapters.BendInfoTableAdapter bendInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn muzicarIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kontaktDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jmbgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instrumentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slikaUrlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private MabDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MetroFramework.Controls.MetroTextBox txtMuzicarID;
        private MetroFramework.Controls.MetroTextBox txtAdresa;
        private MetroFramework.Controls.MetroTextBox txtIme;
        private MetroFramework.Controls.MetroTextBox txtSlikaUrl;
        private MetroFramework.Controls.MetroTextBox txtPrezime;
        private MetroFramework.Controls.MetroTextBox txtKontakt;
        private MetroFramework.Controls.MetroTextBox txtJmbg;
        private MabDataSetTableAdapters.InstrumentTableAdapter instrumentTableAdapter;
        private System.Windows.Forms.BindingSource instrumentBindingSource;
        private System.Windows.Forms.ComboBox instrumentComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}