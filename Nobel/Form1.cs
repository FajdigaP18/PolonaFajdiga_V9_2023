using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Nobel
{
    public partial class Form1 : Form
    {
        //private string povNiz = @"Data Source = C:\Users\Polona\Desktop\Prak_mat\Prog\PolonaFajdiga_V9_2023\Nobel\nobelDB.db";
        private string povNiz =  "Server= baza.fmf.uni-lj.si; User Id= student11; Password= student; Database= nobel2012;";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vnesite leto in izberite kategorijo!");
        }

        private void poisci_Click(object sender, EventArgs e)
        {
            rezultati.Items.Add("TUKAJ BODO PRIKAZANI REZULTATI ISKANJA");
            NpgsqlConnection povezava = new NpgsqlConnection(povNiz);

            if (leto.Text == "" || podrocja.Text == "")
            {
                MessageBox.Show("Vnesi vse podatke!");
                return;
            }
            try
            {
                povezava.Open();
                int letnica = int.Parse(leto.Text);
                string kategorija = podrocja.Text;
                NpgsqlCommand ukaz = new NpgsqlCommand("SELECT * FROM Nobel");
                NpgsqlDataReader rez = ukaz.ExecuteReader();
                while (rez.Read())
                {
                    if (rez.GetInt32(0) == letnica && rez.GetString(1) == kategorija)
                    {
                        rezultati.Items.Add($"{rez.GetString(2)} je zmagal leta {rez.GetInt32(0)} ");
                    }
                    
                }
            }
            finally
            {
                povezava.Close();
                //if (rez != null)
                //{
                //    povezava.Close();
                //}
                //if (povezava != null)
                //{
                //    povezava.Close();
                //}

            }
        }

        private void pocisti_Click(object sender, EventArgs e)
        {
            rezultati.Items.Clear();
        }
    }
}
