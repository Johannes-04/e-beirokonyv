using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_beirokonyv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            string nev;
            string jelszo;

            nev = nevtb.Text;
            jelszo = jelszotb.Text;


            List<Beolvasas> bejelentkezes = new List<Beolvasas>();
            StreamReader sr = new StreamReader("belepesi_adatok/adat.txt");
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                Beolvasas uj_adat = new Beolvasas(sor);
                bejelentkezes.Add(uj_adat);
            }
            sr.Close();

            foreach (var i in bejelentkezes)
            {
                if (nev == "")
                {
                    MessageBox.Show("Töltseki a felhasználó név mezöt!");
                    break;
                }
                else
                {
                    if (nev == i.nev)
                    {

                        if (jelszo == "")
                        {
                            MessageBox.Show("Töltseki a jelszó mezöt!");
                            break;
                        }
                        else
                        {

                            if (jelszo == i.jelszo)
                            {
                                tokaji.Visible = true;
                                szennai.Visible = true;
                                zselickislaki.Visible = true;
                                jelszotb.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Hibás jelszó!");
                                break;
                            }
                        }
                    }
                }
            }          
        }

        private void tokaji_Click(object sender, EventArgs e)
        {
            TokajiForm tokaji = new TokajiForm();
            tokaji.Nev(nevtb.Text);
            tokaji.ShowDialog();
        }

        private void szennai_Click(object sender, EventArgs e)
        {
            SzennaiForm szennai = new SzennaiForm();
            szennai.Nev(nevtb.Text);
            szennai.ShowDialog();
        }

        private void zselickislaki_Click(object sender, EventArgs e)
        {
            ZselickislakiForm zselickislaki = new ZselickislakiForm();
            zselickislaki.Nev(nevtb.Text);
            zselickislaki.ShowDialog();

        }

        public class Beolvasas
        {
            public string nev;
            public string jelszo;
            public Beolvasas(string sor)
            {
                string[] r = sor.Split(';');
                this.nev = r[0];
                this.jelszo = r[1];
            }
        }
    }
}