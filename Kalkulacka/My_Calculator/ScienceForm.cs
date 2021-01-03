using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Kalkulacka
{
    public partial class ScienceForm : Form
    {
        public ScienceForm()
        {
            FormBorderStyle = FormBorderStyle.None;
            InitializeComponent(); //poustime form
        }

        float cislo;

        private void LabelClear()
        {
            vysledekLabel.Text = "";
            errLabel.Text = "";
        }

        private void ScienceForm_Load(object sender, EventArgs e)
        {
            LabelClear();
        }

        private void medianBtn_Click(object sender, EventArgs e)
        {
            //string[] temp1 = arraytext.text.split(',');
            //list<int> median = new list<int>();
            //foreach (string s in temp)
            //{
            //    median.add(int32.parse(s));
            //}
            //median.foreach(i => console.writeline(i));

            char[] temp = arrayText.Text.ToArray();
            Array.Sort(temp);
            int count = temp.Length;
            if (count == 0)
            {
                throw new InvalidOperationException("Empty collection");
            }
            else if (count % 2 == 0)
            {
                // count is even, average two middle elements
                float a = temp[count / 2 - 1];
                float b = temp[count / 2];
                string vysledek = String.Format("{0:0.##}", Math.Pow((a + b) / 2, 0.5));
                vysledekLabel.Text =  "Median je " + vysledek;
            }
            else
            {
                // count is odd, return the middle element
                vysledekLabel.Text = "Median je " + temp[count / 2];
            }

        }

        private void naDruhouBtn_Click(object sender, EventArgs e)
        {
            if (float.TryParse(cislo2Text.Text.ToString(), out cislo)) {
                LabelClear();
                double vysledek = (double)Math.Pow(cislo, 2);
                vysledekLabel.Text = ("Druha mocnina cisla " + cislo + " je " + vysledek + ".");
            }
            else
            {
                LabelClear();
                errLabel.Text = "Zadej cislo!";
            }
            //if(!string.IsNullOrEmpty(cislo1Text) && !string.IsNullOrEmpty(cislo2Text.Text) {}
        }

        private void naTretiBtn_Click(object sender, EventArgs e)
        {
            if (float.TryParse(cislo2Text.Text.ToString(), out cislo))
            {
                LabelClear();
                double vysledek = (double)Math.Pow(cislo, 3);
                vysledekLabel.Text = ("Treti mocnina cisla " + cislo + " je " + vysledek + ".");
            }
            else
            {
                LabelClear();
                errLabel.Text = "Zadej cislo!";
            }
            //if(!string.IsNullOrEmpty(cislo1Text) && !string.IsNullOrEmpty(cislo2Text.Text) {}
        }

        private void odmocninaBtn_Click(object sender, EventArgs e)
        {
            if (float.TryParse(cislo2Text.Text.ToString(), out cislo))
            {
                LabelClear();
                string vysledek = String.Format("{0:0.##}", Math.Pow(cislo, 0.5));
                vysledekLabel.Text = "Odmocnina cisla " + cislo + " je " + vysledek + ".";
            }
            else
            {
                LabelClear();
                errLabel.Text = "Zadej cislo!";
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void klasickaButton_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
        }
    }
}