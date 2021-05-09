using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//ajouter la librairie mysql
using MySql.Data.MySqlClient;


namespace Application_Lourde_Scan_Sama
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            ConfirmerAjout.Enabled = false;
            ConfirmerModif.Enabled = false;
            IdScan.Enabled = false;
            NomScan.Enabled = false;
            GenreScan.Enabled = false;
            EtatScan.Enabled = false;
            PhotoScan.Enabled = false;
            BandeauScan.Enabled = false;
            
        }
        MySqlConnection connect;
        private void button2_Click(object sender, EventArgs e)
        {
            if (ConfirmerModif.Enabled == false)
            {
               
                connect = new MySqlConnection("Data Source = localhost; Initial Catalog = scansama; User Id = root; Password = ;");

                
                IdScan.Enabled = true;
                NomScan.Enabled = true;
                GenreScan.Enabled = true;
                EtatScan.Enabled = true;
                PhotoScan.Enabled = true;
                BandeauScan.Enabled = true;

                while (checkBox1.Checked == checkBox2.Checked == checkBox3.Checked == checkBox5.Checked == true)
                {
                    if (IdScan.Text == "")
                    {
                        checkBox1.Checked = false;
                    }
                    else
                    {
                        checkBox1.Checked = true;
                    }
                    if (NomScan.Text == "")
                    {
                        checkBox2.Checked = false;
                    }
                    else
                    {
                        checkBox2.Checked = true;
                    }
                    if (GenreScan.Text == "")
                    {
                        checkBox3.Checked = false;
                    }
                    else
                    {
                        checkBox3.Checked = true;
                    }
                    if (PhotoScan.Text == "")
                    {
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        checkBox5.Checked = true;
                    }
                }
                if (checkBox1.Checked == checkBox2.Checked == checkBox3.Checked == checkBox5.Checked == true)
                {
                    ConfirmerAjout.Enabled = true;
                }

            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            if (ConfirmerAjout.Enabled == false)
            {
                IdScan.Enabled = true;
                NomScan.Enabled = true;
                GenreScan.Enabled = true;
                EtatScan.Enabled = true;
                PhotoScan.Enabled = true;
                BandeauScan.Enabled = true;
            }

            while (checkBox1.Checked == checkBox2.Checked == checkBox3.Checked == checkBox5.Checked == true)
            {
                if (IdScan.Text == "")
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
                if (NomScan.Text == "")
                {
                    checkBox2.Checked = false;
                }
                else
                {
                    checkBox2.Checked = true;
                }
                if (GenreScan.Text == "")
                {
                    checkBox3.Checked = false;
                }
                else
                {
                    checkBox3.Checked = true;
                }
                if (PhotoScan.Text == "")
                {
                    checkBox5.Checked = false;
                }
                else
                {
                    checkBox5.Checked = true;
                }
            }
            if (checkBox1.Checked == checkBox2.Checked == checkBox3.Checked == checkBox5.Checked == true) {
                ConfirmerModif.Enabled = true; }
        }

        private void ConfirmerAjout_Click(object sender, EventArgs e)
        {
            

            ConfirmerAjout.Enabled = false;
            IdScan.Enabled = false;
            NomScan.Enabled = false;
            GenreScan.Enabled = false;
            EtatScan.Enabled = false;
            PhotoScan.Enabled = false;
            BandeauScan.Enabled = false;


            MySqlCommand cmd = new MySqlCommand("insert into employe values('" + IdScan.Text + "', '" + NomScan.Text + "', '" + GenreScan.Text + "' + '" + EtatScan.Value + "', '" + PhotoScan.Text + "', '" + BandeauScan);
            
        }

        private void ConfirmerModif_Click(object sender, EventArgs e)
        {

            ConfirmerModif.Enabled = false;
            IdScan.Enabled = false;
            NomScan.Enabled = false;
            GenreScan.Enabled = false;
            EtatScan.Enabled = false;
            PhotoScan.Enabled = false;
            BandeauScan.Enabled = false;
        }

        private void IdScan_TextChanged(object sender, EventArgs e)
        {

        }

        private void NomScan_TextChanged(object sender, EventArgs e)
        {

        }

        private void GenreScan_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void EtatScan_ValueChanged(object sender, EventArgs e)
        {

        }

        private void PhotoScan_TextChanged(object sender, EventArgs e)
        {

        }

        private void BandeauScan_TextChanged(object sender, EventArgs e)
        {

        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            IdScan.Text = "";
            NomScan.Text = "";
            GenreScan.Text = "";
            EtatScan.Text = "";
            PhotoScan.Text = "";
            BandeauScan.Text = "";

            ConfirmerAjout.Enabled = false;
            ConfirmerModif.Enabled = false;
            IdScan.Enabled = false;
            NomScan.Enabled = false;
            GenreScan.Enabled = false;
            EtatScan.Enabled = false;
            PhotoScan.Enabled = false;
            BandeauScan.Enabled = false;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Préparation de la connexion à la base de données
            string connectionString = "Data Source=localhost;Initial Catalog=scansama;User Id=root;Password=;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand();
            MySqlDataReader reader;
        }

        private void Deconnecter_Click(object sender, EventArgs e)
        {
            connect.Close();
        }
    }
}
