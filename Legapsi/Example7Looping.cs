using Legapsi;
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
    public partial class Example7Looping : Form
    {
        public Example7Looping()
        {
            InitializeComponent();
        }

        private void activity1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity1 activity1 = new Activity1();
            activity1.MdiParent = this;
            activity1.Show();
        }

        private void activity2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity2 activity2 = new Activity2();
            activity2.MdiParent = this;
            activity2.Show();
        }

        private void activity3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity3 activity3 = new Activity3();
            activity3.MdiParent = this;
            activity3.Show();
        }

        private void activity4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lesson2Act lesson2Act = new Lesson2Act();
            lesson2Act.MdiParent = this;
            lesson2Act.Show();
        }

        private void activity5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FoodOrdering foodOrdering = new FoodOrdering();
            foodOrdering.MdiParent = this;
            foodOrdering.Show();
        }

        private void activity6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PayrolForm payrolForm = new PayrolForm();
            payrolForm.MdiParent = this;
            payrolForm.Show();
        }

        private void activity5PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FoodOrderingPrint foodOrderingPrint = new FoodOrderingPrint();
            foodOrderingPrint.MdiParent = this;
            foodOrderingPrint.Show();
        }

        private void activity6PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PayrolPrint payrolPrint = new PayrolPrint();
            payrolPrint.MdiParent = this;
            payrolPrint.Show();
        }

        private void activity1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            If_Sample if_Sample = new If_Sample();
            if_Sample.MdiParent = this;
            if_Sample.Show();
        }

        private void activity2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Example4 example4 = new Example4();
            example4.MdiParent = this;
            example4.Show();
        }

        private void activity3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Example5 example5 = new Example5();
            example5.MdiParent = this;
            example5.Show();
        }

        private void mIDTERMToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            while_loop while_loop = new while_loop();
            while_loop = new while_loop();
            while_loop.Show();
        }

        private void cASCADINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
