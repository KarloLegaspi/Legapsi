using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_LEGASPI_CPE201
{
    public partial class Example4 : Form
    {
        private Double basic_netincome = 0.00,
            basic_numhrs = 0.00,
            basic_rate = 0.00,
            hono_netincome = 0.00,
            hono_numhrs = 0.00,
            hono_rate = 0.00,
            others_netincome = 0.00,
            others_numhrs = 0.00,
            others_rate = 0.00,
            grossincome = 0.00,
            tax = 0.00;

        private void hono_rateTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void other_rateTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void other_netincomeTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sss_contribTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void philhealth_contribTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pagibig_contribTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tax_contribTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void total_deducTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void gross_incomeTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void net_incomeTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void basic_netincomeTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void basic_rateTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            basic_netincomeTxtbox.Clear();
            basic_numhrsTxtbox.Clear();
            basic_rateTxtbox.Clear();
            hono_netincomeTxtbox.Clear();
            hono_numhrsTxtbox.Clear();
            hono_rateTxtbox.Clear();
            other_netincomeTxtbox.Clear();
            other_numhrsTxtbox.Clear();
            other_rateTxtbox.Clear();
            net_incomeTxtbox.Clear();
            gross_incomeTxtbox.Clear();
            sss_contribTxtbox.Clear();
            pagibig_contribTxtbox.Clear();
            philhealth_contribTxtbox.Clear();
            tax_contribTxtbox.Clear();
            total_deducTxtbox.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                sss_contrib = Convert.ToDouble(sss_contribTxtbox.Text);
                pagibig_contrib = Convert.ToDouble(pagibig_contribTxtbox.Text);
                philhealth_contrib = Convert.ToDouble(philhealth_contribTxtbox.Text);
                tax = Convert.ToDouble(tax_contribTxtbox.Text);
                total_deductions = sss_contrib + pagibig_contrib + philhealth_contrib + tax;
                net_income = grossincome - total_deductions;
                net_incomeTxtbox.Text = net_income.ToString("C");
                total_deducTxtbox.Text = total_deductions.ToString("C");
                gross_incomeTxtbox.Text = grossincome.ToString("C");
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private double sss_contrib, pagibig_contrib, philhealth_contrib, total_deductions, net_income;

        private void other_numhrsTxtbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                others_numhrs = Convert.ToDouble(other_numhrsTxtbox.Text);
                others_rate = Convert.ToDouble(other_rateTxtbox.Text);
                others_netincome = others_numhrs * others_rate;
                other_netincomeTxtbox.Text = others_netincome.ToString("n");

                grossincome = basic_netincome + hono_netincome + others_netincome;
                gross_incomeTxtbox.Text = grossincome.ToString("n");

                //computation for philhealth contributions
                double philhealth_value = 0;
                if (grossincome < 10000)
                {
                    philhealth_value = 137.50;
                }
                else
                {
                    double philhealth_employshare = 137.50;
                    for (int x = 10000; x <= 40000; x += 1000)
                    {
                        if (grossincome >= x && grossincome < x + 1000 || grossincome > x + 1000)
                        {
                            philhealth_value = philhealth_employshare;
                        }
                        {
                            philhealth_employshare += 13.75;
                        }
                    }
                }
                philhealth_contribTxtbox.Text = philhealth_value.ToString("N");

                //computation for sss contributions
                double sss_value = 0;
                if (grossincome <= 1000)
                {
                    sss_value = 36.30;
                }
                else
                {
                    double sss_employshare = 36.30;
                    for (int x = 1000; x <= 15750; x += 500)
                    {
                        if (grossincome >= x && grossincome < x + 500 || grossincome > x + 500)
                        {
                            sss_value = sss_employshare;
                        }
                        sss_employshare += 18.20;

                    }
                }
                sss_contribTxtbox.Text = sss_value.ToString("N");

                //tax contribution per month based from new table of TAX 2019
                if (grossincome < (250000 / 24))
                {
                    tax_contribTxtbox.Text = "0.00";
                }
                else if (grossincome > 10416.67 && grossincome <= 16666.67)
                {
                    tax = ((((grossincome * 24) - 250000) * 0.20) / 24);
                    tax_contribTxtbox.Text = tax.ToString("n");
                }
                else if (grossincome > 16666.67 && grossincome <= 33333.33)
                {
                    tax = (((((grossincome * 24) - 400000) * 0.25) + 30000) / 24);
                    tax_contribTxtbox.Text = tax.ToString("n");
                }
                else if (grossincome > 33333.33 && grossincome <= 83333.33)
                {
                    tax = (((((grossincome * 24) - 800000) * 0.30) + 130000) / 24);
                    tax_contribTxtbox.Text = tax.ToString("n");
                }
                else if (grossincome > 83333.33 && grossincome <= 333333.33)
                {
                    tax = (((((grossincome * 24) - 2000000) * 0.32) + 490000) / 24);
                    tax_contribTxtbox.Text = tax.ToString("n");
                }
                else
                {
                    tax = (((((grossincome * 24) - 8000000) * 0.35) + 2410000) / 24);
                    tax_contribTxtbox.Text = tax.ToString("n");
                }

                pagibig_contribTxtbox.Text = "100";
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void hono_numhrsTxtbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                hono_numhrs = Convert.ToDouble(hono_numhrsTxtbox.Text);
                hono_rate = Convert.ToDouble(hono_rateTxtbox.Text);
                hono_netincome = hono_numhrs * hono_rate;
                hono_netincomeTxtbox.Text = hono_netincome.ToString("n");
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void basic_numhrsTxtbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                basic_numhrs = Convert.ToDouble(basic_numhrsTxtbox.Text);
                basic_rate = Convert.ToDouble(basic_rateTxtbox.Text);
                basic_netincome = basic_numhrs * basic_rate;
                basic_netincomeTxtbox.Text = basic_netincome.ToString("n");

                grossincome = basic_netincome + hono_netincome + others_netincome;
                gross_incomeTxtbox.Text = grossincome.ToString("n");
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        public Example4()
        {
            InitializeComponent();
        }

        private void Example4_Load(object sender, EventArgs e)
        {
            basic_netincomeTxtbox.Enabled = false;
            hono_netincomeTxtbox.Enabled = false;
            other_netincomeTxtbox.Enabled = false;
            net_incomeTxtbox.Enabled = false;
            gross_incomeTxtbox.Enabled = false;
            total_deducTxtbox.Enabled = false;
            philhealth_contribTxtbox.Enabled = false;
            sss_contribTxtbox.Enabled = false;
            pagibig_contribTxtbox.Enabled = false;
            tax_contribTxtbox.Enabled = false;
        }
    }
}
