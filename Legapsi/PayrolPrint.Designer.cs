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
            priDisplayListbox = new ListBox();
            SuspendLayout();
            // 
            // priDisplayListbox
            // 
            priDisplayListbox.FormattingEnabled = true;
            priDisplayListbox.ItemHeight = 15;
            priDisplayListbox.Location = new Point(40, 30);
            priDisplayListbox.Name = "priDisplayListbox";
            priDisplayListbox.Size = new Size(439, 559);
            priDisplayListbox.TabIndex = 0;
            priDisplayListbox.SelectedIndexChanged += priDisplayListbox_SelectedIndexChanged;
            // 
            // PayrolPrint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 647);
            Controls.Add(priDisplayListbox);
            Name = "PayrolPrint";
            Text = "PayrolPrint";
            Load += PayrolPrint_Load;
            ResumeLayout(false);
        }

        #endregion

        public ListBox priDisplayListbox;
    }
}