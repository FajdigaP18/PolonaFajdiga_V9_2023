using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Filmisql
{
    public partial class Form1 : Form
    {
        private string povNiz = @"Data Source = C:\Users\Polona\Desktop\Prak_mat\Prog\PolonaFajdiga_V9_2023\Filmisql\filmi.sqlite; Version=3;";
        private string link = @"https://www.bing.com/images/search?view=detailV2&ccid=oIC1O5MB&id=0D8F4532F26E4BC1FC9BE2B1E2A8737A7301E241&thid=OIP.oIC1O5MBWYk5Vol2-v-MhgHaFi&mediaurl=https%3a%2f%2fst.depositphotos.com%2f3073153%2f3939%2fv%2f950%2fdepositphotos_39393075-stock-illustration-movie-background.jpg&cdnurl=https%3a%2f%2fth.bing.com%2fth%2fid%2fR.a080b53b9301598939568976faff8c86%3frik%3dQeIBc3pzqOKx4g%26pid%3dImgRaw%26r%3d0&exph=766&expw=1024&q=simple+movie+backgraund+jpg&simid=608040852736382121&FORM=IRPRST&ck=F01E5F2399A381D9C5C96BB880D6FAD7&selectedIndex=3&ajaxhist=0&ajaxserp=0";
        private SQLiteConnection povezava;
        public Form1()
        {
            InitializeComponent();
        }

        private void Podatki( int iskanoLeto, double iskanaOcena)
        {
            SQLiteConnection povezava = new SQLiteConnection(povNiz);
            povezava.Open();

            SQLiteCommand ukaz = new SQLiteCommand($"SELECT naslov FROM filmi WHERE {iskanoLeto} = leto AND  {iskanaOcena} = ocena;", povezava);
            SQLiteDataReader rez = ukaz.ExecuteReader();
            int koliko = 0;
            while (rez.Read())
            {
                listBox.Items.Add("123");
                //listBox.Items.Add(rez[0].ToString());
                //for (int i = 0; i < rez.VisibleFieldCount; i++)
                //{
                //    listBox.Items.Add(rez[i].ToString());
                //}
            }
            this.Controls.Add(listBox);
            povezava.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (leto.Text == "" || ocena.Text == "")
            {
                MessageBox.Show("Vnesi vsa polja!");
            }
            try
            {
                //SQLiteConnection povezava = new SQLiteConnection(povNiz);
                povezava = new SQLiteConnection(povNiz);
                povezava.Open();
                int filmleto = int.Parse(leto.Text);
                double filmocena = double.Parse(ocena.Text);
                if (filmleto > 2016 || filmleto < 1921 || filmocena < 0 || filmocena > 10)
                {
                    MessageBox.Show("Nepravilni podatki!");
                    leto.Text = "";
                    ocena.Text = "";
                }

                else
                {
                    //SQLiteConnection povezava = new SQLiteConnection(povNiz);
                    //povezava.Open();

                    SQLiteCommand ukaz = new SQLiteCommand("SELECT naslov, leto, ocena FROM filmi", povezava);
                    SQLiteDataReader rez = ukaz.ExecuteReader();
                    while (rez.Read())
                    {
                        double st = double.Parse(rez[2].ToString());
                        if (rez.GetInt32(1) == filmleto && st > filmocena)
                        {
                            listBox.Items.Add($"Film {rez.GetString(0)} z oceno {filmocena}");
                        }
                        ////listBox.Items.Add(rez[0].ToString());
                        //for (int i = 0; i < rez.VisibleFieldCount; i++)
                        //{
                        //    listBox.Items.Add(rez[i].ToString());
                        //}
                    }
                    //this.Controls.Add(listBox);
                    povezava.Close();
                    //Podatki(filmleto, filmocena);
                }
            }
            finally
            {
                //if (rez != null)
                //{
                //    povezava.Close();
                //}
                if (povezava != null)
                {
                    povezava.Close();
                }
                povezava.Close();
            }
        }

        private void pocisti_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }
    }
}
