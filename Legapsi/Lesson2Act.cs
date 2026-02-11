using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace OOP_LEGASPI_CPE201
{
    public partial class Lesson2Act : Form
    {
        public Lesson2Act()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(student_name.Text);
            listBox2.Items.Add(course_code.Text);
            listBox3.Items.Add(course_disc.Text);
            listBox4.Items.Add(unit_lec.Text);
            listBox5.Items.Add(unit_lab.Text);
            listBox6.Items.Add(cred_unit.Text);
            listBox7.Items.Add(time.Text);
            listBox8.Items.Add(day.Text);

            total_tuitionfee.Text = totaltuition_fee.Text;
            final_misc.Text = total_misc.Text;
            final_numunit.Text = totalnum_unit.Text;
            final_tuitionandfee.Text = total_tuitionandfee.Text;
            final_lab.Text = lab_fee.Text;
            final_cisc.Text = cisco_lab.Text;
            final_exam.Text = exam_booklet.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            student_name.Clear();
            course_code.Clear();
            course_disc.Clear();
            unit_lec.Clear();
            unit_lab.Clear();
            cred_unit.Clear();
            time.Clear();
            day.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            listBox7.Items.Clear();
            listBox8.Items.Clear();
            totaltuition_fee.Clear();
            total_misc.Clear();
            totalnum_unit.Clear();
            total_tuitionandfee.Clear();
            final_lab.Clear();
            final_cisc.Clear();
            final_exam.Clear();
            name.Clear();
            comboBox1.SelectedIndex = -1;
            student_num.Clear();
            year_level.Clear();
            scholar.Clear();
            pictureBox1.Image = null;
        }

        private void Lesson2Act_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Mechanical Engineering");
            comboBox1.Items.Add("Civil Engineering");
            comboBox1.Items.Add("Computer Engineering");
            comboBox1.Items.Add("Aeronautical Engineering");
            comboBox1.Items.Add("Industrial Engineering");
            comboBox1.DroppedDown = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
