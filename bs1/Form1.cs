namespace bs1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }



        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }



        private void SaladCb_CheckedChanged(object sender, EventArgs e)
        {
            if (SaladCb.Checked == true)
            {
                SaladTb.Enabled = true;
            }
            if (SaladCb.Checked == false)
            {
                SaladTb.Enabled = false;
                SaladTb.Text = "0";
            }
        }

        private void SandwitchCb_CheckedChanged(object sender, EventArgs e)
        {
            if (SandwitchCb.Checked == true)
            {
                SandwitchTb.Enabled = true;
            }
            if (SandwitchCb.Checked == false)
            {
                SandwitchTb.Enabled = false;
                SandwitchTb.Text = "0";
            }
        }

        private void ChickenCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ChickenCb.Checked == true)
            {
                ChickenTb.Enabled = true;
            }
            if (ChickenCb.Checked == false)
            {
                ChickenTb.Enabled = false;
                ChickenTb.Text = "0";
            }
        }

        private void CheeseCb_CheckedChanged(object sender, EventArgs e)
        {
            if (CheeseCb.Checked == true)
            {
                CheeseTb.Enabled = true;
            }
            if (CheeseCb.Checked == false)
            {
                CheeseTb.Enabled = false;
                CheeseTb.Text = "0";
            }
        }

        private void TeaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (TeaCb.Checked == true)
            {
                TeaTb.Enabled = true;
            }
            if (TeaCb.Checked == false)
            {
                TeaTb.Enabled = false;
                TeaTb.Text = "0";

            }
        }

        private void ColaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ColaCb.Checked == true)
            {
                ColaTb.Enabled = true;
            }
            if (ColaCb.Checked == false)
            {
                ColaTb.Enabled = false;
                ColaTb.Text = "0";
            }
        }

        private void WaterCb_CheckedChanged(object sender, EventArgs e)
        {
            if (WaterCb.Checked == true)
            {
                WaterTb.Enabled = true;
            }
            if (WaterCb.Checked == false)
            {
                WaterTb.Enabled = false;
                WaterTb.Text = "0";
            }
        }

        private void ChocolateCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ChocolateCb.Checked == true)
            {
                ChocolateTb.Enabled = true;
            }
            if (ChocolateCb.Checked == false)
            {
                ChocolateTb.Enabled = false;
                ChocolateTb.Text = "0";
            }
        }

        private void PancakeCb_CheckedChanged(object sender, EventArgs e)
        {
            if (PancakeCb.Checked == true)
            {
                PankakeTb.Enabled = true;
            }
            if (PancakeCb.Checked == false)
            {
                PankakeTb.Enabled = false;
                PankakeTb.Text = "0";
            }
        }

        private void OrangeCb_CheckedChanged(object sender, EventArgs e)
        {
            if (OrangeCb.Checked == true)
            {
                OrangeTb.Enabled = true;
            }
            if (OrangeCb.Checked == false)
            {
                OrangeTb.Enabled = false;
                OrangeTb.Text = "0";
            }
        }

        private void FriesCb_CheckedChanged(object sender, EventArgs e)
        {
            if (FriesCb.Checked == true)
            {
                FriesTb.Enabled = true;
            }
            if (FriesCb.Checked == false)
            {
                FriesTb.Enabled = false;
                FriesTb.Text = "0";
            }
        }

        private void BurgerCb_CheckedChanged(object sender, EventArgs e)
        {
            if (BurgerCb.Checked == true)
            {
                BurgerCb.Enabled = true;
            }
            if (BurgerCb.Checked == false)
            {
                BurgerTb.Enabled = false;
                BurgerTb.Text = "0";
            }
        }

        // declare unit price
        double friesup = 50, burgerup = 80, saladup = 20, sandwitchup = 29, cheeseup = 23, chickenup = 24;
        double teaup = 21, colaup = 23, waterup = 24, chocolateup = 25, pancakeup = 24, orangeup = 24;
        // declare total item price
        double friestp, burgertp, saladtp, sandwitchtp, cheesetp, chickentp, teatp, colatp, watertp, chocolatetp, pancaketp, orangetp;
        double subtotal = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            friestp = friesup * Convert.ToDouble(FriesTb.Text);
            burgertp = burgerup * Convert.ToDouble(BurgerTb.Text);
            saladtp = saladup * Convert.ToDouble(SaladTb.Text);
            sandwitchtp = sandwitchup * Convert.ToDouble(SandwitchTb.Text);
            cheesetp = cheeseup * Convert.ToDouble(CheeseTb.Text);
            chickentp = chickenup * Convert.ToDouble(CheeseTb.Text);
            teatp = teaup * Convert.ToDouble(TeaTb.Text);
            colaup = colaup * Convert.ToDouble(ColaTb.Text);
            watertp = waterup * Convert.ToDouble(WaterTb.Text);
            chocolatetp = chocolateup * Convert.ToDouble(ChocolateTb.Text);
            pancaketp = pancakeup * Convert.ToDouble(PankakeTb.Text);
            orangetp = orangeup * Convert.ToDouble(OrangeTb.Text);

            ReceiptTb.Clear();
            ReceiptTb.AppendText(Environment.NewLine);
            ReceiptTb.AppendText("\t\t\t BS-RESTAURENT " + Environment.NewLine);
            ReceiptTb.AppendText("\t\t\t********************" + Environment.NewLine);


            if (FriesCb.Checked == true)
            {
                ReceiptTb.AppendText("\t\t\t Fries \t" + friestp + Environment.NewLine);
                subtotal = subtotal + friestp;
                subtotalTb.Text = "" + subtotal;
            }

            if (BurgerCb.Checked == true)
            {
                ReceiptTb.AppendText("\t\t\t Burger \t" + friestp + Environment.NewLine);
                subtotal = subtotal + burgertp;
                subtotalTb.Text = "" + subtotal;
            }

            if (SaladCb.Checked == true)
            {
                ReceiptTb.AppendText("\t\t\t Salad \t" + saladtp + Environment.NewLine);
                subtotal = subtotal + saladtp;
                subtotalTb.Text = "" + subtotal;
            }

            if (SandwitchCb.Checked == true)
            {
                ReceiptTb.AppendText("\t\t\t Sandwitch \t" + sandwitchtp + Environment.NewLine);
                subtotal = subtotal + sandwitchtp;
                subtotalTb.Text = "" + subtotal;
            }

            if (ChickenCb.Checked == true)
            {
                ReceiptTb.AppendText("\t\t\t Chicken \t" + chickentp + Environment.NewLine);
                subtotal = subtotal + chickentp;
                subtotalTb.Text = "" + subtotal;
            }

            if (TeaCb.Checked == true)
            {
                ReceiptTb.AppendText("\t\t\t Tea \t" + teatp + Environment.NewLine);
                subtotal = subtotal + teatp;
                subtotalTb.Text = "" + subtotal;
            }

            if (ColaCb.Checked == true)
            {
                ReceiptTb.AppendText("\t\t\t Cola \t" + colatp + Environment.NewLine);
                subtotal = subtotal + colatp;
                subtotalTb.Text = "" + subtotal;
            }

            if (WaterCb.Checked == true)
            {
                ReceiptTb.AppendText("\t\t\t Water \t" + watertp + Environment.NewLine);
                subtotal = subtotal + watertp;
                subtotalTb.Text = "" + subtotal;
            }


            if (ChocolateCb.Checked == true)
            {
                ReceiptTb.AppendText("\t\t\t Chocolate \t" + chocolatetp + Environment.NewLine);
                subtotal = subtotal + chocolatetp;
                subtotalTb.Text = "" + subtotal;
            }

            if (PancakeCb.Checked == true)
            {
                ReceiptTb.AppendText("\t\t\t Pankake \t" + pancaketp + Environment.NewLine);
                subtotal = subtotal + pancaketp;
                subtotalTb.Text = "" + subtotal;
            }


            if (OrangeCb.Checked == true)
            {
                ReceiptTb.AppendText("\t\t\t Orange \t" + orangetp + Environment.NewLine);
                subtotal = subtotal + orangetp;
                subtotalTb.Text = "" + subtotal;
            }

            double tax = subtotal * 0.12;
            double total = subtotal + tax;
            taxTb.Text = total.ToString();
            totalTb.Text = total.ToString();

        }

        private void ReceiptTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void subtotalTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}