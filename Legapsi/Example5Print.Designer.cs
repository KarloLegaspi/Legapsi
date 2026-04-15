namespace OOP_LEGASPI_CPE201
{
    partial class Example5Print
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
            priDisplayListBox.FormattingEnabled = true;
            priDisplayListBox.ItemHeight = 15;
            priDisplayListBox.Location = new Point(15, 15);
            priDisplayListBox.Margin = new Padding(4, 3, 4, 3);
            priDisplayListBox.Name = "priDisplayListBox";
            priDisplayListBox.Size = new Size(363, 649);
            priDisplayListBox.TabIndex = 0;
            priDisplayListBox.SelectedIndexChanged += priDisplayListBox_SelectedIndexChanged_1;
            // 
            // Example5Print
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 670);
            Controls.Add(priDisplayListBox);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Example5Print";
            Text = "Example5Prnt";
            ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox priDisplayListBox;
    }
}