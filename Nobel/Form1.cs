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
        private string povNiz = "Server= baza.fmf.uni-lj.si;   User Id= student11;   Password= student;   Database= nobel2012;";

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ko kliknemo na label3, to je naslov NOBELOVI NAGRAJENCI, se nam izpiše sporočilo 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vnesite leto in izberite kategorijo!");
        }

        /// <summary>
        /// Ko kliknemo na gumb Poišči, poiščemo podatke in jih pirkažemo, če smo izbrali letnico in kategorijo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void poisci_Click(object sender, EventArgs e)
        {
            rezultati.Items.Add("TUKAJ SO PRIKAZANI REZULTATI ISKANJA");
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
                string sql = $"SELECT DISTINCT winner, subject,yr FROM nobel WHERE nobel.yr = {letnica} ";
                NpgsqlCommand ukaz = new NpgsqlCommand();
                ukaz.Connection = povezava;
                ukaz.CommandType = CommandType.Text;
                ukaz.CommandText = sql;
                NpgsqlDataReader rez = ukaz.ExecuteReader();
                while (rez.Read())
                {
                    for (int i = 0; i < rez.VisibleFieldCount / 2; i++)
                    {
                        if (rez[1].ToString() == kategorija)
                        {
                            rezultati.Items.Add($"{rez[0].ToString()} je zmagal leta {rez[2]}");
                        }
                    }        
                }
            }
            finally
            {
                povezava.Close();
            }
        }

        private void pocisti_Click(object sender, EventArgs e)
        {
            rezultati.Items.Clear();
            leto.Text = "";
            podrocja.Text = "";
        }
    }
}
