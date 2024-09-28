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
    public partial class ZsakmanyForm : Form
    {
        public ZsakmanyForm()
        {
            InitializeComponent();
        }

        internal void Csoport(string csoportnev)
        {
            string csoport;
            csoport = csoportnev;

            if(csoport == "tokaj")
            {
                List<Beolvasas> tokaj = new List<Beolvasas>();
                StreamReader sr = new StreamReader("csoportok/tokaj.txt");
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    Beolvasas uj_adat = new Beolvasas(sor);
                    tokaj.Add(uj_adat);
                }
                sr.Close();

                foreach (var i in tokaj)
                {
                    if (i.kisero == "")
                    {
                        adatLisbox.Items.Add($"{i.korzet} körzet; {i.nev}; Kezdet: {i.kezdes}; Befejezes: {i.befejezes}");
                    }
                    else
                    {
                        adatLisbox.Items.Add($"{i.korzet} körzet; {i.nev}; Kisérő: {i.kisero};Kezdet: {i.kezdes}; Befejezes: {i.befejezes}");
                    }
                }

                List<string> vadfajok = new List<string>();
                StreamReader ksr = new StreamReader("vad/vadfajok.txt");
                while (!ksr.EndOfStream)
                {
                    string sor = ksr.ReadLine();
                    vadfajok.Add(sor);
                }
                ksr.Close();

                for (int i = 0; i < vadfajok.Count; i++)
                {
                    vadfaj.Items.Add(vadfajok[i]);
                }
            }
            if(csoport == "szenna")
            {

            }

            if (csoport == "zselickislak")
            {

            }

            valaszt.Items.Add("Zselickisfalud Vt hűtőbe leadva");
            valaszt.Items.Add("Egyéni kompetencia");

        }

        string nev;

        internal void Nev(string atadnev)
        {
            nev = atadnev;
        }

        public class Beolvasas
        {
            public string korzet;
            public string nev;
            public string kisero;
            public string kezdes;
            public string befejezes;

            public Beolvasas(string sor)
            {
                string[] r = sor.Split(';');
                this.korzet = r[0];
                this.nev = r[1];
                this.kisero = r[2];
                this.kezdes = r[3];
                this.befejezes = r[4];
            }
        }

        private void vadfaj_SelectedIndexChanged(object sender, EventArgs e)
        {
            ivar.Text = "";
            ivar.Items.Clear();

            if (vadfaj.Text == "Vaddisznó")
            {
                List<string> vaddiszno = new List<string>();
                StreamReader sr = new StreamReader("vad/vaddiszno.txt");
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    vaddiszno.Add(sor);
                }
                sr.Close();

                for (int i = 0; i < vaddiszno.Count; i++)
                {
                    ivar.Items.Add(vaddiszno[i]);
                }
            }

            if (vadfaj.Text == "Őz")
            {
                List<string> oz = new List<string>();
                StreamReader sr = new StreamReader("vad/oz.txt");
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    oz.Add(sor);
                }
                sr.Close();

                for (int i = 0; i < oz.Count; i++)
                {
                    ivar.Items.Add(oz[i]);
                }
            }

            if (vadfaj.Text == "Muflon")
            {
                List<string> muflon = new List<string>();
                StreamReader sr = new StreamReader("vad/muflon.txt");
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    muflon.Add(sor);
                }
                sr.Close();

                for (int i = 0; i < muflon.Count; i++)
                {
                    ivar.Items.Add(muflon[i]);
                }
            }

            if (vadfaj.Text == "Dámszarvas")
            {
                List<string> damszarvas = new List<string>();
                StreamReader sr = new StreamReader("vad/damszarvas.txt");
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    damszarvas.Add(sor);
                }
                sr.Close();

                for (int i = 0; i < damszarvas.Count; i++)
                {
                    ivar.Items.Add(damszarvas[i]);
                }
            }

            if (vadfaj.Text == "Gimszarvas")
            {
                List<string> gimszarvas = new List<string>();
                StreamReader sr = new StreamReader("vad/gimszarvas.txt");
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    gimszarvas.Add(sor);
                }
                sr.Close();

                for (int i = 0; i < gimszarvas.Count; i++)
                {
                    ivar.Items.Add(gimszarvas[i]);
                }
            }
        }

        private void bebt_Click(object sender, EventArgs e)
        {
            string vad;
            string faj;
            string megjegyzes_1;
            string megjegyzes_2;

            vad = vadfaj.Text;
            faj = ivar.Text;
            megjegyzes_1 = valaszt.Text;
            megjegyzes_2 = megjegyzes.Text;

            if (faj == "roka" || faj == "borz")
            {
                int index = adatLisbox.SelectedIndex;
                string adat = adatLisbox.SelectedItem.ToString();
                adat += $";{vad}";
                adatLisbox.Items.RemoveAt(index);
                adatLisbox.Items.Insert(index, adat);
            }
            else
            {
                int index = adatLisbox.SelectedIndex;
                string adat = adatLisbox.SelectedItem.ToString();
                adat += $";{vad};{faj};{megjegyzes_1}";
                adatLisbox.Items.RemoveAt(index);
                adatLisbox.Items.Insert(index, adat);
            }
        }
    }
}
