using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace OOP_LEGASPI_CPE201
{
    partial class Lesson3_Example2_Methods
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
            button19 = new Button();
            button20 = new Button();
            button18 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button8 = new Button();
            button9 = new Button();
            button7 = new Button();
            button6 = new Button();
            enter_button = new Button();
            groupBox3 = new GroupBox();
            txtbox_total_discounted = new TextBox();
            txtboxtotal_discount = new TextBox();
            txtboxtotal_quantity = new TextBox();
            total_discounted = new Label();
            label33 = new Label();
            label34 = new Label();
            label31 = new Label();
            changetxtbox = new TextBox();
            label30 = new Label();
            label29 = new Label();
            label28 = new Label();
            label26 = new Label();
            label27 = new Label();
            groupBox1 = new GroupBox();
            qty_txtbox = new TextBox();
            no_discount = new RadioButton();
            an_employee = new RadioButton();
            with_disc = new RadioButton();
            senior_citizen = new RadioButton();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            txtbox_discounted = new TextBox();
            txtbox_discount = new TextBox();
            txtbox_price = new TextBox();
            txtbox_itemname = new TextBox();
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label7 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            name14lbl = new PictureBox();
            name20lbl = new PictureBox();
            name19lbl = new PictureBox();
            label8 = new Label();
            name9lbl = new PictureBox();
            name3lbl = new PictureBox();
            name13lbl = new PictureBox();
            name7lbl = new PictureBox();
            name1lbl = new PictureBox();
            name18lbl = new PictureBox();
            name16lbl = new PictureBox();
            name15lbl = new PictureBox();
            name10lbl = new PictureBox();
            name4lbl = new PictureBox();
            name12lbl = new PictureBox();
            name8lbl = new PictureBox();
            name11lbl = new PictureBox();
            name6lbl = new PictureBox();
            name17lbl = new PictureBox();
            name5lbl = new PictureBox();
            name2lbl = new PictureBox();
            groupBox2 = new GroupBox();
            label32 = new Label();
            groupBox4 = new GroupBox();
            txtboxcash_rendered = new TextBox();
            label3 = new Label();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)name14lbl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)name20lbl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)name19lbl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)name9lbl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)name3lbl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)name13lbl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)name7lbl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)name1lbl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)name18lbl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)name16lbl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)name15lbl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)name10lbl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)name4lbl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)name12lbl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)name8lbl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)name11lbl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)name6lbl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)name17lbl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)name5lbl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)name2lbl).BeginInit();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // button19
            // 
            button19.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button19.Location = new Point(392, 596);
            button19.Margin = new Padding(4, 4, 4, 4);
            button19.Name = "button19";
            button19.Size = new Size(42, 26);
            button19.TabIndex = 283;
            button19.Text = "1";
            button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            button20.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button20.Location = new Point(343, 596);
            button20.Margin = new Padding(4, 4, 4, 4);
            button20.Name = "button20";
            button20.Size = new Size(42, 26);
            button20.TabIndex = 282;
            button20.Text = ".";
            button20.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            button18.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button18.Location = new Point(242, 596);
            button18.Margin = new Padding(4, 4, 4, 4);
            button18.Name = "button18";
            button18.Size = new Size(90, 26);
            button18.TabIndex = 281;
            button18.Text = "0";
            button18.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            button14.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button14.Location = new Point(392, 563);
            button14.Margin = new Padding(4, 4, 4, 4);
            button14.Name = "button14";
            button14.Size = new Size(42, 26);
            button14.TabIndex = 280;
            button14.Text = "5";
            button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            button15.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button15.Location = new Point(343, 563);
            button15.Margin = new Padding(4, 4, 4, 4);
            button15.Name = "button15";
            button15.Size = new Size(42, 26);
            button15.TabIndex = 279;
            button15.Text = "4";
            button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            button16.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button16.Location = new Point(293, 563);
            button16.Margin = new Padding(4, 4, 4, 4);
            button16.Name = "button16";
            button16.Size = new Size(42, 26);
            button16.TabIndex = 278;
            button16.Text = "3";
            button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            button17.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button17.Location = new Point(244, 563);
            button17.Margin = new Padding(4, 4, 4, 4);
            button17.Name = "button17";
            button17.Size = new Size(42, 26);
            button17.TabIndex = 277;
            button17.Text = "2";
            button17.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button10.Location = new Point(392, 530);
            button10.Margin = new Padding(4, 4, 4, 4);
            button10.Name = "button10";
            button10.Size = new Size(42, 26);
            button10.TabIndex = 276;
            button10.Text = "9";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button11.Location = new Point(392, 500);
            button11.Margin = new Padding(4, 4, 4, 4);
            button11.Name = "button11";
            button11.Size = new Size(42, 26);
            button11.TabIndex = 275;
            button11.Text = "+";
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button12.Location = new Point(343, 530);
            button12.Margin = new Padding(4, 4, 4, 4);
            button12.Name = "button12";
            button12.Size = new Size(42, 26);
            button12.TabIndex = 274;
            button12.Text = "8";
            button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button13.Location = new Point(343, 500);
            button13.Margin = new Padding(4, 4, 4, 4);
            button13.Name = "button13";
            button13.Size = new Size(42, 26);
            button13.TabIndex = 273;
            button13.Text = "-";
            button13.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button8.Location = new Point(293, 530);
            button8.Margin = new Padding(4, 4, 4, 4);
            button8.Name = "button8";
            button8.Size = new Size(42, 26);
            button8.TabIndex = 272;
            button8.Text = "7";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button9.Location = new Point(293, 500);
            button9.Margin = new Padding(4, 4, 4, 4);
            button9.Name = "button9";
            button9.Size = new Size(42, 26);
            button9.TabIndex = 271;
            button9.Text = "*";
            button9.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button7.Location = new Point(244, 530);
            button7.Margin = new Padding(4, 4, 4, 4);
            button7.Name = "button7";
            button7.Size = new Size(42, 26);
            button7.TabIndex = 270;
            button7.Text = "6";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button6.Location = new Point(244, 500);
            button6.Margin = new Padding(4, 4, 4, 4);
            button6.Name = "button6";
            button6.Size = new Size(42, 26);
            button6.TabIndex = 225;
            button6.Text = "/";
            button6.UseVisualStyleBackColor = true;
            // 
            // enter_button
            // 
            enter_button.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            enter_button.Location = new Point(46, 500);
            enter_button.Margin = new Padding(4, 4, 4, 4);
            enter_button.Name = "enter_button";
            enter_button.Size = new Size(189, 129);
            enter_button.TabIndex = 224;
            enter_button.Text = "ENTER";
            enter_button.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(txtbox_total_discounted);
            groupBox3.Controls.Add(txtboxtotal_discount);
            groupBox3.Controls.Add(txtboxtotal_quantity);
            groupBox3.Controls.Add(total_discounted);
            groupBox3.Controls.Add(label33);
            groupBox3.Controls.Add(label34);
            groupBox3.Location = new Point(46, 278);
            groupBox3.Margin = new Padding(4, 4, 4, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 4, 4, 4);
            groupBox3.Size = new Size(413, 114);
            groupBox3.TabIndex = 262;
            groupBox3.TabStop = false;
            groupBox3.Text = "Summary";
            // 
            // txtbox_total_discounted
            // 
            txtbox_total_discounted.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtbox_total_discounted.Location = new Point(157, 77);
            txtbox_total_discounted.Margin = new Padding(4, 4, 4, 4);
            txtbox_total_discounted.Name = "txtbox_total_discounted";
            txtbox_total_discounted.Size = new Size(247, 23);
            txtbox_total_discounted.TabIndex = 8;
            // 
            // txtboxtotal_discount
            // 
            txtboxtotal_discount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtboxtotal_discount.Location = new Point(157, 52);
            txtboxtotal_discount.Margin = new Padding(4, 4, 4, 4);
            txtboxtotal_discount.Name = "txtboxtotal_discount";
            txtboxtotal_discount.Size = new Size(249, 23);
            txtboxtotal_discount.TabIndex = 7;
            // 
            // txtboxtotal_quantity
            // 
            txtboxtotal_quantity.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtboxtotal_quantity.Location = new Point(157, 22);
            txtboxtotal_quantity.Margin = new Padding(4, 4, 4, 4);
            txtboxtotal_quantity.Name = "txtboxtotal_quantity";
            txtboxtotal_quantity.Size = new Size(249, 23);
            txtboxtotal_quantity.TabIndex = 6;
            // 
            // total_discounted
            // 
            total_discounted.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            total_discounted.AutoSize = true;
            total_discounted.Location = new Point(-6, 82);
            total_discounted.Name = "total_discounted";
            total_discounted.Size = new Size(142, 15);
            total_discounted.TabIndex = 4;
            total_discounted.Text = "Total Discounted Amount";
            // 
            // label33
            // 
            label33.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label33.AutoSize = true;
            label33.Location = new Point(6, 30);
            label33.Name = "label33";
            label33.Size = new Size(84, 15);
            label33.TabIndex = 0;
            label33.Text = "Total Quantity:";
            // 
            // label34
            // 
            label34.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label34.AutoSize = true;
            label34.Location = new Point(6, 60);
            label34.Name = "label34";
            label34.Size = new Size(118, 15);
            label34.TabIndex = 1;
            label34.Text = "Total Discount Given:";
            // 
            // label31
            // 
            label31.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label31.AutoSize = true;
            label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label31.Location = new Point(294, 410);
            label31.Name = "label31";
            label31.Size = new Size(65, 20);
            label31.TabIndex = 267;
            label31.Text = "Change";
            // 
            // changetxtbox
            // 
            changetxtbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            changetxtbox.Location = new Point(196, 37);
            changetxtbox.Margin = new Padding(4, 4, 4, 4);
            changetxtbox.Name = "changetxtbox";
            changetxtbox.Size = new Size(208, 23);
            changetxtbox.TabIndex = 268;
            changetxtbox.TextChanged += changetxtbox_TextChanged;
            // 
            // label30
            // 
            label30.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label30.AutoSize = true;
            label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label30.Location = new Point(63, 410);
            label30.Name = "label30";
            label30.Size = new Size(125, 20);
            label30.TabIndex = 223;
            label30.Text = "Cash Rendered:";
            // 
            // label29
            // 
            label29.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label29.AutoSize = true;
            label29.Font = new System.Drawing.Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label29.Location = new Point(50, 47);
            label29.Margin = new Padding(4, 0, 4, 0);
            label29.Name = "label29";
            label29.Size = new Size(261, 19);
            label29.TabIndex = 266;
            label29.Text = "4JEE FOODS INC. POINT OF SALE";
            // 
            // label28
            // 
            label28.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label28.AutoSize = true;
            label28.Location = new Point(346, 79);
            label28.Margin = new Padding(4, 0, 4, 0);
            label28.Name = "label28";
            label28.Size = new Size(74, 15);
            label28.TabIndex = 265;
            label28.Text = "Terminal #21";
            // 
            // label26
            // 
            label26.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label26.AutoSize = true;
            label26.Location = new Point(46, 79);
            label26.Margin = new Padding(4, 0, 4, 0);
            label26.Name = "label26";
            label26.Size = new Size(55, 15);
            label26.TabIndex = 222;
            label26.Text = "LABEL 12";
            // 
            // label27
            // 
            label27.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label27.AutoSize = true;
            label27.Location = new Point(164, 79);
            label27.Margin = new Padding(4, 0, 4, 0);
            label27.Name = "label27";
            label27.Size = new Size(93, 15);
            label27.TabIndex = 264;
            label27.Text = "By Karlo Legaspi";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(qty_txtbox);
            groupBox1.Controls.Add(no_discount);
            groupBox1.Controls.Add(an_employee);
            groupBox1.Controls.Add(with_disc);
            groupBox1.Controls.Add(senior_citizen);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtbox_discounted);
            groupBox1.Controls.Add(txtbox_discount);
            groupBox1.Controls.Add(txtbox_price);
            groupBox1.Controls.Add(txtbox_itemname);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(41, 97);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(420, 174);
            groupBox1.TabIndex = 261;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // qty_txtbox
            // 
            qty_txtbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            qty_txtbox.Location = new Point(122, 52);
            qty_txtbox.Margin = new Padding(4, 4, 4, 4);
            qty_txtbox.Name = "qty_txtbox";
            qty_txtbox.Size = new Size(67, 23);
            qty_txtbox.TabIndex = 18;
            // 
            // no_discount
            // 
            no_discount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            no_discount.AutoSize = true;
            no_discount.Location = new Point(190, 137);
            no_discount.Margin = new Padding(4, 4, 4, 4);
            no_discount.Name = "no_discount";
            no_discount.Size = new Size(90, 19);
            no_discount.TabIndex = 17;
            no_discount.TabStop = true;
            no_discount.Text = "No discount";
            no_discount.UseVisualStyleBackColor = true;
            no_discount.CheckedChanged += no_discount_CheckedChanged;
            // 
            // an_employee
            // 
            an_employee.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            an_employee.AutoSize = true;
            an_employee.Location = new Point(190, 109);
            an_employee.Margin = new Padding(4, 4, 4, 4);
            an_employee.Name = "an_employee";
            an_employee.Size = new Size(105, 19);
            an_employee.TabIndex = 16;
            an_employee.TabStop = true;
            an_employee.Text = "Employee Disc.";
            an_employee.UseVisualStyleBackColor = true;
            an_employee.CheckedChanged += an_employee_CheckedChanged;
            // 
            // with_disc
            // 
            with_disc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            with_disc.AutoSize = true;
            with_disc.Location = new Point(190, 83);
            with_disc.Margin = new Padding(4, 4, 4, 4);
            with_disc.Name = "with_disc";
            with_disc.Size = new Size(106, 19);
            with_disc.TabIndex = 15;
            with_disc.TabStop = true;
            with_disc.Text = "With Disc. Card";
            with_disc.UseVisualStyleBackColor = true;
            with_disc.CheckedChanged += with_disc_CheckedChanged;
            // 
            // senior_citizen
            // 
            senior_citizen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            senior_citizen.AutoSize = true;
            senior_citizen.Location = new Point(190, 53);
            senior_citizen.Margin = new Padding(4, 4, 4, 4);
            senior_citizen.Name = "senior_citizen";
            senior_citizen.Size = new Size(97, 19);
            senior_citizen.TabIndex = 14;
            senior_citizen.TabStop = true;
            senior_citizen.Text = "Senior Citizen";
            senior_citizen.UseVisualStyleBackColor = true;
            senior_citizen.CheckedChanged += senior_citizen_CheckedChanged;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button4.Location = new Point(309, 141);
            button4.Margin = new Padding(4, 4, 4, 4);
            button4.Name = "button4";
            button4.Size = new Size(102, 26);
            button4.TabIndex = 13;
            button4.Text = "BUY";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button3.Location = new Point(309, 107);
            button3.Margin = new Padding(4, 4, 4, 4);
            button3.Name = "button3";
            button3.Size = new Size(104, 26);
            button3.TabIndex = 12;
            button3.Text = "CANCEL";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button2.Location = new Point(309, 80);
            button2.Margin = new Padding(4, 4, 4, 4);
            button2.Name = "button2";
            button2.Size = new Size(102, 26);
            button2.TabIndex = 11;
            button2.Text = "NEW";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(309, 50);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(102, 26);
            button1.TabIndex = 0;
            button1.Text = "CALCULATE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtbox_discounted
            // 
            txtbox_discounted.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtbox_discounted.Location = new Point(122, 136);
            txtbox_discounted.Margin = new Padding(4, 4, 4, 4);
            txtbox_discounted.Name = "txtbox_discounted";
            txtbox_discounted.Size = new Size(67, 23);
            txtbox_discounted.TabIndex = 10;
            // 
            // txtbox_discount
            // 
            txtbox_discount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtbox_discount.Location = new Point(122, 105);
            txtbox_discount.Margin = new Padding(4, 4, 4, 4);
            txtbox_discount.Name = "txtbox_discount";
            txtbox_discount.Size = new Size(67, 23);
            txtbox_discount.TabIndex = 9;
            // 
            // txtbox_price
            // 
            txtbox_price.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtbox_price.Location = new Point(122, 77);
            txtbox_price.Margin = new Padding(4, 4, 4, 4);
            txtbox_price.Name = "txtbox_price";
            txtbox_price.Size = new Size(67, 23);
            txtbox_price.TabIndex = 8;
            // 
            // txtbox_itemname
            // 
            txtbox_itemname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtbox_itemname.Location = new Point(120, 22);
            txtbox_itemname.Margin = new Padding(4, 4, 4, 4);
            txtbox_itemname.Name = "txtbox_itemname";
            txtbox_itemname.Size = new Size(294, 23);
            txtbox_itemname.TabIndex = 6;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(10, 85);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 4;
            label6.Text = "Price:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(6, 27);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 0;
            label1.Text = "Name of an item:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(10, 57);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 1;
            label2.Text = "Quantity:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(9, 142);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 2;
            label4.Text = "Discounted Amt:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(9, 112);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 5;
            label5.Text = "Discount Amount:";
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label21.AutoSize = true;
            label21.Location = new Point(701, 617);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(52, 15);
            label21.TabIndex = 260;
            label21.Text = "Order 18";
            // 
            // label22
            // 
            label22.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label22.AutoSize = true;
            label22.Location = new Point(594, 617);
            label22.Margin = new Padding(4, 0, 4, 0);
            label22.Name = "label22";
            label22.Size = new Size(52, 15);
            label22.TabIndex = 259;
            label22.Text = "Order 17";
            // 
            // label23
            // 
            label23.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label23.AutoSize = true;
            label23.Location = new Point(480, 617);
            label23.Name = "label23";
            label23.Size = new Size(52, 15);
            label23.TabIndex = 258;
            label23.Text = "Order 16";
            // 
            // label24
            // 
            label24.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label24.AutoSize = true;
            label24.Location = new Point(927, 617);
            label24.Margin = new Padding(4, 0, 4, 0);
            label24.Name = "label24";
            label24.Size = new Size(52, 15);
            label24.TabIndex = 257;
            label24.Text = "Order 20";
            // 
            // label25
            // 
            label25.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label25.AutoSize = true;
            label25.Location = new Point(816, 617);
            label25.Name = "label25";
            label25.Size = new Size(52, 15);
            label25.TabIndex = 256;
            label25.Text = "Order 19";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.Location = new Point(701, 482);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(52, 15);
            label16.TabIndex = 255;
            label16.Text = "Order 13";
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label17.AutoSize = true;
            label17.Location = new Point(594, 482);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(52, 15);
            label17.TabIndex = 254;
            label17.Text = "Order 12";
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label18.AutoSize = true;
            label18.Location = new Point(480, 482);
            label18.Name = "label18";
            label18.Size = new Size(52, 15);
            label18.TabIndex = 253;
            label18.Text = "Order 11";
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label19.AutoSize = true;
            label19.Location = new Point(927, 482);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(52, 15);
            label19.TabIndex = 252;
            label19.Text = "Order 15";
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label20.AutoSize = true;
            label20.Location = new Point(816, 482);
            label20.Name = "label20";
            label20.Size = new Size(52, 15);
            label20.TabIndex = 251;
            label20.Text = "Order 14";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(701, 341);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 250;
            label7.Text = "Order 8";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Location = new Point(594, 341);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(46, 15);
            label12.TabIndex = 249;
            label12.Text = "Order 7";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Location = new Point(480, 341);
            label13.Name = "label13";
            label13.Size = new Size(46, 15);
            label13.TabIndex = 248;
            label13.Text = "Order 6";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Location = new Point(927, 341);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(52, 15);
            label14.TabIndex = 247;
            label14.Text = "Order 10";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Location = new Point(816, 341);
            label15.Name = "label15";
            label15.Size = new Size(46, 15);
            label15.TabIndex = 246;
            label15.Text = "Order 9";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(703, 190);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(46, 15);
            label9.TabIndex = 245;
            label9.Text = "Order 3";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(595, 190);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(46, 15);
            label10.TabIndex = 244;
            label10.Text = "Order 2";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Location = new Point(482, 190);
            label11.Name = "label11";
            label11.Size = new Size(46, 15);
            label11.TabIndex = 243;
            label11.Text = "Order 1";
            // 
            // name14lbl
            // 
            name14lbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            name14lbl.BorderStyle = BorderStyle.Fixed3D;
            name14lbl.Location = new Point(819, 360);
            name14lbl.Margin = new Padding(4, 4, 4, 4);
            name14lbl.Name = "name14lbl";
            name14lbl.Size = new Size(108, 101);
            name14lbl.SizeMode = PictureBoxSizeMode.Zoom;
            name14lbl.TabIndex = 237;
            name14lbl.TabStop = false;
            name14lbl.Click += name14lbl_Click;
            // 
            // name20lbl
            // 
            name20lbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            name20lbl.BorderStyle = BorderStyle.Fixed3D;
            name20lbl.Location = new Point(465, 458);
            name20lbl.Margin = new Padding(4, 4, 4, 4);
            name20lbl.Name = "name20lbl";
            name20lbl.Size = new Size(106, 101);
            name20lbl.SizeMode = PictureBoxSizeMode.Zoom;
            name20lbl.TabIndex = 224;
            name20lbl.TabStop = false;
            name20lbl.Click += name20lbl_Click;
            // 
            // name19lbl
            // 
            name19lbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            name19lbl.BorderStyle = BorderStyle.Fixed3D;
            name19lbl.Location = new Point(351, 458);
            name19lbl.Margin = new Padding(4, 4, 4, 4);
            name19lbl.Name = "name19lbl";
            name19lbl.Size = new Size(106, 101);
            name19lbl.SizeMode = PictureBoxSizeMode.Zoom;
            name19lbl.TabIndex = 223;
            name19lbl.TabStop = false;
            name19lbl.Click += name19lbl_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(928, 190);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(46, 15);
            label8.TabIndex = 241;
            label8.Text = "Order 5";
            // 
            // name9lbl
            // 
            name9lbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            name9lbl.BorderStyle = BorderStyle.Fixed3D;
            name9lbl.Location = new Point(822, 208);
            name9lbl.Margin = new Padding(4, 4, 4, 4);
            name9lbl.Name = "name9lbl";
            name9lbl.Size = new Size(108, 113);
            name9lbl.SizeMode = PictureBoxSizeMode.Zoom;
            name9lbl.TabIndex = 236;
            name9lbl.TabStop = false;
            name9lbl.Click += name9lbl_Click;
            // 
            // name3lbl
            // 
            name3lbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            name3lbl.BorderStyle = BorderStyle.Fixed3D;
            name3lbl.Location = new Point(704, 68);
            name3lbl.Margin = new Padding(4, 4, 4, 4);
            name3lbl.Name = "name3lbl";
            name3lbl.Size = new Size(106, 113);
            name3lbl.SizeMode = PictureBoxSizeMode.Zoom;
            name3lbl.TabIndex = 235;
            name3lbl.TabStop = false;
            name3lbl.Click += name3lbl_Click;
            // 
            // name13lbl
            // 
            name13lbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            name13lbl.BorderStyle = BorderStyle.Fixed3D;
            name13lbl.Location = new Point(704, 360);
            name13lbl.Margin = new Padding(4, 4, 4, 4);
            name13lbl.Name = "name13lbl";
            name13lbl.Size = new Size(108, 101);
            name13lbl.SizeMode = PictureBoxSizeMode.Zoom;
            name13lbl.TabIndex = 234;
            name13lbl.TabStop = false;
            name13lbl.Click += name13lbl_Click;
            // 
            // name7lbl
            // 
            name7lbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            name7lbl.BorderStyle = BorderStyle.Fixed3D;
            name7lbl.Location = new Point(598, 208);
            name7lbl.Margin = new Padding(4, 4, 4, 4);
            name7lbl.Name = "name7lbl";
            name7lbl.Size = new Size(106, 113);
            name7lbl.SizeMode = PictureBoxSizeMode.Zoom;
            name7lbl.TabIndex = 233;
            name7lbl.TabStop = false;
            name7lbl.Click += name7lbl_Click;
            // 
            // name1lbl
            // 
            name1lbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            name1lbl.BorderStyle = BorderStyle.Fixed3D;
            name1lbl.Location = new Point(479, 68);
            name1lbl.Margin = new Padding(4, 4, 4, 4);
            name1lbl.Name = "name1lbl";
            name1lbl.Size = new Size(112, 113);
            name1lbl.SizeMode = PictureBoxSizeMode.Zoom;
            name1lbl.TabIndex = 232;
            name1lbl.TabStop = false;
            name1lbl.Click += name1lbl_Click;
            // 
            // name18lbl
            // 
            name18lbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            name18lbl.BorderStyle = BorderStyle.Fixed3D;
            name18lbl.Location = new Point(239, 459);
            name18lbl.Margin = new Padding(4, 4, 4, 4);
            name18lbl.Name = "name18lbl";
            name18lbl.Size = new Size(106, 101);
            name18lbl.SizeMode = PictureBoxSizeMode.Zoom;
            name18lbl.TabIndex = 222;
            name18lbl.TabStop = false;
            name18lbl.Click += name18lbl_Click;
            // 
            // name16lbl
            // 
            name16lbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            name16lbl.BorderStyle = BorderStyle.Fixed3D;
            name16lbl.Location = new Point(480, 501);
            name16lbl.Margin = new Padding(4, 4, 4, 4);
            name16lbl.Name = "name16lbl";
            name16lbl.Size = new Size(106, 101);
            name16lbl.SizeMode = PictureBoxSizeMode.Zoom;
            name16lbl.TabIndex = 242;
            name16lbl.TabStop = false;
            name16lbl.Click += name16lbl_Click;
            // 
            // name15lbl
            // 
            name15lbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            name15lbl.BorderStyle = BorderStyle.Fixed3D;
            name15lbl.Location = new Point(931, 360);
            name15lbl.Margin = new Padding(4, 4, 4, 4);
            name15lbl.Name = "name15lbl";
            name15lbl.Size = new Size(106, 101);
            name15lbl.SizeMode = PictureBoxSizeMode.Zoom;
            name15lbl.TabIndex = 240;
            name15lbl.TabStop = false;
            name15lbl.Click += name15lbl_Click;
            // 
            // name10lbl
            // 
            name10lbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            name10lbl.BorderStyle = BorderStyle.Fixed3D;
            name10lbl.Location = new Point(932, 208);
            name10lbl.Margin = new Padding(4, 4, 4, 4);
            name10lbl.Name = "name10lbl";
            name10lbl.Size = new Size(106, 113);
            name10lbl.SizeMode = PictureBoxSizeMode.Zoom;
            name10lbl.TabIndex = 239;
            name10lbl.TabStop = false;
            name10lbl.Click += name10lbl_Click;
            // 
            // name4lbl
            // 
            name4lbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            name4lbl.BorderStyle = BorderStyle.Fixed3D;
            name4lbl.Location = new Point(819, 68);
            name4lbl.Margin = new Padding(4, 4, 4, 4);
            name4lbl.Name = "name4lbl";
            name4lbl.Size = new Size(109, 113);
            name4lbl.SizeMode = PictureBoxSizeMode.Zoom;
            name4lbl.TabIndex = 238;
            name4lbl.TabStop = false;
            name4lbl.Click += name4lbl_Click;
            // 
            // name12lbl
            // 
            name12lbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            name12lbl.BorderStyle = BorderStyle.Fixed3D;
            name12lbl.Location = new Point(596, 360);
            name12lbl.Margin = new Padding(4, 4, 4, 4);
            name12lbl.Name = "name12lbl";
            name12lbl.Size = new Size(106, 101);
            name12lbl.SizeMode = PictureBoxSizeMode.Zoom;
            name12lbl.TabIndex = 231;
            name12lbl.TabStop = false;
            name12lbl.Click += name12lbl_Click;
            // 
            // name8lbl
            // 
            name8lbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            name8lbl.BorderStyle = BorderStyle.Fixed3D;
            name8lbl.Location = new Point(706, 208);
            name8lbl.Margin = new Padding(4, 4, 4, 4);
            name8lbl.Name = "name8lbl";
            name8lbl.Size = new Size(108, 113);
            name8lbl.SizeMode = PictureBoxSizeMode.Zoom;
            name8lbl.TabIndex = 230;
            name8lbl.TabStop = false;
            name8lbl.Click += name8lbl_Click;
            // 
            // name11lbl
            // 
            name11lbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            name11lbl.BorderStyle = BorderStyle.Fixed3D;
            name11lbl.Location = new Point(479, 360);
            name11lbl.Margin = new Padding(4, 4, 4, 4);
            name11lbl.Name = "name11lbl";
            name11lbl.Size = new Size(106, 101);
            name11lbl.SizeMode = PictureBoxSizeMode.Zoom;
            name11lbl.TabIndex = 228;
            name11lbl.TabStop = false;
            name11lbl.Click += name11lbl_Click;
            // 
            // name6lbl
            // 
            name6lbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            name6lbl.BorderStyle = BorderStyle.Fixed3D;
            name6lbl.Location = new Point(480, 208);
            name6lbl.Margin = new Padding(4, 4, 4, 4);
            name6lbl.Name = "name6lbl";
            name6lbl.Size = new Size(106, 113);
            name6lbl.SizeMode = PictureBoxSizeMode.Zoom;
            name6lbl.TabIndex = 227;
            name6lbl.TabStop = false;
            name6lbl.Click += name6lbl_Click;
            // 
            // name17lbl
            // 
            name17lbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            name17lbl.BorderStyle = BorderStyle.Fixed3D;
            name17lbl.Location = new Point(130, 459);
            name17lbl.Margin = new Padding(4, 4, 4, 4);
            name17lbl.Name = "name17lbl";
            name17lbl.Size = new Size(106, 101);
            name17lbl.SizeMode = PictureBoxSizeMode.Zoom;
            name17lbl.TabIndex = 221;
            name17lbl.TabStop = false;
            name17lbl.Click += name17lbl_Click;
            // 
            // name5lbl
            // 
            name5lbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            name5lbl.BorderStyle = BorderStyle.Fixed3D;
            name5lbl.Location = new Point(931, 68);
            name5lbl.Margin = new Padding(4, 4, 4, 4);
            name5lbl.Name = "name5lbl";
            name5lbl.Size = new Size(106, 113);
            name5lbl.SizeMode = PictureBoxSizeMode.Zoom;
            name5lbl.TabIndex = 229;
            name5lbl.TabStop = false;
            name5lbl.Click += name5lbl_Click;
            // 
            // name2lbl
            // 
            name2lbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            name2lbl.BorderStyle = BorderStyle.Fixed3D;
            name2lbl.Location = new Point(598, 68);
            name2lbl.Margin = new Padding(4, 4, 4, 4);
            name2lbl.Name = "name2lbl";
            name2lbl.Size = new Size(106, 113);
            name2lbl.SizeMode = PictureBoxSizeMode.Zoom;
            name2lbl.TabIndex = 226;
            name2lbl.TabStop = false;
            name2lbl.Click += name2lbl_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(label32);
            groupBox2.Controls.Add(name20lbl);
            groupBox2.Controls.Add(name19lbl);
            groupBox2.Controls.Add(name18lbl);
            groupBox2.Controls.Add(name17lbl);
            groupBox2.Location = new Point(468, 41);
            groupBox2.Margin = new Padding(4, 4, 4, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 4, 4, 4);
            groupBox2.Size = new Size(584, 602);
            groupBox2.TabIndex = 263;
            groupBox2.TabStop = false;
            groupBox2.Text = "Items Display";
            // 
            // label32
            // 
            label32.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label32.AutoSize = true;
            label32.Location = new Point(356, 148);
            label32.Margin = new Padding(4, 0, 4, 0);
            label32.Name = "label32";
            label32.Size = new Size(46, 15);
            label32.TabIndex = 284;
            label32.Text = "Order 4";
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.Controls.Add(txtboxcash_rendered);
            groupBox4.Controls.Add(changetxtbox);
            groupBox4.Location = new Point(46, 399);
            groupBox4.Margin = new Padding(4, 4, 4, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 4, 4, 4);
            groupBox4.Size = new Size(413, 94);
            groupBox4.TabIndex = 269;
            groupBox4.TabStop = false;
            // 
            // txtboxcash_rendered
            // 
            txtboxcash_rendered.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtboxcash_rendered.Location = new Point(6, 37);
            txtboxcash_rendered.Margin = new Padding(4, 4, 4, 4);
            txtboxcash_rendered.Name = "txtboxcash_rendered";
            txtboxcash_rendered.Size = new Size(183, 23);
            txtboxcash_rendered.TabIndex = 14;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(818, 190);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 221;
            label3.Text = "Order 4";
            // 
            // Lesson3_Example2_Methods
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 669);
            Controls.Add(button19);
            Controls.Add(button20);
            Controls.Add(button18);
            Controls.Add(button14);
            Controls.Add(button15);
            Controls.Add(button16);
            Controls.Add(button17);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button13);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(enter_button);
            Controls.Add(groupBox3);
            Controls.Add(label31);
            Controls.Add(label30);
            Controls.Add(label29);
            Controls.Add(label28);
            Controls.Add(label26);
            Controls.Add(label27);
            Controls.Add(groupBox1);
            Controls.Add(label21);
            Controls.Add(label22);
            Controls.Add(label23);
            Controls.Add(label24);
            Controls.Add(label25);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(label19);
            Controls.Add(label20);
            Controls.Add(label7);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(name14lbl);
            Controls.Add(label8);
            Controls.Add(name9lbl);
            Controls.Add(name3lbl);
            Controls.Add(name13lbl);
            Controls.Add(name7lbl);
            Controls.Add(name1lbl);
            Controls.Add(name16lbl);
            Controls.Add(name15lbl);
            Controls.Add(name10lbl);
            Controls.Add(name4lbl);
            Controls.Add(name12lbl);
            Controls.Add(name8lbl);
            Controls.Add(name11lbl);
            Controls.Add(name6lbl);
            Controls.Add(name5lbl);
            Controls.Add(name2lbl);
            Controls.Add(groupBox2);
            Controls.Add(groupBox4);
            Controls.Add(label3);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Lesson3_Example2_Methods";
            Text = "Form1";
            Load += Lesson3_Example2_Methods_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)name14lbl).EndInit();
            ((System.ComponentModel.ISupportInitialize)name20lbl).EndInit();
            ((System.ComponentModel.ISupportInitialize)name19lbl).EndInit();
            ((System.ComponentModel.ISupportInitialize)name9lbl).EndInit();
            ((System.ComponentModel.ISupportInitialize)name3lbl).EndInit();
            ((System.ComponentModel.ISupportInitialize)name13lbl).EndInit();
            ((System.ComponentModel.ISupportInitialize)name7lbl).EndInit();
            ((System.ComponentModel.ISupportInitialize)name1lbl).EndInit();
            ((System.ComponentModel.ISupportInitialize)name18lbl).EndInit();
            ((System.ComponentModel.ISupportInitialize)name16lbl).EndInit();
            ((System.ComponentModel.ISupportInitialize)name15lbl).EndInit();
            ((System.ComponentModel.ISupportInitialize)name10lbl).EndInit();
            ((System.ComponentModel.ISupportInitialize)name4lbl).EndInit();
            ((System.ComponentModel.ISupportInitialize)name12lbl).EndInit();
            ((System.ComponentModel.ISupportInitialize)name8lbl).EndInit();
            ((System.ComponentModel.ISupportInitialize)name11lbl).EndInit();
            ((System.ComponentModel.ISupportInitialize)name6lbl).EndInit();
            ((System.ComponentModel.ISupportInitialize)name17lbl).EndInit();
            ((System.ComponentModel.ISupportInitialize)name5lbl).EndInit();
            ((System.ComponentModel.ISupportInitialize)name2lbl).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button enter_button;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtbox_total_discounted;
        private System.Windows.Forms.TextBox txtboxtotal_discount;
        private System.Windows.Forms.TextBox txtboxtotal_quantity;
        private System.Windows.Forms.Label total_discounted;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox changetxtbox;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton no_discount;
        private System.Windows.Forms.RadioButton an_employee;
        private System.Windows.Forms.RadioButton with_disc;
        private System.Windows.Forms.RadioButton senior_citizen;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtbox_discounted;
        private System.Windows.Forms.TextBox txtbox_discount;
        private System.Windows.Forms.TextBox txtbox_price;
        private System.Windows.Forms.TextBox txtbox_itemname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox name14lbl;
        private System.Windows.Forms.PictureBox name20lbl;
        private System.Windows.Forms.PictureBox name19lbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox name9lbl;
        private System.Windows.Forms.PictureBox name3lbl;
        private System.Windows.Forms.PictureBox name13lbl;
        private System.Windows.Forms.PictureBox name7lbl;
        private System.Windows.Forms.PictureBox name1lbl;
        private System.Windows.Forms.PictureBox name18lbl;
        private System.Windows.Forms.PictureBox name16lbl;
        private System.Windows.Forms.PictureBox name15lbl;
        private System.Windows.Forms.PictureBox name10lbl;
        private System.Windows.Forms.PictureBox name4lbl;
        private System.Windows.Forms.PictureBox name12lbl;
        private System.Windows.Forms.PictureBox name8lbl;
        private System.Windows.Forms.PictureBox name11lbl;
        private System.Windows.Forms.PictureBox name6lbl;
        private System.Windows.Forms.PictureBox name17lbl;
        private System.Windows.Forms.PictureBox name5lbl;
        private System.Windows.Forms.PictureBox name2lbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtboxcash_rendered;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox qty_txtbox;
    }
}