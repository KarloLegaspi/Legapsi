namespace OOP_LEGASPI_CPE201
{ 
    partial class while_loop
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
            this.numTimesDisplayTxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.displayListbox = new System.Windows.Forms.ListBox();
            this.countryCombobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // numTimesDisplayTxtbox
            // 
            this.numTimesDisplayTxtbox.Location = new System.Drawing.Point(157, 42);
            this.numTimesDisplayTxtbox.Multiline = true;
            this.numTimesDisplayTxtbox.Name = "numTimesDisplayTxtbox";
            this.numTimesDisplayTxtbox.Size = new System.Drawing.Size(160, 31);
            this.numTimesDisplayTxtbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter a number:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "SHOW";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(383, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "SELECT COUNTRY TO DISPLAY AT THE LISTBOX";
            // 
            // displayListbox
            // 
            this.displayListbox.FormattingEnabled = true;
            this.displayListbox.Location = new System.Drawing.Point(31, 142);
            this.displayListbox.Name = "displayListbox";
            this.displayListbox.Size = new System.Drawing.Size(380, 277);
            this.displayListbox.TabIndex = 4;
            // 
            // countryCombobox
            // 
            this.countryCombobox.FormattingEnabled = true;
            this.countryCombobox.Items.AddRange(new object[] {
            "Philippines",
            "Thailand",
            "China",
            "Hongkong",
            "Canada",
            "Hawaii",
            "South Korea"});
            this.countryCombobox.Location = new System.Drawing.Point(31, 115);
            this.countryCombobox.Name = "countryCombobox";
            this.countryCombobox.Size = new System.Drawing.Size(380, 21);
            this.countryCombobox.TabIndex = 34;
            // 
            // while_loop2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 450);
            this.Controls.Add(this.countryCombobox);
            this.Controls.Add(this.displayListbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numTimesDisplayTxtbox);
            this.Name = "while_loop2";
            this.Text = "Example6";
            this.Load += new System.EventHandler(this.while_loop2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numTimesDisplayTxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox displayListbox;
        private System.Windows.Forms.ComboBox countryCombobox;
    }
}