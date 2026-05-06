using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace OOP_LEGASPI_CPE201
{
    partial class Lesson2_Example4_Methods
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
            button3 = new Button();
            qtyTxtbox = new TextBox();
            label2 = new Label();
            AmtpaidTxtbox = new TextBox();
            label4 = new Label();
            cashgivenTxtbox = new TextBox();
            label5 = new Label();
            changeTxtbox = new TextBox();
            label6 = new Label();
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
            // button1
            // 
            button1.Location = new Point(1052, 723);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(109, 58);
            button1.TabIndex = 43;
            button1.Text = "New";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1052, 791);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(109, 48);
            button2.TabIndex = 42;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // priceTxtbox
            // 
 //           priceTxtbox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priceTxtbox.Location = new Point(389, 723);
            priceTxtbox.Margin = new Padding(4, 5, 4, 5);
            priceTxtbox.Name = "priceTxtbox";
            priceTxtbox.Size = new Size(104, 24);
            priceTxtbox.TabIndex = 41;
            // 
            // label3
            // 
            label3.AutoSize = true;
 //           label3.Font = new Font("Microsoft Sans Serif", 9F);
            label3.Location = new Point(330, 730);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(46, 18);
            label3.TabIndex = 40;
            label3.Text = "Price:";
            // 
            // itemnameTxtbox
            // 
//            itemnameTxtbox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            itemnameTxtbox.Location = new Point(124, 726);
            itemnameTxtbox.Margin = new Padding(4, 5, 4, 5);
            itemnameTxtbox.Name = "itemnameTxtbox";
            itemnameTxtbox.Size = new Size(189, 24);
            itemnameTxtbox.TabIndex = 39;
            // 
            // label1
            // 
            label1.AutoSize = true;
 //           label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 730);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 18);
            label1.TabIndex = 38;
            label1.Text = "Item Name:";
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(972, 494);
            pictureBox4.Margin = new Padding(4, 5, 4, 5);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(188, 193);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 37;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(972, 258);
            pictureBox5.Margin = new Padding(4, 5, 4, 5);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(188, 193);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 36;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(972, 23);
            pictureBox6.Margin = new Padding(4, 5, 4, 5);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(188, 193);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 35;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // pictureBox15
            // 
            pictureBox15.Location = new Point(731, 494);
            pictureBox15.Margin = new Padding(4, 5, 4, 5);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(192, 193);
            pictureBox15.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox15.TabIndex = 34;
            pictureBox15.TabStop = false;
            pictureBox15.Click += pictureBox15_Click;
            // 
            // pictureBox14
            // 
            pictureBox14.Location = new Point(731, 258);
            pictureBox14.Margin = new Padding(4, 5, 4, 5);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(192, 193);
            pictureBox14.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox14.TabIndex = 33;
            pictureBox14.TabStop = false;
            pictureBox14.Click += pictureBox14_Click;
            // 
            // pictureBox13
            // 
            pictureBox13.Location = new Point(731, 25);
            pictureBox13.Margin = new Padding(4, 5, 4, 5);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(192, 192);
            pictureBox13.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox13.TabIndex = 32;
            pictureBox13.TabStop = false;
            pictureBox13.Click += pictureBox13_Click;
            // 
            // pictureBox12
            // 
            pictureBox12.Location = new Point(493, 494);
            pictureBox12.Margin = new Padding(4, 5, 4, 5);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(180, 193);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 31;
            pictureBox12.TabStop = false;
            pictureBox12.Click += pictureBox12_Click;
            // 
            // pictureBox11
            // 
            pictureBox11.Location = new Point(493, 258);
            pictureBox11.Margin = new Padding(4, 5, 4, 5);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(180, 193);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 30;
            pictureBox11.TabStop = false;
            pictureBox11.Click += pictureBox11_Click;
            // 
            // pictureBox10
            // 
            pictureBox10.Location = new Point(493, 25);
            pictureBox10.Margin = new Padding(4, 5, 4, 5);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(180, 192);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 29;
            pictureBox10.TabStop = false;
            pictureBox10.Click += pictureBox10_Click;
            // 
            // pictureBox9
            // 
            pictureBox9.Location = new Point(255, 494);
            pictureBox9.Margin = new Padding(4, 5, 4, 5);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(183, 193);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 28;
            pictureBox9.TabStop = false;
            pictureBox9.Click += pictureBox9_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Location = new Point(255, 258);
            pictureBox8.Margin = new Padding(4, 5, 4, 5);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(183, 193);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 27;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Location = new Point(255, 25);
            pictureBox7.Margin = new Padding(4, 5, 4, 5);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(183, 192);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 26;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(36, 494);
            pictureBox3.Margin = new Padding(4, 5, 4, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(176, 193);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 25;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(37, 258);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(175, 193);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(37, 25);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 192);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(934, 723);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(109, 111);
            button3.TabIndex = 44;
            button3.Text = "Calculate";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // qtyTxtbox
            // 
 //           qtyTxtbox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            qtyTxtbox.Location = new Point(586, 723);
            qtyTxtbox.Margin = new Padding(4, 5, 4, 5);
            qtyTxtbox.Name = "qtyTxtbox";
            qtyTxtbox.Size = new Size(104, 24);
            qtyTxtbox.TabIndex = 46;
            qtyTxtbox.TextChanged += qtyTxtbox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
 //           label2.Font = new Font("Microsoft Sans Serif", 9F);
            label2.Location = new Point(510, 730);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 18);
            label2.TabIndex = 45;
            label2.Text = "Quantity:";
            // 
            // AmtpaidTxtbox
            // 
 //           AmtpaidTxtbox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AmtpaidTxtbox.Location = new Point(389, 779);
            AmtpaidTxtbox.Margin = new Padding(4, 5, 4, 5);
            AmtpaidTxtbox.Name = "AmtpaidTxtbox";
            AmtpaidTxtbox.Size = new Size(117, 24);
            AmtpaidTxtbox.TabIndex = 48;
            // 
            // label4
            // 
            label4.AutoSize = true;
 //           label4.Font = new Font("Microsoft Sans Serif", 9F);
            label4.Location = new Point(274, 783);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(96, 18);
            label4.TabIndex = 47;
            label4.Text = "Amount Paid:";
            // 
            // cashgivenTxtbox
            // 
 //           cashgivenTxtbox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cashgivenTxtbox.Location = new Point(792, 720);
            cashgivenTxtbox.Margin = new Padding(4, 5, 4, 5);
            cashgivenTxtbox.Name = "cashgivenTxtbox";
            cashgivenTxtbox.Size = new Size(131, 24);
            cashgivenTxtbox.TabIndex = 50;
            // 
            // label5
            // 
            label5.AutoSize = true;
 //           label5.Font = new Font("Microsoft Sans Serif", 9F);
            label5.Location = new Point(698, 730);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(89, 18);
            label5.TabIndex = 49;
            label5.Text = "Cash Given:";
            // 
            // changeTxtbox
            // 
//            changeTxtbox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            changeTxtbox.Location = new Point(792, 788);
            changeTxtbox.Margin = new Padding(4, 5, 4, 5);
            changeTxtbox.Name = "changeTxtbox";
            changeTxtbox.Size = new Size(131, 24);
            changeTxtbox.TabIndex = 52;
            // 
            // label6
            // 
            label6.AutoSize = true;
//            label6.Font = new Font("Microsoft Sans Serif", 9F);
            label6.Location = new Point(698, 788);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(63, 18);
            label6.TabIndex = 51;
            label6.Text = "Change:";
            // 
            // Lesson2_Example4_Methods
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1184, 905);
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
            Name = "Lesson2_Example4_Methods";
            Text = "Form1";
            Load += Form1_Load;
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox qtyTxtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AmtpaidTxtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cashgivenTxtbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox changeTxtbox;
        private System.Windows.Forms.Label label6;
    }
}