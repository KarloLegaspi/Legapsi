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
    public partial class TransactionPrint : Form
    {

        public TransactionPrint()
        {
            InitializeComponent();
            receiptList.Font = new Font("Consolas", 8);
            receiptList.HorizontalScrollbar = true;
        }

        private void receiptList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TransactionPrint_Load(object sender, EventArgs e)
        {

        }
    }
}
