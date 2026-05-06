using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace OOP_LEGASPI_CPE201
{
    partial class Lesson2_Example4_Classes
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
            changeTxtbox = new TextBox();
            label6 = new Label();
            cashgivenTxtbox = new TextBox();
            label5 = new Label();
            AmtpaidTxtbox = new TextBox();
            label4 = new Label();
            qtyTxtbox = new TextBox();
            label2 = new Label();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            priceTxtbox = new TextBox();
            label3 = new Label();
            itemnameTxtbox = new TextBox();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox15 = new PictureBox();
            pictureBox14 = new PictureBox();
            pictureBox13 = new PictureBox();
            pictureBox12 = new PictureBox();
            pictureBox11 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // changeTxtbox
            // 
//            changeTxtbox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            changeTxtbox.Location = new Point(794, 707);
            changeTxtbox.Margin = new Padding(4, 5, 4, 5);
            changeTxtbox.Name = "changeTxtbox";
            changeTxtbox.Size = new Size(131, 24);
            changeTxtbox.TabIndex = 82;
            // 
            // label6
            // 
            label6.AutoSize = true;
//            label6.Font = new Font("Microsoft Sans Serif", 9F);
            label6.Location = new Point(701, 707);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(63, 18);
            label6.TabIndex = 81;
            label6.Text = "Change:";
            // 
            // cashgivenTxtbox
            // 
//            cashgivenTxtbox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cashgivenTxtbox.Location = new Point(798, 658);
            cashgivenTxtbox.Margin = new Padding(4, 5, 4, 5);
            cashgivenTxtbox.Name = "cashgivenTxtbox";
            cashgivenTxtbox.Size = new Size(131, 24);
            cashgivenTxtbox.TabIndex = 80;
            // 
            // label5
            // 
            label5.AutoSize = true;
//            label5.Font = new Font("Microsoft Sans Serif", 9F);
            label5.Location = new Point(705, 667);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(89, 18);
            label5.TabIndex = 79;
            label5.Text = "Cash Given:";
            // 
            // AmtpaidTxtbox
            // 
//            AmtpaidTxtbox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AmtpaidTxtbox.Location = new Point(396, 701);
            AmtpaidTxtbox.Margin = new Padding(4, 5, 4, 5);
            AmtpaidTxtbox.Name = "AmtpaidTxtbox";
            AmtpaidTxtbox.Size = new Size(104, 24);
            AmtpaidTxtbox.TabIndex = 78;
            // 
            // label4
            // 
            label4.AutoSize = true;
 //           label4.Font = new Font("Microsoft Sans Serif", 9F);
            label4.Location = new Point(287, 704);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(96, 18);
            label4.TabIndex = 77;
            label4.Text = "Amount Paid:";
            // 
            // qtyTxtbox
            // 
//            qtyTxtbox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            qtyTxtbox.Location = new Point(593, 661);
            qtyTxtbox.Margin = new Padding(4, 5, 4, 5);
            qtyTxtbox.Name = "qtyTxtbox";
            qtyTxtbox.Size = new Size(104, 24);
            qtyTxtbox.TabIndex = 76;
            qtyTxtbox.TextChanged += qtyTxtbox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
 //           label2.Font = new Font("Microsoft Sans Serif", 9F);
            label2.Location = new Point(517, 667);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 18);
            label2.TabIndex = 75;
            label2.Text = "Quantity:";
            // 
            // button3
            // 
            button3.Location = new Point(946, 647);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(109, 115);
            button3.TabIndex = 74;
            button3.Text = "Calculate";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1063, 647);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(109, 58);
            button1.TabIndex = 73;
            button1.Text = "New";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1063, 714);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(109, 48);
            button2.TabIndex = 72;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // priceTxtbox
            // 
//            priceTxtbox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priceTxtbox.Location = new Point(396, 661);
            priceTxtbox.Margin = new Padding(4, 5, 4, 5);
            priceTxtbox.Name = "priceTxtbox";
            priceTxtbox.Size = new Size(104, 24);
            priceTxtbox.TabIndex = 71;
            // 
            // label3
            // 
            label3.AutoSize = true;
//            label3.Font = new Font("Microsoft Sans Serif", 9F);
            label3.Location = new Point(337, 667);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(46, 18);
            label3.TabIndex = 70;
            label3.Text = "Price:";
            // 
            // itemnameTxtbox
            // 
 //           itemnameTxtbox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            itemnameTxtbox.Location = new Point(130, 664);
            itemnameTxtbox.Margin = new Padding(4, 5, 4, 5);
            itemnameTxtbox.Name = "itemnameTxtbox";
            itemnameTxtbox.Size = new Size(189, 24);
            itemnameTxtbox.TabIndex = 69;
            // 
            // label1
            // 
            label1.AutoSize = true;
 //           label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 667);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 18);
            label1.TabIndex = 68;
            label1.Text = "Item Name:";
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(975, 451);
            pictureBox4.Margin = new Padding(4, 5, 4, 5);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(188, 175);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 67;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(975, 242);
            pictureBox5.Margin = new Padding(4, 5, 4, 5);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(188, 175);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 66;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(975, 32);
            pictureBox6.Margin = new Padding(4, 5, 4, 5);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(188, 175);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 65;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // pictureBox15
            // 
            pictureBox15.Location = new Point(733, 451);
            pictureBox15.Margin = new Padding(4, 5, 4, 5);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(192, 175);
            pictureBox15.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox15.TabIndex = 64;
            pictureBox15.TabStop = false;
            pictureBox15.Click += pictureBox15_Click;
            // 
            // pictureBox14
            // 
            pictureBox14.Location = new Point(733, 242);
            pictureBox14.Margin = new Padding(4, 5, 4, 5);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(192, 175);
            pictureBox14.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox14.TabIndex = 63;
            pictureBox14.TabStop = false;
            pictureBox14.Click += pictureBox14_Click;
            // 
            // pictureBox13
            // 
            pictureBox13.Location = new Point(733, 34);
            pictureBox13.Margin = new Padding(4, 5, 4, 5);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(192, 174);
            pictureBox13.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox13.TabIndex = 62;
            pictureBox13.TabStop = false;
            pictureBox13.Click += pictureBox13_Click;
            // 
            // pictureBox12
            // 
            pictureBox12.Location = new Point(496, 451);
            pictureBox12.Margin = new Padding(4, 5, 4, 5);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(180, 175);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 61;
            pictureBox12.TabStop = false;
            pictureBox12.Click += pictureBox12_Click;
            // 
            // pictureBox11
            // 
            pictureBox11.Location = new Point(496, 242);
            pictureBox11.Margin = new Padding(4, 5, 4, 5);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(180, 175);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 60;
            pictureBox11.TabStop = false;
            pictureBox11.Click += pictureBox11_Click;
            // 
            // pictureBox10
            // 
            pictureBox10.Location = new Point(496, 34);
            pictureBox10.Margin = new Padding(4, 5, 4, 5);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(180, 174);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 59;
            pictureBox10.TabStop = false;
            pictureBox10.Click += pictureBox10_Click;
            // 
            // pictureBox9
            // 
            pictureBox9.Location = new Point(257, 451);
            pictureBox9.Margin = new Padding(4, 5, 4, 5);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(183, 175);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 58;
            pictureBox9.TabStop = false;
            pictureBox9.Click += pictureBox9_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Location = new Point(257, 242);
            pictureBox8.Margin = new Padding(4, 5, 4, 5);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(183, 175);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 57;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Location = new Point(257, 34);
            pictureBox7.Margin = new Padding(4, 5, 4, 5);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(183, 174);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 56;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(39, 451);
            pictureBox3.Margin = new Padding(4, 5, 4, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(176, 175);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 55;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(40, 242);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(175, 175);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 54;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
  //          pictureBox1.Image = Properties.Resources._10;
            pictureBox1.Location = new Point(40, 34);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 174);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 53;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Lesson2_Example4_Classes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1201, 783);
            Controls.Add(changeTxtbox);
            Controls.Add(label6);
            Controls.Add(cashgivenTxtbox);
            Controls.Add(label5);
            Controls.Add(AmtpaidTxtbox);
            Controls.Add(label4);
            Controls.Add(qtyTxtbox);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(priceTxtbox);
            Controls.Add(label3);
            Controls.Add(itemnameTxtbox);
            Controls.Add(label1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox15);
            Controls.Add(pictureBox14);
            Controls.Add(pictureBox13);
            Controls.Add(pictureBox12);
            Controls.Add(pictureBox11);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Lesson2_Example4_Classes";
            Text = "Form1";
            Load += Lesson2_Example4_Classes_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox changeTxtbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cashgivenTxtbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AmtpaidTxtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox qtyTxtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox priceTxtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox itemnameTxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}