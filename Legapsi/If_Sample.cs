using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOP_LEGASPI_CPE201
{
    public partial class If_Sample : Form
    {
        private Double basic_income = 0.00,
            basic_numhrs = 0.00,
            basic_rate = 0.00,
            hono_income = 0.00,
            hono_numhrs = 0.00,
            hono_rate = 0.00,
            other_income = 0.00,
            other_numhrs = 0.00,
            other_rate = 0.00;
        private Double tax = 0.00;

        private void other_numhrstxtbox_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(other_numhrstxtbox.Text, out other_numhrs);
            double.TryParse(other_ratetxtbox.Text, out other_rate);
        }

        private void netibtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (grossincome == 0)
                {
                    throw new Exception();
                }

                double sss = 0, philhealth = 0, pagibig = 0;
                double sssloan = 0, pagibigloan = 0, fsd = 0, fsloan = 0, salloan = 0, otherloan = 0;
                double total_deductions = 0;

                // GET CONTRIBUTIONS
                double.TryParse(sss_contribtxtbox.Text, out sss);
                double.TryParse(philhealth_contribtxtbox.Text, out philhealth);
                double.TryParse(pagibig_contribtxtbox.Text, out pagibig);

                // GET LOANS
                double.TryParse(sss_loantxtbox.Text, out sssloan);
                double.TryParse(pagibig_loantxtbox.Text, out pagibigloan);
                double.TryParse(FSD_deposittxtbox.Text, out fsd);
                double.TryParse(FS_loantxtbox.Text, out fsloan);
                double.TryParse(sal_loantxtbox.Text, out salloan);
                double.TryParse(other_loantxtbox.Text, out otherloan);

                // TOTAL DEDUCTIONS
                total_deductions = sss + philhealth + pagibig +
                                   sssloan + pagibigloan + fsd +
                                   fsloan + salloan + otherloan;

                total_deductxtbox.Text = total_deductions.ToString("n");

                // NET INCOME
                netincome = grossincome - total_deductions;
                net_incometxtbox.Text = netincome.ToString("n");
            }
            catch
            {
                MessageBox.Show("Please compute Gross Income first.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void total_deductxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void net_incometxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void gross_incometxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void newbtn_Click(object sender, EventArgs e)
        {
            basic_numhrstxtbox.Clear();
            basic_ratetxtbox.Clear();
            hono_numhrstxtbox.Clear();
            hono_ratetxtbox.Clear();
            other_numhrstxtbox.Clear();
            other_ratetxtbox.Clear();

            sss_loantxtbox.Text = "0.00";
            pagibig_loantxtbox.Text = "0.00";
            FSD_deposittxtbox.Text = "0.00";
            FS_loantxtbox.Text = "0.00";
            sal_loantxtbox.Text = "0.00";
            other_loantxtbox.Text = "0.00";

            basic_incometxtbox.Clear();
            hono_incometxtbox.Clear();
            other_incometxtbox.Clear();
            gross_incometxtbox.Clear();
            net_incometxtbox.Clear();
            total_deductxtbox.Clear();

            sss_contribtxtbox.Text = "0.00";
            philhealth_contribtxtbox.Text = "0.00";
            pagibig_contribtxtbox.Text = "0.00";
            tax_contribtxtbox.Text = "0.00";

            basic_income = 0;
            hono_income = 0;
            other_income = 0;
            grossincome = 0;
            netincome = 0;
            tax = 0;

            //SET CURSOR BACK TO FIRST INPUT
            basic_numhrstxtbox.Focus();
        }

        private void If_Sample_Load(object sender, EventArgs e)
        {

        }

        private void sss_loantxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void other_ratetxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void hono_incometxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void hono_numhrstxtbox_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(hono_numhrstxtbox.Text, out hono_numhrs);
            double.TryParse(hono_ratetxtbox.Text, out hono_rate);
        }

        private void basic_numhrstxtbox_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(basic_numhrstxtbox.Text, out basic_numhrs);
            double.TryParse(basic_ratetxtbox.Text, out basic_rate);
        }

        private Double netincome = 0.00,
            grossincome = 0.00;


        public If_Sample()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void basicipc_TextChanged(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            basic_incometxtbox.Enabled = false;
            hono_incometxtbox.Enabled = false;
            other_incometxtbox.Enabled = false;
            net_incometxtbox.Enabled = false;
            gross_incometxtbox.Enabled = false;
            total_deductxtbox.Enabled = false;
            sss_contribtxtbox.Text = "0.00";
            pagibig_contribtxtbox.Text = "0.00";
            philhealth_contribtxtbox.Text = "0.00";
            tax_contribtxtbox.Text = "0.00";
            sss_loantxtbox.Text = "0.00";
            pagibig_loantxtbox.Text = "0.00";
            FSD_deposittxtbox.Text = "0.00";
            FS_loantxtbox.Text = "0.00";
            sal_loantxtbox.Text = "0.00";
            other_loantxtbox.Text = "0.00";


        }

        private void grossibtn_Click(object sender, EventArgs e)
        {
            // COMPUTE INCOME
            basic_income = basic_numhrs * basic_rate;
            hono_income = hono_numhrs * hono_rate;
            other_income = other_numhrs * other_rate;

            basic_incometxtbox.Text = basic_income.ToString("n");
            hono_incometxtbox.Text = hono_income.ToString("n");
            other_incometxtbox.Text = other_income.ToString("n");

            // COMPUTE GROSS
            grossincome = basic_income + hono_income + other_income;
            gross_incometxtbox.Text = grossincome.ToString("n");

            pagibig_contribtxtbox.Text = "100.00";

            try
            {
                double.TryParse(other_numhrstxtbox.Text, out other_numhrs);
                double.TryParse(other_ratetxtbox.Text, out other_rate);
                other_income = other_numhrs * other_rate;
                other_incometxtbox.Text = other_income.ToString("n");
                // UPDATE GROSS
                grossincome = basic_income + hono_income + other_income;
                gross_incometxtbox.Text = grossincome.ToString("n");
                pagibig_contribtxtbox.Text = "100.00";

                //philhealth contribution based from the current table
                if (grossincome <= 10000)
                {
                    philhealth_contribtxtbox.Text = "137.50";
                }
                else if (grossincome > 10000 && grossincome <= 11000)
                {
                    philhealth_contribtxtbox.Text = "151.125";
                }
                else if (grossincome > 11000 && grossincome <= 12000)
                {
                    philhealth_contribtxtbox.Text = "165.00";
                }
                else if (grossincome > 12000 && grossincome <= 13000)
                {
                    philhealth_contribtxtbox.Text = "178.75";
                }
                else if (grossincome > 13000 && grossincome <= 14000)
                {
                    philhealth_contribtxtbox.Text = "192.50";
                }
                else if (grossincome > 14000 && grossincome <= 15000)
                {
                    philhealth_contribtxtbox.Text = "206.25";
                }
                else if (grossincome > 15000 && grossincome <= 16000)
                {
                    philhealth_contribtxtbox.Text = "220.00";
                }
                else if (grossincome > 16000 && grossincome <= 17000)
                {
                    philhealth_contribtxtbox.Text = "233.75";
                }
                else if (grossincome > 17000 && grossincome <= 18000)
                {
                    philhealth_contribtxtbox.Text = "247.50";
                }
                else if (grossincome > 18000 && grossincome <= 19000)
                {
                    philhealth_contribtxtbox.Text = "261.25";
                }
                else if (grossincome > 19000 && grossincome <= 20000)
                {
                    philhealth_contribtxtbox.Text = "275.00";
                }
                else if (grossincome > 20000 && grossincome <= 21000)
                {
                    philhealth_contribtxtbox.Text = "288.75";
                }
                else if (grossincome > 21000 && grossincome <= 22000)
                {
                    philhealth_contribtxtbox.Text = "302.50";
                }
                else if (grossincome > 22000 && grossincome <= 23000)
                {
                    philhealth_contribtxtbox.Text = "316.25";
                }
                else if (grossincome > 23000 && grossincome <= 24000)
                {
                    philhealth_contribtxtbox.Text = "330.00";
                }
                else if (grossincome > 24000 && grossincome <= 25000)
                {
                    philhealth_contribtxtbox.Text = "343.75";
                }
                else if (grossincome > 25000 && grossincome <= 26000)
                {
                    philhealth_contribtxtbox.Text = "357.50";
                }
                else if (grossincome > 26000 && grossincome <= 27000)
                {
                    philhealth_contribtxtbox.Text = "371.25";
                }
                else if (grossincome > 27000 && grossincome <= 28000)
                {
                    philhealth_contribtxtbox.Text = "385.00";
                }
                else if (grossincome > 28000 && grossincome <= 29000)
                {
                    philhealth_contribtxtbox.Text = "398.75";
                }
                else if (grossincome > 29000 && grossincome <= 30000)
                {
                    philhealth_contribtxtbox.Text = "412.50";
                }
                else if (grossincome > 30000 && grossincome <= 31000)
                {
                    philhealth_contribtxtbox.Text = "426.25";
                }
                else if (grossincome > 31000 && grossincome <= 32000)
                {
                    philhealth_contribtxtbox.Text = "440.00";
                }
                else if (grossincome > 32000 && grossincome <= 33000)
                {
                    philhealth_contribtxtbox.Text = "453.75";
                }
                else if (grossincome > 33000 && grossincome <= 34000)
                {
                    philhealth_contribtxtbox.Text = "467.50";
                }
                else if (grossincome > 34000 && grossincome <= 35000)
                {
                    philhealth_contribtxtbox.Text = "481.25";
                }
                else if (grossincome > 35000 && grossincome <= 36000)
                {
                    philhealth_contribtxtbox.Text = "495.00";
                }
                else if (grossincome > 36000 && grossincome <= 37000)
                {
                    philhealth_contribtxtbox.Text = "508.75";
                }
                else if (grossincome > 37000 && grossincome <= 38000)
                {
                    philhealth_contribtxtbox.Text = "522.50";
                }
                else if (grossincome > 38000 && grossincome <= 39000)
                {
                    philhealth_contribtxtbox.Text = "536.25";
                }
                else if (grossincome > 39000 && grossincome <= 39999.99)
                {
                    philhealth_contribtxtbox.Text = "543.13";
                }
                else
                    philhealth_contribtxtbox.Text = "550.00";
                //SSS contribution based on the current table from SSS
                if (grossincome < 1000)
                {
                    sss_contribtxtbox.Text = "0.00";
                }
                else if (grossincome > 1000 && grossincome <= 1249.99)
                {
                    sss_contribtxtbox.Text = "36.30";
                }
                else if (grossincome > 1250 && grossincome <= 1749.99)
                {
                    sss_contribtxtbox.Text = "54.50";
                }
                else if (grossincome > 1750 && grossincome <= 2249.99)
                {
                    sss_contribtxtbox.Text = "72.70";
                }
                else if (grossincome > 2250 && grossincome <= 2749.99)
                {
                    sss_contribtxtbox.Text = "90.80";
                }
                else if (grossincome > 2750 && grossincome <= 3249.99)
                {
                    sss_contribtxtbox.Text = "109.00";
                }
                else if (grossincome > 3250 && grossincome <= 3749.99)
                {
                    sss_contribtxtbox.Text = "127.20";
                }
                else if (grossincome > 3750 && grossincome <= 4249.99)
                {
                    sss_contribtxtbox.Text = "145.30";
                }
                else if (grossincome > 4250 && grossincome <= 4749.99)
                {
                    sss_contribtxtbox.Text = "163.50";
                }
                else if (grossincome > 4750 && grossincome <= 5249.99)
                {
                    sss_contribtxtbox.Text = "181.70";
                }
                else if (grossincome > 5250 && grossincome <= 5749.99)
                {
                    sss_contribtxtbox.Text = "199.80";
                }
                else if (grossincome > 5750 && grossincome <= 6249.99)
                {
                    sss_contribtxtbox.Text = "218.00";
                }
                else if (grossincome > 6250 && grossincome <= 6749.99)
                {
                    sss_contribtxtbox.Text = "236.20";
                }
                else if (grossincome > 6750 && grossincome <= 7249.99)
                {
                    sss_contribtxtbox.Text = "254.30";
                }
                else if (grossincome > 7250 && grossincome <= 7749.99)
                {
                    sss_contribtxtbox.Text = "272.50";
                }
                else if (grossincome > 7750 && grossincome <= 8249.99)
                {
                    sss_contribtxtbox.Text = "290.70";
                }
                else if (grossincome > 8250 && grossincome <= 8749.99)
                {
                    sss_contribtxtbox.Text = "308.80";
                }
                else if (grossincome > 8750 && grossincome <= 9249.99)
                {
                    sss_contribtxtbox.Text = "327.00";
                }
                else if (grossincome > 9250 && grossincome <= 9749.99)
                {
                    sss_contribtxtbox.Text = "345.20";
                }
                else if (grossincome > 9750 && grossincome <= 10249.99)
                {
                    sss_contribtxtbox.Text = "363.30";
                }
                else if (grossincome > 10250 && grossincome <= 10749.99)
                {
                    sss_contribtxtbox.Text = "381.50";
                }
                else if (grossincome > 10750 && grossincome <= 11249.99)
                {
                    sss_contribtxtbox.Text = "399.70";
                }
                else if (grossincome > 11250 && grossincome <= 11749.99)
                {
                    sss_contribtxtbox.Text = "417.80";
                }
                else if (grossincome > 11750 && grossincome <= 12249.99)
                {
                    sss_contribtxtbox.Text = "436.00";
                }
                else if (grossincome > 12250 && grossincome <= 12749.99)
                {
                    sss_contribtxtbox.Text = "454.20";
                }
                else if (grossincome > 12750 && grossincome <= 13249.99)
                {
                    sss_contribtxtbox.Text = "472.30";
                }
                else if (grossincome > 13250 && grossincome <= 13749.99)
                {
                    sss_contribtxtbox.Text = "490.50";
                }
                else if (grossincome > 13750 && grossincome <= 14249.99)
                {
                    sss_contribtxtbox.Text = "508.70";
                }
                else if (grossincome > 14250 && grossincome <= 14749.99)
                {
                    sss_contribtxtbox.Text = "526.80";
                }
                else if (grossincome > 14750 && grossincome <= 15249.99)
                {
                    sss_contribtxtbox.Text = "545.00";
                }
                else if (grossincome > 15250 && grossincome <= 15749.99)
                {
                    sss_contribtxtbox.Text = "563.20";
                }
                else if (grossincome > 15750 && grossincome <= 16249.99)
                {
                    sss_contribtxtbox.Text = "581.30";
                }
                //tax contribution per month based on new table of TAX 2019
                if (grossincome <= (250000 / 24))
                {
                    tax_contribtxtbox.Text = "0.00";
                }
                else if (grossincome > 10416.67 && grossincome <= 16666.67)
                {
                    tax = ((((grossincome * 24) - 250000) * 0.20) / 24);
                    tax_contribtxtbox.Text = tax.ToString("n");
                }
                else if (grossincome > 16666.67 && grossincome <= 33333.33)
                {
                    tax = ((((grossincome * 24) - 400000) * 0.25) + 30000) / 24;
                    tax_contribtxtbox.Text = tax.ToString("n");
                }
                else if (grossincome > 33333.33 && grossincome <= 83333.33)
                {
                    tax = ((((grossincome * 24) - 800000) * 0.30) + 130000) / 24;
                    tax_contribtxtbox.Text = tax.ToString("n");
                }
                else if (grossincome > 83333.33 && grossincome <= 208333.33)
                {
                    tax = ((((grossincome * 24) - 2000000) * 0.32) + 490000) / 24;
                    tax_contribtxtbox.Text = tax.ToString("n");
                }
                else if (grossincome > 208333.33 && grossincome <= 416666.67)
                {
                    tax = ((((grossincome * 24) - 8000000) * 0.35) + 2410000) / 24;
                    tax_contribtxtbox.Text = tax.ToString("n");
                }
                else
                {
                    tax = ((((grossincome * 24) - 8000000) * 0.35) + 2410000) / 24;
                    tax_contribtxtbox.Text = tax.ToString("n");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid data entry");
                other_numhrstxtbox.Clear();
                other_numhrstxtbox.Focus();
            }

        }
    }
}
