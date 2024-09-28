using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_beirokonyv
{
    public partial class SzennaiForm : Form
    {
        public SzennaiForm()
        {
            InitializeComponent();
        }

        private void SzennaiForm_Load(object sender, EventArgs e)
        {
            List<Beolvasas> szenna = new List<Beolvasas>();
            StreamReader sr = new StreamReader("csoportok/szenna.txt");
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                Beolvasas uj_adat = new Beolvasas(sor);
                szenna.Add(uj_adat);
            }
            sr.Close();

            foreach (var i in szenna)
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

            List<string> korzetek = new List<string>();

            StreamReader ksr = new StreamReader("korzetek/szenna_korzet.txt");
            while (!ksr.EndOfStream)
            {
                string sor = ksr.ReadLine();
                korzetek.Add(sor);
            }
            ksr.Close();

            for (int i = 0; i < korzetek.Count; i++)
            {
                korzetszam.Items.Add(korzetek[i]);
            }
        }

        string nev;

        internal void Nev(string atadnev)
        {
            nev = atadnev;
            nevl.Text = nev;
        }

        private void bebt_Click(object sender, EventArgs e)
        {
            string korzet;
            string kisero;
            string kezdes;
            string befejezes;

            List<String> lista = new List<String>();
            korzet = korzetszam.Text;
            kisero = kisereotb.Text;
            kezdes = kezdesido.Text;
            befejezes = befejezido.Text;

            if (kisero == "")
            {
                adatLisbox.Items.Add($"{korzet} körzet; {nev}; Kezdet: {kezdes}; Befejez: {befejezes}");
            }
            else
            {
                adatLisbox.Items.Add($"{korzet} körzet; {nev}; Kisérő: {kisero}; Kezdet: {kezdes}; Befejez: {befejezes}");
            }

            List<Beolvasas> szenna = new List<Beolvasas>();
            StreamReader sr = new StreamReader("csoportok/szenna.txt");
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                Beolvasas uj_adat = new Beolvasas(sor);
                szenna.Add(uj_adat);
            }
            sr.Close();

            foreach (var i in szenna)
            {
                if (i.kisero == "")
                {
                    lista.Add($"{i.korzet};{i.nev};;{i.kezdes};{i.befejezes}");
                }
                else
                {
                    lista.Add($"{i.korzet};{i.nev};{i.kisero};{i.kezdes};{i.befejezes}");
                }
            }

            lista.Add($"{korzet};{nev};{kisero};{kezdes};{befejezes}");

            StreamWriter sw = new StreamWriter("csoportok/szenna.txt");
            foreach (var i in lista)
            {
                sw.WriteLine(i);
            }
            sw.Close();

            for (int i = 0; i < adatLisbox.Items.Count; i++)
            {
                lista.Add(adatLisbox.Items[i].ToString());
            }
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
    }
}