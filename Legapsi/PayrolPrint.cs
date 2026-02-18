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
    public partial class PayrolPrint : Form
    {
        internal object priDisplayListBox;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public PayrolPrint()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        {
            InitializeComponent();
        }

        private void PayrolPrint_Load(object sender, EventArgs e)
        {

        }

        private void payslip_viewListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
