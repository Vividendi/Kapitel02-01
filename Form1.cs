using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kapitel02_01
{
    public partial class Form1 : Form
    {
        
        int rdbVar = 1;
        List<Media> bibliotek = new List<Media>();
        public Form1()
        {
            InitializeComponent();
        }

        class Media
        {
            protected string titel = "";
            public Media(string titel)
            {
                this.titel = titel;
            }
        }

        class Bok : Media
        {
            protected int antalSidor = 0;
            public Bok(string titel, int antalSidor) : base( titel)
            {
                this.antalSidor = antalSidor;
            }

            public override string ToString( )
            {
                return titel + ": " + antalSidor + " sidor";
            }
        }

        class Ljudspår : Media
        {
            protected double Speltid = 0;

            public Ljudspår(string titel, double Speltid) : base( titel)
            {
                this.Speltid = Speltid;

            }

            public override string ToString( )
            {
                    return titel + ": " + Speltid + " minuter";
            }
        }

        class Film : Ljudspår
        {
            protected string Upplösning = "";

            public Film(string titel, double Speltid, string Upplösning) : base(titel, Speltid)
            {
                this.Upplösning = Upplösning;
            }

            public override string ToString()
            {
                return titel + " (" + Upplösning + " upplösning): " + Speltid + " minuter";
            }
        }

        private void rdbBok_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbVar != 1)
            {
                rdbVar = 1;
                tbxTitel.Enabled = true;
                tbxSidor.Enabled = true;
                tbxSpeltid.Enabled = false;
                tbxUpplosning.Enabled = false;
                btnRegistrera.Text = "Registrera bok";
            }
        }

        private void rdbLjud_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbVar != 2)
            {
                rdbVar = 2;
                tbxTitel.Enabled = true;
                tbxSidor.Enabled = false;
                tbxSpeltid.Enabled = true;
                tbxUpplosning.Enabled = false;
                btnRegistrera.Text = "Registrera ljudspår";
            }
        }

        private void rdbFilm_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbVar != 3)
            {
                rdbVar = 3;
                tbxTitel.Enabled = true;
                tbxSidor.Enabled = false;
                tbxSpeltid.Enabled = true;
                tbxUpplosning.Enabled = true;
                btnRegistrera.Text = "Registrera film";
            }
        }

        private void btnRegistrera_Click(object sender, EventArgs e)
        {
            Bok nyBok = new Bok(Convert.ToString(tbxTitel.Text), Convert.ToInt32(tbxSidor.Text));
            Ljudspår nyttLjud = new Ljudspår(Convert.ToString(tbxTitel.Text), Convert.ToDouble(tbxSpeltid.Text));
            Film nyFilm = new Film(Convert.ToString(tbxTitel.Text), Convert.ToDouble(tbxSpeltid.Text), Convert.ToString(tbxUpplosning.Text)); 
            if (rdbVar == 1) {  bibliotek.Add(nyBok); }
            else if (rdbVar == 2) { bibliotek.Add(nyttLjud); }
            else if (rdbVar == 3) { bibliotek.Add(nyFilm); }
        }
    }
}
