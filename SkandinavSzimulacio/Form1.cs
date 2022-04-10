using SkandinavAdat.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkandinavSzimulacio
{
    public partial class Form1 : Form
    {
        List<int> tippek = new List<int>();
        SkandinavAdatContext db = new SkandinavAdatContext();
        public Form1()
        {
            InitializeComponent();
            this.Text = "Skandináv lottó";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;
            if (box.Checked)
            {
                tippek.Add(Convert.ToInt32(box.Text));
                tippeklista.Text = string.Join(",", tippek.OrderBy(x=>x));

                if (tippek.Count() == 7)
                {
                    btnSorsol.Enabled = true;
                    foreach (CheckBox item in panelChBoxTarol.Controls)
                    {
                        if (!item.Checked) item.Enabled = false;
                    }
                }

            }
            else
            {
                tippek.Remove(Convert.ToInt32(box.Text));
                tippeklista.Text = string.Join(",", tippek.OrderBy(x => x));
                if (tippek.Count() == 6)
                {
                    btnSorsol.Enabled = false;
                    foreach (CheckBox item in panelChBoxTarol.Controls)
                    {
                        item.Enabled = true;
                    }

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSorsol.Enabled = false;
            
            for (int i = 0; i < 35; i++)
            {
                CheckBox box = new CheckBox();
                box.AutoSize = true;
                box.Text = (i + 1).ToString();
                box.Location = new Point(20 + (i/5) * 50,20+(i%5)*50);
                box.CheckedChanged += checkBox1_CheckedChanged;
                panelChBoxTarol.Controls.Add(box);
            }
            
            
        }

        private void btnSorsol_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            HashSet<int> set= new HashSet<int>();

            do
            {
                set.Add(rnd.Next(1, 8));
            } while (set.Count()!=7);

            db.LottoSzamok.Add(new SkandinavAdat.Models.LottoSzam(set.ToArray()));
            var kitalalt = set.Intersect(tippek);
            MessageBox.Show($"Gép soroláson { kitalalt.Count()} számot találtál el!");

            set.Clear();

            do
            {
                set.Add(rnd.Next(1, 36));
            } while (set.Count() != 7);

            db.LottoSzamok.Add(new SkandinavAdat.Models.LottoSzam(set.ToArray()));
            kitalalt = set.Intersect(tippek);
            MessageBox.Show($"Kézi soroláson { kitalalt.Count()} számot találtál el!");

            db.SaveChanges();
        }

        private void btnBezar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
