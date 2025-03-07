namespace calcolatrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float risultato;
        string espressione;
        private void btnNum1_Click(object sender, EventArgs e)
        {
            lblRis.Text += "1";
            espressione += "1";
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            lblRis.Text += "2";
            espressione += "2";
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            lblRis.Text += "3";
            espressione += "3";
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            lblRis.Text += "4";
            espressione += "4";
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            lblRis.Text += "5";
            espressione += "5";
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            lblRis.Text += "6";
            espressione += "6";
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            lblRis.Text += "7";
            espressione += "7";
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            lblRis.Text += "8";
            espressione += "8";
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            lblRis.Text += "9";
            espressione += "9";
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            lblRis.Text += "0";
            espressione += "0";
        } 

        private void btnDiv_Click(object sender, EventArgs e)
        {
            lblRis.Text += "/";
            espressione+= "/";
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            lblRis.Text += "*";
            espressione+= "*";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            lblRis.Text += "-";
            espressione+= "-";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblRis.Text += "+";
            espressione += "+";
        }
        private void btnRis_Click(object sender, EventArgs e)
        {
            espressione = espressione.Replace(" ", "");

            float ris = 0;
            float num_ope = 0;
            char ope = '+';
            string numero = "";
            string num_cifre = "0123456789";

            for (int i = 0; i < espressione.Length; i++)
            {
                char c = espressione[i];

                if (num_cifre.Contains(c))
                {
                    numero += c;
                }

                if (c == '+' || c == '-' || c == '*' || c == '/')
                {
                    int n = Int32.Parse(numero);
                    numero = "";

                    if (n == '*')
                    {
                        num_ope *= n;
                    }
                    else if (ope == '/')
                    {
                        num_ope /= n;
                    }
                    else if (ope == '+')
                    {
                        ris += num_ope;
                        num_ope = n;
                    }
                    else if (ope == '-')
                    {
                        ris += num_ope;
                        num_ope = -n;
                    }
                    ope = c;
                }
            }
            if (numero != "")
            {
                int n = Int32.Parse(numero);
                if (ope == '*')
                {
                    num_ope *= n;
                }
                else if (ope == '/')
                {
                    num_ope /= n;
                }
                else if (ope == '+')
                {
                    ris += num_ope;
                    num_ope = n;
                }
                else if (ope == '-')
                {
                    ris += num_ope;
                    num_ope = -n;
                }
            }
            ris += num_ope;
            lblRis.Text = ris.ToString();
        }
        private void Clean_Click(object sender, EventArgs e)
        {
            lblRis.Text = "";
            espressione = "";
        }
    }
}
