using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_LEGASPI_CPE201
{
    public partial class FoodOrdering : Form
    {

        private double total_amount = 0;
        private int total_qty = 0;

        public FoodOrdering()
        {
            InitializeComponent();
        }

        private void FoodOrdering_Load(object sender, EventArgs e)
        {
            priceTxtBox.Enabled = false;
            discountedAmountTxtbox.Enabled = false;
            changeTxtbox.Enabled = false;
            totalBillsTxtbox.Enabled = false;
            discountAmountTxtbox.Enabled = false;
            totalQtyTxtbox.Enabled = false;

            Combo_and_Pepperoni.Image = Image.FromFile("C:\\Legapsi\\Legapsi\\Resources\\COMBO AND PEPPERONI PIZZA 18inches.jpg");
            Combo_whole_pizza.Image = Image.FromFile("C:\\Legapsi\\Legapsi\\Resources\\COMBO WHOLE PIZZA 18inches.jpg");
            Cream_Cheese_Pepperoni.Image = Image.FromFile("C:\\Legapsi\\Legapsi\\Resources\\CREAM-CHEESE PEPPERONI WHOLE PIZZA 18inches.jpg");
            Garlic_and_Shrimp.Image = Image.FromFile("C:\\Legapsi\\Legapsi\\Resources\\GARLIC AND SHRIMP WHOLE PIZZA 18inches.jpg");
            Garlic_Shrimp_and_Cheese.Image = Image.FromFile("C:\\Legapsi\\Legapsi\\Resources\\GARLIC SHRIMP AND CHEESE PIZZA 18inches.jpg");
            Garlic_Shrimp_Pepperoni.Image = Image.FromFile("C:\\Legapsi\\Legapsi\\Resources\\GARLIC SHRIMP AND PEPPERONI PIZZA 18inches.jpg");
            Holiday_Pizza.Image = Image.FromFile("C:\\Legapsi\\Legapsi\\Resources\\HOLIDAY PIZZA.jpg");
            Pepperoni_and_Cheese.Image = Image.FromFile("C:\\Legapsi\\Legapsi\\Resources\\PEPPERONI AND CHEESE PIZZA 18inches.png");
            Pepperoni_whole_pizza.Image = Image.FromFile("C:\\Legapsi\\Legapsi\\Resources\\PEPPERONI WHOLE PIZZA 18inches.jpg");
            Tropical_Hawaiian.Image = Image.FromFile("C:\\Legapsi\\Legapsi\\Resources\\TROPICAL HAWAIIAN WHOLE PIZZA 18inches.jpg");

            A_CokeCheckBox.Enabled = false;
            A_FriedChickencheckBox.Enabled = false;
            A_FriescheckBox.Enabled = false;
            A_sideDishCheckBox.Enabled = false;
            A_SpecialPizaCheckbox.Enabled = false;
            B_carbonaracheckBox.Enabled = false;
            B_ChickencheckBox.Enabled = false;
            B_FriescheckBox.Enabled = false;
            B_halohalocheckBox.Enabled = false;
            B_HawaiiancheckBox.Enabled = false;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            this.BackColor = Color.LightCyan;
            foodBRdbtn.Checked = false;
            DisplayPictureBox.Image = Image.FromFile("C:\\Legapsi\\Legapsi\\Resources\\Food Bundle A.png");

            A_CokeCheckBox.Checked = true;
            A_FriedChickencheckBox.Checked = true;
            A_FriescheckBox.Checked = true;
            A_sideDishCheckBox.Checked = true;
            A_SpecialPizaCheckbox.Checked = true;

            B_carbonaracheckBox.Checked = false;
            B_ChickencheckBox.Checked = false;
            B_FriescheckBox.Checked = false;
            B_halohalocheckBox.Checked = false;
            B_HawaiiancheckBox.Checked = false;

            priceTxtBox.Text = "1,000.00";
            discountAmountTxtbox.Text = "200.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            DisplayListbox.Items.Add(foodARdbtn.Text + "" + priceTxtBox.Text);

            DisplayListbox.Items.Add(" Discount Amount: " + "" + discountAmountTxtbox.Text);
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.LightBlue;
            foodARdbtn.Checked = false;
            DisplayPictureBox.Image = Image.FromFile("C:\\Legapsi\\Legapsi\\Resources\\Food Bundle B.png");

            A_CokeCheckBox.Checked = false;
            A_FriedChickencheckBox.Checked = false;
            A_FriescheckBox.Checked = false;
            A_sideDishCheckBox.Checked = false;
            A_SpecialPizaCheckbox.Checked = false;

            B_carbonaracheckBox.Checked = true;
            B_ChickencheckBox.Checked = true;
            B_FriescheckBox.Checked = true;
            B_halohalocheckBox.Checked = true;
            B_HawaiiancheckBox.Checked = true;

            priceTxtBox.Text = "1,299.00";
            discountAmountTxtbox.Text = "(15% of the Price) P194.85";
            DisplayListbox.Items.Add(foodBRdbtn.Text + "" + priceTxtBox.Text);
            DisplayListbox.Items.Add(" Discount Amount: " + "" + discountAmountTxtbox.Text);
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cash_given, change, total_amountPaid;
            cash_given = Convert.ToDouble(cashGivenTxtbox.Text);
            total_amountPaid = Convert.ToDouble(totalBillsTxtbox.Text);
            change = cash_given - total_amountPaid;
            changeTxtbox.Text = change.ToString("n");
            DisplayListbox.Items.Add("Total Bills: " + "" + totalBillsTxtbox.Text);
            DisplayListbox.Items.Add("Cash Given: " + "" + cashGivenTxtbox.Text);
            DisplayListbox.Items.Add("Change: " + "" + changeTxtbox.Text);
            DisplayListbox.Items.Add("Total No. of Items: " + "" + totalQtyTxtbox.Text);



        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            FoodOrderingPrint print = new FoodOrderingPrint();

            print.printDisplayListbox.Items.AddRange(this.DisplayListbox.Items);

            print.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (DisplayListbox.SelectedIndex != -1)
            {
                DisplayListbox.Items.RemoveAt(DisplayListbox.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select an item to remove.");

            }
        }
       

        private void button3_Click(object sender, EventArgs e)
        {
            DisplayListbox.Items.Clear();

            total_amount = 0;
            total_qty = 0;
            qtyTxtbox.Clear();
            totalBillsTxtbox.Clear();
            totalQtyTxtbox.Clear();
            discountedAmountTxtbox.Clear();
            discountAmountTxtbox.Clear();
            cashGivenTxtbox.Clear();
            changeTxtbox.Clear();


            total_amount = 0;
            total_qty = 0;

            totalBillsTxtbox.Clear();
            totalQtyTxtbox.Clear();
            discountedAmountTxtbox.Clear();
            discountAmountTxtbox.Clear();
            changeTxtbox.Clear();
            cashGivenTxtbox.Clear();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void qtyTxtbox_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(priceTxtBox.Text, out double price) &&
        int.TryParse(qtyTxtbox.Text, out int qty) &&
        double.TryParse(discountAmountTxtbox.Text, out double discount_amount))
            {
                double discounted_amount = (price * qty) - discount_amount;

                total_qty = qty; // not +=
                totalQtyTxtbox.Text = total_qty.ToString();

                total_amount = discounted_amount; // not +=
                totalBillsTxtbox.Text = total_amount.ToString("n");

                discountedAmountTxtbox.Text = discounted_amount.ToString("n");

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            double price;

            priceTxtBox.Text = "500.99";

            price = Convert.ToDouble(priceTxtBox.Text);

            DisplayListbox.Items.Add(checkBox1.Text + "" + priceTxtBox.Text);

            qtyTxtbox.Text = "0";

            qtyTxtbox.Focus();

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            double price;

            priceTxtBox.Text = "550.99";

            discountAmountTxtbox.Text = "0.00";

            price = Convert.ToDouble(priceTxtBox.Text);

            DisplayListbox.Items.Add(checkBox2.Text + "" + priceTxtBox.Text);

            qtyTxtbox.Text = "0";

            qtyTxtbox.Focus();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            double price;

            priceTxtBox.Text = "600.99";

            discountAmountTxtbox.Text = "0.00";

            price = Convert.ToDouble(priceTxtBox.Text);

            DisplayListbox.Items.Add(checkBox3.Text + "" + priceTxtBox.Text);

            qtyTxtbox.Text = "0";

            qtyTxtbox.Focus();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            double price;

            priceTxtBox.Text = "700.59";

            discountAmountTxtbox.Text = "0.00";

            price = Convert.ToDouble(priceTxtBox.Text);

            DisplayListbox.Items.Add(checkBox4.Text + "" + priceTxtBox.Text);

            qtyTxtbox.Text = "0";

            qtyTxtbox.Focus();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            double price;

            priceTxtBox.Text = "500.00";

            discountAmountTxtbox.Text = "0.00";

            price = Convert.ToDouble(priceTxtBox.Text);

            DisplayListbox.Items.Add(checkBox5.Text + "" + priceTxtBox.Text);

            qtyTxtbox.Text = "0";

            qtyTxtbox.Focus();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            double price;

            priceTxtBox.Text = "750.00";

            discountAmountTxtbox.Text = "0.00";

            price = Convert.ToDouble(priceTxtBox.Text);

            DisplayListbox.Items.Add(checkBox6.Text + "" + priceTxtBox.Text);

            qtyTxtbox.Text = "0";

            qtyTxtbox.Focus();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            double price;

            priceTxtBox.Text = "700.00";

            discountAmountTxtbox.Text = "0.00";

            price = Convert.ToDouble(priceTxtBox.Text);

            DisplayListbox.Items.Add(checkBox7.Text + "" + priceTxtBox.Text);

            qtyTxtbox.Text = "0";

            qtyTxtbox.Focus();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            double price;

            priceTxtBox.Text = "850.00";

            discountAmountTxtbox.Text = "0.00";

            price = Convert.ToDouble(priceTxtBox.Text);

            DisplayListbox.Items.Add(checkBox8.Text + "" + priceTxtBox.Text);

            qtyTxtbox.Text = "0";

            qtyTxtbox.Focus();
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            double price;

            priceTxtBox.Text = "450.00";

            discountAmountTxtbox.Text = "0.00";

            price = Convert.ToDouble(priceTxtBox.Text);

            DisplayListbox.Items.Add(checkBox9.Text + "" + priceTxtBox.Text);

            qtyTxtbox.Text = "0";

            qtyTxtbox.Focus();
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            double price;

            priceTxtBox.Text = "650.00";

            discountAmountTxtbox.Text = "0.00";

            price = Convert.ToDouble(priceTxtBox.Text);

            DisplayListbox.Items.Add(checkBox10.Text + "" + priceTxtBox.Text);

            qtyTxtbox.Text = "0";

            qtyTxtbox.Focus();
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            double price;

            priceTxtBox.Text = "575.00";

            discountAmountTxtbox.Text = "0.00";

            price = Convert.ToDouble(priceTxtBox.Text);

            DisplayListbox.Items.Add(checkBox11.Text + "" + priceTxtBox.Text);

            qtyTxtbox.Text = "0";

            qtyTxtbox.Focus();
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            double price;

            priceTxtBox.Text = "575.00";

            discountAmountTxtbox.Text = "0.00";

            price = Convert.ToDouble(priceTxtBox.Text);

            DisplayListbox.Items.Add(checkBox12.Text + "" + priceTxtBox.Text);

            qtyTxtbox.Text = "0";

            qtyTxtbox.Focus();
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            double price;

            priceTxtBox.Text = "575.00";

            discountAmountTxtbox.Text = "0.00";

            price = Convert.ToDouble(priceTxtBox.Text);

            DisplayListbox.Items.Add(checkBox13.Text + "" + priceTxtBox.Text);

            qtyTxtbox.Text = "0";

            qtyTxtbox.Focus();
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            double price;

            priceTxtBox.Text = "575.00";

            discountAmountTxtbox.Text = "0.00";

            price = Convert.ToDouble(priceTxtBox.Text);

            DisplayListbox.Items.Add(checkBox14.Text + "" + priceTxtBox.Text);

            qtyTxtbox.Text = "0";

            qtyTxtbox.Focus();
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            double price;

            priceTxtBox.Text = "575.00";

            discountAmountTxtbox.Text = "0.00";

            price = Convert.ToDouble(priceTxtBox.Text);

            DisplayListbox.Items.Add(checkBox15.Text + "" + priceTxtBox.Text);

            qtyTxtbox.Text = "0";

            qtyTxtbox.Focus();
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            double price;

            priceTxtBox.Text = "575.00";

            discountAmountTxtbox.Text = "0.00";

            price = Convert.ToDouble(priceTxtBox.Text);

            DisplayListbox.Items.Add(checkBox16.Text + "" + priceTxtBox.Text);

            qtyTxtbox.Text = "0";

            qtyTxtbox.Focus();
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            double price;

            priceTxtBox.Text = "575.00";

            discountAmountTxtbox.Text = "0.00";

            price = Convert.ToDouble(priceTxtBox.Text);

            DisplayListbox.Items.Add(checkBox17.Text + "" + priceTxtBox.Text);

            qtyTxtbox.Text = "0";

            qtyTxtbox.Focus();
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            double price;

            priceTxtBox.Text = "575.00";

            discountAmountTxtbox.Text = "0.00";

            price = Convert.ToDouble(priceTxtBox.Text);

            DisplayListbox.Items.Add(checkBox18.Text + "" + priceTxtBox.Text);

            qtyTxtbox.Text = "0";

            qtyTxtbox.Focus();
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            double price;

            priceTxtBox.Text = "575.00";

            discountAmountTxtbox.Text = "0.00";

            price = Convert.ToDouble(priceTxtBox.Text);

            DisplayListbox.Items.Add(checkBox19.Text + "" + priceTxtBox.Text);

            qtyTxtbox.Text = "0";

            qtyTxtbox.Focus();
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            double price;

            priceTxtBox.Text = "575.00";

            discountAmountTxtbox.Text = "0.00";

            price = Convert.ToDouble(priceTxtBox.Text);

            DisplayListbox.Items.Add(checkBox20.Text + "" + priceTxtBox.Text);

            qtyTxtbox.Text = "0";

            qtyTxtbox.Focus();
        }
    }
    
}
