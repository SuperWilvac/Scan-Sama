
namespace Application_Lourde_Scan_Sama
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BarreMenu = new System.Windows.Forms.MenuStrip();
            this.Annonces = new System.Windows.Forms.ToolStripMenuItem();
            this.News = new System.Windows.Forms.ToolStripMenuItem();
            this.ScanManga = new System.Windows.Forms.ToolStripMenuItem();
            this.Utilisateur = new System.Windows.Forms.ToolStripMenuItem();
            this.Planning = new System.Windows.Forms.ToolStripMenuItem();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.Annuler = new System.Windows.Forms.Button();
            this.ConfirmerAjout = new System.Windows.Forms.Button();
            this.ConfirmerModif = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GrpBoxScanManga = new System.Windows.Forms.GroupBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Deconnecter = new System.Windows.Forms.Button();
            this.BandeauScan = new System.Windows.Forms.TextBox();
            this.PhotoScan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.EtatScan = new System.Windows.Forms.NumericUpDown();
            this.GenreScan = new System.Windows.Forms.DomainUpDown();
            this.NomScan = new System.Windows.Forms.TextBox();
            this.IdScan = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.BarreMenu.SuspendLayout();
            this.GrpBoxScanManga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EtatScan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 276);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(609, 180);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1936, 1005);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 58);
            this.button1.TabIndex = 2;
            this.button1.Text = "Quitter ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BarreMenu
            // 
            this.BarreMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.BarreMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Annonces,
            this.News,
            this.ScanManga,
            this.Utilisateur,
            this.Planning});
            this.BarreMenu.Location = new System.Drawing.Point(0, 0);
            this.BarreMenu.Name = "BarreMenu";
            this.BarreMenu.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.BarreMenu.Size = new System.Drawing.Size(1443, 35);
            this.BarreMenu.TabIndex = 3;
            this.BarreMenu.Text = "AjoutScan";
            // 
            // Annonces
            // 
            this.Annonces.Name = "Annonces";
            this.Annonces.Size = new System.Drawing.Size(106, 29);
            this.Annonces.Text = "Annonces";
            // 
            // News
            // 
            this.News.Name = "News";
            this.News.Size = new System.Drawing.Size(71, 29);
            this.News.Text = "News";
            // 
            // ScanManga
            // 
            this.ScanManga.Name = "ScanManga";
            this.ScanManga.Size = new System.Drawing.Size(120, 29);
            this.ScanManga.Text = "ScanManga";
            // 
            // Utilisateur
            // 
            this.Utilisateur.Name = "Utilisateur";
            this.Utilisateur.Size = new System.Drawing.Size(106, 29);
            this.Utilisateur.Text = "Utilisateur";
            // 
            // Planning
            // 
            this.Planning.Name = "Planning";
            this.Planning.Size = new System.Drawing.Size(96, 29);
            this.Planning.Text = "Planning";
            // 
            // Ajouter
            // 
            this.Ajouter.Location = new System.Drawing.Point(754, 69);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(173, 96);
            this.Ajouter.TabIndex = 4;
            this.Ajouter.Text = "AjouterScan";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.button2_Click);
            // 
            // Modifier
            // 
            this.Modifier.Location = new System.Drawing.Point(754, 172);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(173, 95);
            this.Modifier.TabIndex = 5;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // Annuler
            // 
            this.Annuler.Location = new System.Drawing.Point(754, 273);
            this.Annuler.Name = "Annuler";
            this.Annuler.Size = new System.Drawing.Size(173, 100);
            this.Annuler.TabIndex = 6;
            this.Annuler.Text = "Annuler";
            this.Annuler.UseVisualStyleBackColor = true;
            this.Annuler.Click += new System.EventHandler(this.Annuler_Click);
            // 
            // ConfirmerAjout
            // 
            this.ConfirmerAjout.Location = new System.Drawing.Point(933, 69);
            this.ConfirmerAjout.Name = "ConfirmerAjout";
            this.ConfirmerAjout.Size = new System.Drawing.Size(173, 95);
            this.ConfirmerAjout.TabIndex = 7;
            this.ConfirmerAjout.Text = "Confirmer";
            this.ConfirmerAjout.UseVisualStyleBackColor = true;
            this.ConfirmerAjout.Click += new System.EventHandler(this.ConfirmerAjout_Click);
            // 
            // ConfirmerModif
            // 
            this.ConfirmerModif.Location = new System.Drawing.Point(933, 170);
            this.ConfirmerModif.Name = "ConfirmerModif";
            this.ConfirmerModif.Size = new System.Drawing.Size(173, 95);
            this.ConfirmerModif.TabIndex = 8;
            this.ConfirmerModif.Text = "Confirmer";
            this.ConfirmerModif.UseVisualStyleBackColor = true;
            this.ConfirmerModif.Click += new System.EventHandler(this.ConfirmerModif_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Id Scan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nom Scan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Genre Scan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Etat Scan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Photo Scan";
            // 
            // GrpBoxScanManga
            // 
            this.GrpBoxScanManga.Controls.Add(this.checkBox5);
            this.GrpBoxScanManga.Controls.Add(this.checkBox3);
            this.GrpBoxScanManga.Controls.Add(this.checkBox2);
            this.GrpBoxScanManga.Controls.Add(this.checkBox1);
            this.GrpBoxScanManga.Controls.Add(this.Deconnecter);
            this.GrpBoxScanManga.Controls.Add(this.BandeauScan);
            this.GrpBoxScanManga.Controls.Add(this.PhotoScan);
            this.GrpBoxScanManga.Controls.Add(this.label7);
            this.GrpBoxScanManga.Controls.Add(this.EtatScan);
            this.GrpBoxScanManga.Controls.Add(this.GenreScan);
            this.GrpBoxScanManga.Controls.Add(this.NomScan);
            this.GrpBoxScanManga.Controls.Add(this.IdScan);
            this.GrpBoxScanManga.Controls.Add(this.label1);
            this.GrpBoxScanManga.Controls.Add(this.ConfirmerModif);
            this.GrpBoxScanManga.Controls.Add(this.ConfirmerAjout);
            this.GrpBoxScanManga.Controls.Add(this.label2);
            this.GrpBoxScanManga.Controls.Add(this.Annuler);
            this.GrpBoxScanManga.Controls.Add(this.label5);
            this.GrpBoxScanManga.Controls.Add(this.Modifier);
            this.GrpBoxScanManga.Controls.Add(this.label3);
            this.GrpBoxScanManga.Controls.Add(this.Ajouter);
            this.GrpBoxScanManga.Controls.Add(this.label4);
            this.GrpBoxScanManga.Location = new System.Drawing.Point(236, 464);
            this.GrpBoxScanManga.Name = "GrpBoxScanManga";
            this.GrpBoxScanManga.Size = new System.Drawing.Size(1158, 536);
            this.GrpBoxScanManga.TabIndex = 15;
            this.GrpBoxScanManga.TabStop = false;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(466, 287);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(22, 21);
            this.checkBox5.TabIndex = 32;
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(466, 166);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(22, 21);
            this.checkBox3.TabIndex = 30;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(466, 121);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(22, 21);
            this.checkBox2.TabIndex = 29;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(466, 71);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(22, 21);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Deconnecter
            // 
            this.Deconnecter.Location = new System.Drawing.Point(933, 278);
            this.Deconnecter.Name = "Deconnecter";
            this.Deconnecter.Size = new System.Drawing.Size(173, 95);
            this.Deconnecter.TabIndex = 27;
            this.Deconnecter.Text = "Deconnecter";
            this.Deconnecter.UseVisualStyleBackColor = true;
            this.Deconnecter.Click += new System.EventHandler(this.Deconnecter_Click);
            // 
            // BandeauScan
            // 
            this.BandeauScan.Location = new System.Drawing.Point(131, 342);
            this.BandeauScan.Name = "BandeauScan";
            this.BandeauScan.Size = new System.Drawing.Size(329, 31);
            this.BandeauScan.TabIndex = 26;
            this.BandeauScan.TextChanged += new System.EventHandler(this.BandeauScan_TextChanged);
            // 
            // PhotoScan
            // 
            this.PhotoScan.Location = new System.Drawing.Point(131, 285);
            this.PhotoScan.Name = "PhotoScan";
            this.PhotoScan.Size = new System.Drawing.Size(329, 31);
            this.PhotoScan.TabIndex = 25;
            this.PhotoScan.TextChanged += new System.EventHandler(this.PhotoScan_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "Bandeau Scan";
            // 
            // EtatScan
            // 
            this.EtatScan.Location = new System.Drawing.Point(131, 224);
            this.EtatScan.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EtatScan.Name = "EtatScan";
            this.EtatScan.Size = new System.Drawing.Size(180, 31);
            this.EtatScan.TabIndex = 23;
            this.EtatScan.ValueChanged += new System.EventHandler(this.EtatScan_ValueChanged);
            // 
            // GenreScan
            // 
            this.GenreScan.Location = new System.Drawing.Point(131, 164);
            this.GenreScan.Name = "GenreScan";
            this.GenreScan.Size = new System.Drawing.Size(329, 31);
            this.GenreScan.TabIndex = 22;
            this.GenreScan.Text = "Shonen, Shojo, Seinen...";
            this.GenreScan.SelectedItemChanged += new System.EventHandler(this.GenreScan_SelectedItemChanged);
            // 
            // NomScan
            // 
            this.NomScan.Location = new System.Drawing.Point(131, 115);
            this.NomScan.Name = "NomScan";
            this.NomScan.Size = new System.Drawing.Size(329, 31);
            this.NomScan.TabIndex = 16;
            this.NomScan.TextChanged += new System.EventHandler(this.NomScan_TextChanged);
            // 
            // IdScan
            // 
            this.IdScan.Location = new System.Drawing.Point(131, 69);
            this.IdScan.Name = "IdScan";
            this.IdScan.Size = new System.Drawing.Size(329, 31);
            this.IdScan.TabIndex = 15;
            this.IdScan.TextChanged += new System.EventHandler(this.IdScan_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1037, 225);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1443, 1050);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GrpBoxScanManga);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BarreMenu);
            this.MainMenuStrip = this.BarreMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Application Scan-Sama";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.BarreMenu.ResumeLayout(false);
            this.BarreMenu.PerformLayout();
            this.GrpBoxScanManga.ResumeLayout(false);
            this.GrpBoxScanManga.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EtatScan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip BarreMenu;
        private System.Windows.Forms.ToolStripMenuItem Annonces;
        private System.Windows.Forms.ToolStripMenuItem News;
        private System.Windows.Forms.ToolStripMenuItem ScanManga;
        private System.Windows.Forms.ToolStripMenuItem Utilisateur;
        private System.Windows.Forms.ToolStripMenuItem Planning;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button Annuler;
        private System.Windows.Forms.Button ConfirmerAjout;
        private System.Windows.Forms.Button ConfirmerModif;
        private System.Windows.Forms.ToolStripMenuItem Annonce;
        private System.Windows.Forms.ToolStripMenuItem Scan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox GrpBoxScanManga;
        private System.Windows.Forms.TextBox NomScan;
        private System.Windows.Forms.TextBox IdScan;
        private System.Windows.Forms.DomainUpDown GenreScan;
        private System.Windows.Forms.NumericUpDown EtatScan;
        private System.Windows.Forms.TextBox BandeauScan;
        private System.Windows.Forms.TextBox PhotoScan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Deconnecter;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

