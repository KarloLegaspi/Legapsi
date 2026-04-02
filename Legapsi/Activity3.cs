using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_LEGASPI_CPE201
{
    public partial class Activity3 : Form
    {
        int qty_total = 0;
        double discount_totalgiven = 0;
        double discounted_total = 0;

        public Activity3()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                // VARIABLES
                int qty;
                double price, discount_amt, discounted_amt;
                // Convert String data from textboxes to numeric and place it as value of the variable
                qty = Convert.ToInt32(quantitytxtbox.Text);
                price = Convert.ToDouble(pricetextbox.Text);
                // create a formula needed for computation
                discount_amt = (qty * price) * 0.30;
                discounted_amt = (qty * price) - discount_amt;
                // converting numeric data to string and display it inside the textboxes
                discounttxtbox.Text = discounted_amt.ToString("n");
                discountedtxtbox.Text = discounted_amt.ToString("n");
                // code for unchecking the other radio buttons in the interface once the senior citizen method executed
                regularRbtn.Checked = false;
                EmployeeRbtn.Checked = false;
                noTaxRbtn.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Input is invalid");
                quantitytxtbox.Clear();
                quantitytxtbox.Focus();
            }


        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (quantitytxtbox.Text == "" || pricetextbox.Text == "" || cashre_renderedtxtbox.Text == "")
                {
                    MessageBox.Show("Please complete all fields.");
                    return;
                }

                int qty = Convert.ToInt32(quantitytxtbox.Text);
                double price = Convert.ToDouble(pricetextbox.Text.Replace("₱", ""));
                double cash_rendered = Convert.ToDouble(cashre_renderedtxtbox.Text);
                double discounted_total = 0;


                double discountRate = 0;

                if (radioButton1.Checked)
                    discountRate = 0.30;
                else if (regularRbtn.Checked)
                    discountRate = 0.10;
                else if (EmployeeRbtn.Checked)
                    discountRate = 0.15;
                else if (noTaxRbtn.Checked)
                    discountRate = 0;

                double total = qty * price;
                double discount_amt = total * discountRate;
                double discounted_amt = total - discount_amt;
                double change = cash_rendered - discounted_amt;

                discounttxtbox.Text = discount_amt.ToString("n");
                discountedtxtbox.Text = discounted_amt.ToString("n");
                changetxtbox.Text = change.ToString("n");

                qty_total += qty;
                discount_totalgiven += discount_amt;
                discounted_total += discounted_amt;

                qty_totaltxtbox.Text = qty_total.ToString();
                discount_totaltxtbox.Text = discount_totalgiven.ToString("n");
                discounted_totaltxtbox.Text = discounted_total.ToString("n");
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input. Please check your values.");
            }
        }

        private void Activity3_Load(object sender, EventArgs e)
        {
            itemnametxtbox.Enabled = false;
            pricetextbox.Enabled = false;
            discountedtxtbox.Enabled = false;
            qty_totaltxtbox.Enabled = false;
            discount_totaltxtbox.Enabled = false;
            discounted_totaltxtbox.Enabled = false;
            changetxtbox.Enabled = false;
            discounttxtbox.Enabled = false;

            name1lbl.Text = "All Meat whole pizza";
            name2lbl.Text = "Cheese whole pizza";
            name3lbl.Text = "Cheesy Burger Deluxe pizza";
            name4lbl.Text = "Combo and Cheese pizza";
            name5lbl.Text = "Combo and Garlic shrimp";
            name6lbl.Text = "Combo and Pepperoni";
            name7lbl.Text = "Combo whole pizza";
            name8lbl.Text = "Cream Cheese Pepperoni";
            name9lbl.Text = "Garlic and Shrimp";
            name10lbl.Text = "Garlic Shrimp and Cheese";
            name11lbl.Text = "Garlic Shrimp Pepperoni";
            name12lbl.Text = "Holiday Pizza";
            name13lbl.Text = "Pepperoni and Cheese";
            name14lbl.Text = "Pepperoni whole pizza";
            name15lbl.Text = "Tropical Hawaiian";
            name16lbl.Text = "Tropical Hawaiian";
            name17lbl.Text = "Tropical Hawaiian";
            name18lbl.Text = "Tropical Hawaiian";
            name19lbl.Text = "Tropical Hawaiian";
            name20lbl.Text = "Tropical Hawaiian";
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            try
            {

                int qty;
                double price, discount_amt, discounted_amt;
                // Convert String data from textboxes to numeric and place it as value of the variable
                qty = Convert.ToInt32(quantitytxtbox.Text);
                price = Convert.ToDouble(pricetextbox.Text);
                // create a formula needed for computation
                discount_amt = (qty * price) * 0.10;
                discounted_amt = (qty * price) - discount_amt;
                // converting numeric data to string and display it inside the textboxes
                discounttxtbox.Text = discounted_amt.ToString("n");
                discountedtxtbox.Text = discounted_amt.ToString("n");
                // code for unchecking the other radio buttons in the interface once the senior citizen method executed
                radioButton1.Checked = false;
                EmployeeRbtn.Checked = false;
                noTaxRbtn.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Input is invalid");
                quantitytxtbox.Clear();
                quantitytxtbox.Focus();
            }

        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            try
            {
                int qty;
                double price, discount_amt, discounted_amt;
                // Convert String data from textboxes to numeric and place it as value of the variable
                qty = Convert.ToInt32(quantitytxtbox.Text);
                price = Convert.ToDouble(pricetextbox.Text);
                // create a formula needed for computation
                discount_amt = (qty * price) * 0.15;
                discounted_amt = (qty * price) - discount_amt;
                // converting numeric data to string and display it inside the textboxes
                discounttxtbox.Text = discounted_amt.ToString("n");
                discountedtxtbox.Text = discounted_amt.ToString("n");
                // code for unchecking the other radio buttons in the interface once the senior citizen method executed
                radioButton1.Checked = false;
                regularRbtn.Checked = false;
                noTaxRbtn.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid data input in quantity");
                quantitytxtbox.Clear();
                quantitytxtbox.Focus();
            }

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int qty;
                double price, discount_amt, discounted_amt;
                // Convert String data from textboxes to numeric and place it as value of the variable
                qty = Convert.ToInt32(quantitytxtbox.Text);
                price = Convert.ToDouble(pricetextbox.Text);
                // create a formula needed for computation
                discount_amt = (qty * price) * 0;
                discounted_amt = (qty * price) - discount_amt;
                // converting numeric data to string and display it inside the textboxes
                discounttxtbox.Text = discounted_amt.ToString("n");
                discountedtxtbox.Text = discounted_amt.ToString("n");
                // code for unchecking the other radio buttons in the interface once the senior citizen method executed
                radioButton1.Checked = false;
                regularRbtn.Checked = false;
                EmployeeRbtn.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid data input in quantity");
                quantitytxtbox.Clear();
                quantitytxtbox.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Clear();
            pricetextbox.Clear();
            quantitytxtbox.Clear();
            discountedtxtbox.Clear();
            discounttxtbox.Clear();
            changetxtbox.Clear();
            cashre_renderedtxtbox.Clear();
        }

        private void name1lbl_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "All Meat whole pizza";
            pricetextbox.Text = "₱769.00";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Cheese whole pizza";
            pricetextbox.Text = "₱624.00";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Cheesy Burger Deluxe pizza";
            pricetextbox.Text = "₱769.00";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Combo and Cheese pizza";
            pricetextbox.Text = "₱747.00";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Combo and Garlic shrimp";
            pricetextbox.Text = "₱747.00";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Combo and Pepperoni";
            pricetextbox.Text = "₱747.00";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Combo whole pizza";
            pricetextbox.Text = "₱692.00";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Cream Cheese Pepperoni";
            pricetextbox.Text = "₱769.00";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Garlic and Shrimp";
            pricetextbox.Text = "₱692.00";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Garlic Shrimp and Cheese";
            pricetextbox.Text = "₱747.00";
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Garlic Shrimp Pepperoni";
            pricetextbox.Text = "₱747.00";
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Holiday Pizza";
            pricetextbox.Text = "₱769.00";
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Pepperoni and Cheese";
            pricetextbox.Text = "₱747.00";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Pepperoni whole pizza";
            pricetextbox.Text = "₱692.00";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Tropical Hawaiian";
            pricetextbox.Text = "₱769.00";
        }

        private void cashre_renderedtxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void qty_totaltxtbox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
