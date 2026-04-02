namespace OOP_LEGASPI_CPE201
{
    partial class TransactionPrint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            receiptList = new ListBox();
            SuspendLayout();
            // 
            // receiptList
            // 
            receiptList.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            receiptList.FormattingEnabled = true;
            receiptList.ItemHeight = 13;
            receiptList.Location = new Point(15, 15);
            receiptList.Margin = new Padding(4, 3, 4, 3);
            receiptList.Name = "receiptList";
            receiptList.Size = new Size(360, 550);
            receiptList.TabIndex = 0;
            // 
            // TransactionPrint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 597);
            Controls.Add(receiptList);
            Margin = new Padding(4, 3, 4, 3);
            Name = "TransactionPrint";
            Text = "TransactionPrint";
            Load += TransactionPrint_Load;
            ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox receiptList;
    }
}