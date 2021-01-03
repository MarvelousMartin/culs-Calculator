using System;
using System.Windows.Forms;

namespace Kalkulacka
{
    public partial class Kalkulacka : Form
    {
        public Kalkulacka()
        {
            FormBorderStyle = FormBorderStyle.None;
            InitializeComponent(); //poustime form
        }
        //volime float kvuli moznosti vlozeni napr. 3.14
        float cislo1 = 0;
        float cislo2 = 0;
        int pocetOperandu = 0; //pocet zmacknutych operandu [+ - * / =]
        bool operandZvolen = false;
        bool rovnitkoStisknuto = false;
        string operand;

        public void Reset() //funkce na reset, ale zaroven i na osetreni deleni nulou
        {
            cislo1 = 0;
            cislo2 = 0;
            operand = "";
            operandZvolen = false;
            rovnitkoStisknuto = false;
            pocetOperandu = 0;
            textBox1.Text = "0";
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            // Prida proklik na vsechna tlacitka krome resetu
            //Prohleda vsechny controls ve formulari, ktere nemaji na sobe Reset a tem da event button.Click

            foreach (Control control in Controls)
            {
                if (control is Button)
                {
                    if (control.Text != "Reset")
                        control.Click += new System.EventHandler(btn_click);
                }
            }
        }

        private void vedeckaBtn_Click(object sender, EventArgs e)
        {
            ScienceForm scienceForm = new ScienceForm();
            scienceForm.ShowDialog(this);
            textBox1.Text = "";
        }

        // funkce na kontrolovani stisknuti operandu
        public bool kontrolaOperand(Button button)
        {
            string buttonText = button.Text;

            if (buttonText.Equals("+") || buttonText.Equals("-") ||
                buttonText.Equals("*") || buttonText.Equals("/") ||
                buttonText.Equals("="))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Vytvoreni funkce button.Click
        //Funkce bude fungovat, pouze pokud uzivatel klikne na dane tlacitko

        public void btn_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (!kontrolaOperand(button))// true pokud je na tlacitku napsane cislo
            {
                if (operandZvolen) //kliknuli jsme na tlacitko?
                {
                    float.TryParse(textBox1.Text, out cislo1); //vezmeme si text z tlacitka a ulozime do cislo1
                    textBox1.Text = ""; //vymaze vsechno z textboxu, abychom mohli psat nove cislo
                }
                // pokud textbox neobsahuje "."
                if (!textBox1.Text.Contains("."))
                {
                    if (textBox1.Text.Equals("0") && !button.Text.Equals(".")) //osetrujeme zadavani typu 0,... -> pokud to zacina na nulu a neni za nulou tecka, tak:
                    {
                        // smazu prvni nulu
                        // nadpis tlacitka dam do textboxu
                        textBox1.Text = button.Text;
                        operandZvolen = false;
                    }
                    else
                    {
                        //jinak pracuji normalne
                        textBox1.Text += button.Text;
                        operandZvolen = false;
                    }
                }

                else if (!button.Text.Equals("."))
                {
                    textBox1.Text += button.Text;
                    operandZvolen = false;
                }
            }
            else // pokud jsou na tlacitku operandy [+ - / * =]
            {
                if (pocetOperandu == 0) //podminka na prvni klik operandu
                {
                    pocetOperandu++;
                    // parsujeme a ukladame prvni hodnotu, s druhou budeme teprve pracovat (neni zadana)
                    cislo1 = float.Parse(textBox1.Text);
                    // ulozi se nam operand [+ - / * =]
                    operand = button.Text;
                    // uzivatel klikl na operand, tudiz true
                    operandZvolen = true;
                }
                else
                {
                    if (!button.Text.Equals("="))// pokud nemame rovnitko -> budeme jeste scitat, odecitat atp.
                    {
                        if (!rovnitkoStisknuto)
                        {
                            cislo2 = float.Parse(textBox1.Text);
                            textBox1.Text = Convert.ToString(spocitejVysledek(operand, cislo1, cislo2));
                            cislo2 = float.Parse(textBox1.Text);
                            operand = button.Text;
                            operandZvolen = true;
                            rovnitkoStisknuto = false;
                        }
                        else
                        {
                            rovnitkoStisknuto = false;
                            operand = button.Text;
                        }
                    }
                    else
                    {
                        cislo2 = float.Parse(textBox1.Text);
                        textBox1.Text = Convert.ToString(spocitejVysledek(operand, cislo1, cislo2));
                        cislo1 = float.Parse(textBox1.Text);
                        operandZvolen = true;
                        rovnitkoStisknuto = true;
                    }
                }
            }

        }

        // Pocitaci funkce pres switch
        public float spocitejVysledek(string operand, float n1, float n2)
        {
            float result = 0;

            switch (operand)
            {
                case "+":
                    result = n1 + n2;
                    break;
                case "-":
                    result = n1 - n2;
                    break;
                case "*":
                    result = n1 * n2;
                    break;
                case "/":
                    if (n2 == 0)
                    {
                        //osetreni podminky deleni nulou
                        MessageBox.Show("Nelze delit nulou!");
                        Reset();
                    }
                    else
                    {
                        result = n1 / n2;
                    }
                        break;
            }
            return result;
        }

        // tlacitko reset, vymaze ulozene hodnoty a pocita znovu
        private void buttonReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        //tlacitko "END" na ukonceni aplikace
        private void buttonEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
