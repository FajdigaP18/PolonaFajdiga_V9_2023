using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dezuje
{
    public partial class Form1 : Form
    {
        private List<Kapljica> padajoceKapljice = new List<Kapljica>();
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void UstvariKapljico()
        {
            int koliko = random.Next(slika.Width/50);
            for (int i = 0; i < koliko; i++)
            {
                Kapljica kapljica = new Kapljica(random.Next(slika.Width), 0, false);
                padajoceKapljice.Add(kapljica);
            }
        }

        private void dogodek_Tick(object sender, EventArgs e)
        {
            foreach (Kapljica kapljica in padajoceKapljice)
            {
                if (!kapljica.NaMestu)
                {
                    if (kapljica.Y + 1 > slika.Height || padajoceKapljice.Contains(new Kapljica(kapljica.X, kapljica.Y + 1, true)))
                    {
                        kapljica.NaMestu = true;
                    }
                    //else if (padajoceKapljice.Contains(new Kapljica(kapljica.X, kapljica.Y + 1, true)))
                    //{
                    //    kapljica.NaMestu = true;
                    //}
                    else
                    {
                        kapljica.Y += 1;
                    }
                }
            }
            UstvariKapljico();
            slika.Refresh();
        }

        private void slika_Click(object sender, EventArgs e)
        {
            dogodek.Start();
            zacni.Visible = false;
        }

        private void zacni_Click(object sender, EventArgs e)
        {
            dogodek.Start();
            zacni.Visible = false;
        }

        private void slika_Paint(object sender, PaintEventArgs e)
        {
            Graphics platno = e.Graphics;
            foreach (Kapljica kapljica in padajoceKapljice)
            {
                platno.DrawEllipse(new Pen(Color.White, 1), new Rectangle(kapljica.X, kapljica.Y, 1, 1));
            }
        }
    }
}
