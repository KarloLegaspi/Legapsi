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
    public partial class PayrolForm : Form
    {
        private string picpath;
        private Double basic_netincome = 0.00,
            basic_numhrs = 0.00,
            basic_rate = 0.00,
            hono_netincome = 0.00,
            hono_numhrs = 0.00,
            hono_rate = 0.00,
            other_netincome = 0.00,
            other_numhrs = 0.00,
            other_rate = 0.00;
        private double grossincome;
        private double sss_contrib;
        private double pagibig_contrib;
        private double philhealth_contrib;
        private double tax_contrib;
        private double sss_loan;
        private double pagibig_loan;
        private double salay_loan;
        private double faculty_sav_loan;
        private double salary_savings;
        private double other_deduction;
        private double total_contrib;
        private double total_loan;
        private double total_deduction;
        private double netincome;
        private object priDisplayListBox;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public PayrolForm()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.Title = "Select Employee Picture";

            openFileDialog.ShowDialog();
            picpath = openFileDialog.FileName;
            picpathTxtbox.Text = picpath;
            pictureBox2.Image = Image.FromFile(picpath);
        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void PayrolForm_Load(object sender, EventArgs e)
        {
            basic_netincomeTxtbox.Enabled = false;
            hono_netincomeTxtbox.Enabled = false;
            other_netincomeTxtbox.Enabled = false;
            net_incomeTxtbox.Enabled = false;
            gross_incomeTxtbox.Enabled = false;
            total_deducTxtbox.Enabled = false;
            sss_contribTxtbox.Text = "0.00";
            pagibig_contribTxtbox.Text = "0.00";
            philhealth_contribTxtbox.Text = "0.00";
            tax_contribTxtbox.Text = "0.00";
            sss_loanTxtbox.Text = "0.00";
            pagibig_loanTxtbox.Text = "0.00";
            FSD_depositTxtbox.Text = "0.00";
            FS_loanTxtbox.Text = "0.00";
            sal_loanTxtbox.Text = "0.00";
            otherLoanTxtbox.Text = "0.00";
            others_loanCombo.Text = "Select other deduction";
            others_loanCombo.Items.Add("other 1");
            others_loanCombo.Items.Add("other 2");
            others_loanCombo.Items.Add("other 3");
            others_loanCombo.Items.Add("other 4");
            picpathTxtbox.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // codes for calling the other form connected to the current form print1 = new Assignment_Payroll PrintFrm();
            PayrolForm print1 = new PayrolForm();
            // codes for displaying the contents of the list box from other form to the current form
            PayrolPrint printForm = new PayrolPrint();
            // Ensure priDisplayListBox is a ListBox, and both controls are accessible
            print1.priDisplayListBox.Items.AddRange(this.payslip_viewListBox.Items.OfType<object>().ToArray());

            print1.Show();
            //code for displaying the other form
            print1.Show();
        }
        
        private void basic_rateTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void basic_numhrsTxtbox_TextChanged(object sender, EventArgs e)
        {
            basic_numhrs = Double.Parse(basic_numhrsTxtbox.Text);
            basic_rate = Convert.ToDouble(basic_rateTxtbox.Text);
            basic_netincome = basic_numhrs * basic_rate;
            basic_netincomeTxtbox.Text = basic_netincome.ToString("n");
        }

        private void hono_numhrsTxtbox_TextChanged(object sender, EventArgs e)
        {
            hono_numhrs = Convert.ToDouble(hono_numhrsTxtbox.Text);
            hono_rate = Convert.ToDouble(hono_rateTxtbox.Text);
            hono_netincome = hono_numhrs * hono_rate;
            hono_netincomeTxtbox.Text = hono_netincome.ToString("n");
        }

        private void other_numhrsTxtbox_TextChanged(object sender, EventArgs e)
        {
            other_numhrs = Convert.ToDouble(other_numhrsTxtbox.Text);
            other_rate = Convert.ToDouble(other_rateTxtbox.Text);
            other_netincome = other_numhrs * other_rate;
            other_netincomeTxtbox.Text = other_netincome.ToString("n");
            grossincome = basic_netincome + hono_netincome + other_netincome;
            gross_incomeTxtbox.Text = grossincome.ToString("n");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // codes for converting input data from textbox as string to numeric
            // codes for putting data from textbox to variables
            sss_contrib = Convert.ToDouble(sss_contribTxtbox.Text);
            pagibig_contrib = Convert.ToDouble(pagibig_contribTxtbox.Text);
            philhealth_contrib = Convert.ToDouble(philhealth_contribTxtbox.Text);
            tax_contrib = Convert.ToDouble(tax_contribTxtbox.Text);
            sss_loan = Convert.ToDouble(sss_loanTxtbox.Text);
            pagibig_loan = Convert.ToDouble(pagibig_loanTxtbox.Text);
            salay_loan = Convert.ToDouble(sal_loanTxtbox.Text);
            faculty_sav_loan = Convert.ToDouble(FS_loanTxtbox.Text);
            salary_savings = Convert.ToDouble(FSD_depositTxtbox.Text);
            other_deduction = Convert.ToDouble(otherLoanTxtbox.Text);

            // dormula to compute the desired data to be computed
            total_contrib = sss_contrib + pagibig_contrib + philhealth_contrib + tax_contrib;
            total_loan = sss_loan + pagibig_loan + salay_loan + faculty_sav_loan + other_deduction;
            total_deduction = total_contrib + total_loan;

            // codes for converting numeric data to string and displayed it inside the text boxes
            total_deducTxtbox.Text = total_deduction.ToString("n");
            netincome = grossincome - total_deduction;
            net_incomeTxtbox.Text = netincome.ToString("n");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            emp_nuTxtbox.Clear();
            firstnameTxtbox.Clear();
            MNameTxtbox.Clear();
            surTxtbox.Clear();
            civil_statusTxtbox.Clear();
            desigTxtbox.Clear();
            desigTxtbox.Clear();
            numDependentTxtbox.Clear();
            empStatusTxtbox.Clear();
            DeptNameTxtbox.Clear();
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
            sss_loanTxtbox.Clear();
            pagibig_loanTxtbox.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            emp_nuTxtbox.Clear();
            firstnameTxtbox.Clear();
            MNameTxtbox.Clear();
            surTxtbox.Clear();
            civil_statusTxtbox.Clear();
            desigTxtbox.Clear();
            desigTxtbox.Clear();
            numDependentTxtbox.Clear();
            empStatusTxtbox.Clear();
            DeptNameTxtbox.Clear();
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
            sss_loanTxtbox.Clear();
            pagibig_loanTxtbox.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // payslip_viewListBox.Items.Add("");
            payslip_viewListBox.Items.Add("Employee Number: " + "" + emp_nuTxtbox.Text);
            payslip_viewListBox.Items.Add("First Name: " + "" + firstnameTxtbox.Text);
            payslip_viewListBox.Items.Add("Middlename: " + "" + MNameTxtbox.Text);
            payslip_viewListBox.Items.Add("Surname: " + "" + surTxtbox.Text);
            payslip_viewListBox.Items.Add("Designation: " + "" + desigTxtbox.Text);
            payslip_viewListBox.Items.Add("Employee Status: " + "" + empStatusTxtbox.Text);
            payslip_viewListBox.Items.Add("Department: " + "" + DeptNameTxtbox.Text);
            payslip_viewListBox.Items.Add("Pay Date: " + "" + paydateDatePicker.Text);
            payslip_viewListBox.Items.Add("--------------------------------------------------------------------------------------------------------------------------------------------------------");
            payslip_viewListBox.Items.Add("BP Num. of Hrs.: " + "P " + basic_numhrsTxtbox.Text);
            payslip_viewListBox.Items.Add("BP Rate / Hr.: " + "P " + basic_rateTxtbox.Text);
            payslip_viewListBox.Items.Add("Basic Pay Income: " + "P " + basic_netincomeTxtbox.Text);
            payslip_viewListBox.Items.Add("");
            payslip_viewListBox.Items.Add("HNR Num. of Hrs.: " + "P " + hono_numhrsTxtbox.Text);
            payslip_viewListBox.Items.Add("HI Rate / Hr.: " + "P " + hono_rateTxtbox.Text);
            payslip_viewListBox.Items.Add("Honorarium Income: " + "P " + hono_netincomeTxtbox.Text);
            payslip_viewListBox.Items.Add("");
            payslip_viewListBox.Items.Add("OTI Num. of Hrs.: " + "P " + other_numhrsTxtbox.Text);
            payslip_viewListBox.Items.Add("OTI Rate / Hr.: " + "P " + other_rateTxtbox.Text);
            payslip_viewListBox.Items.Add("Other Income: " + "P " + other_netincomeTxtbox.Text);
            payslip_viewListBox.Items.Add("--------------------------------------------------------------------------------------------------------------------------------------------------------");
            payslip_viewListBox.Items.Add("SSS Contribution: " + "P " + sss_contribTxtbox.Text);
            payslip_viewListBox.Items.Add("Pag-IBIG Contribution: " + "P " + pagibig_contribTxtbox.Text);
            payslip_viewListBox.Items.Add("PhilHealth Contribution: " + "P " + philhealth_contribTxtbox.Text);
            payslip_viewListBox.Items.Add("Tax Contribution: " + "P " + tax_contribTxtbox.Text);
            payslip_viewListBox.Items.Add("SSS Loan: " + "P " + sss_loanTxtbox.Text);
            payslip_viewListBox.Items.Add("Pag-IBIG Loan: " + "P " + pagibig_loanTxtbox.Text);
            payslip_viewListBox.Items.Add("Salary Loan: " + "P " + sal_loanTxtbox.Text);
            payslip_viewListBox.Items.Add("Faculty Savings Loan: " + "P " + FS_loanTxtbox.Text);
            payslip_viewListBox.Items.Add("FSD Deposit: " + "P " + FSD_depositTxtbox.Text);
            payslip_viewListBox.Items.Add("Other Loan: " + "P " + otherLoanTxtbox.Text);
            payslip_viewListBox.Items.Add("--------------------------------------------------------------------------------------------------------------------------------------------------------");
            payslip_viewListBox.Items.Add("Total Deduction: " + "P " + total_deducTxtbox.Text);
            payslip_viewListBox.Items.Add("Net Income: " + "P " + net_incomeTxtbox.Text);
            payslip_viewListBox.Items.Add("Gross Income: " + "P " + gross_incomeTxtbox.Text);
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void payslip_viewListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }
    }
}
