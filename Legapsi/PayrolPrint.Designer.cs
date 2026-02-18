namespace OOP_LEGASPI_CPE201
{
    partial class PayrolPrint
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
            priDisplayListBox = new ListBox();
            SuspendLayout();
            // 
            // priDisplayListBox
            // 
            priDisplayListBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priDisplayListBox.FormattingEnabled = true;
            priDisplayListBox.ItemHeight = 15;
            priDisplayListBox.Location = new Point(12, 12);
            priDisplayListBox.Name = "priDisplayListBox";
            priDisplayListBox.Size = new Size(428, 664);
            priDisplayListBox.TabIndex = 1;
            priDisplayListBox.SelectedIndexChanged += this.payslip_viewListBox_SelectedIndexChanged;
            // 
            // PayrolPrint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1447, 677);
            Controls.Add(priDisplayListBox);
            Name = "PayrolPrint";
            Text = "PayrolPrint";
            Load += PayrolPrint_Load;
            ResumeLayout(false);
        }

        #endregion

        public ListBox priDisplayListBox;
    }
}