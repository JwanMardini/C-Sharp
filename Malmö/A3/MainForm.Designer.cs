namespace A3
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnimperial = new System.Windows.Forms.RadioButton();
            this.rbtnmetric = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.norText = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.Label();
            this.weightCat = new System.Windows.Forms.Label();
            this.txtBMI = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.inlbl = new System.Windows.Forms.Label();
            this.ftlbl = new System.Windows.Forms.Label();
            this.txtheight2 = new System.Windows.Forms.TextBox();
            this.txtweight = new System.Windows.Forms.TextBox();
            this.txtheight = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblweight = new System.Windows.Forms.Label();
            this.lblheight = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Months = new System.Windows.Forms.TextBox();
            this.period = new System.Windows.Forms.TextBox();
            this.fees = new System.Windows.Forms.TextBox();
            this.growth = new System.Windows.Forms.TextBox();
            this.initDep = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.calculate_saving = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.totalfees = new System.Windows.Forms.Label();
            this.finalbalance = new System.Windows.Forms.Label();
            this.amountearned = new System.Windows.Forms.Label();
            this.amountpaid = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.agelbl = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.malerbtn = new System.Windows.Forms.RadioButton();
            this.femalerbtn = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnimperial);
            this.groupBox1.Controls.Add(this.rbtnmetric);
            this.groupBox1.Location = new System.Drawing.Point(723, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(208, 245);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unit";
            // 
            // rbtnimperial
            // 
            this.rbtnimperial.AutoSize = true;
            this.rbtnimperial.Checked = true;
            this.rbtnimperial.Location = new System.Drawing.Point(10, 129);
            this.rbtnimperial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnimperial.Name = "rbtnimperial";
            this.rbtnimperial.Size = new System.Drawing.Size(160, 24);
            this.rbtnimperial.TabIndex = 1;
            this.rbtnimperial.TabStop = true;
            this.rbtnimperial.Text = "US Unit (foot, lbs)";
            this.rbtnimperial.UseVisualStyleBackColor = true;
            this.rbtnimperial.CheckedChanged += new System.EventHandler(this.rbtnimperial_CheckedChanged);
            // 
            // rbtnmetric
            // 
            this.rbtnmetric.AutoSize = true;
            this.rbtnmetric.Location = new System.Drawing.Point(10, 75);
            this.rbtnmetric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnmetric.Name = "rbtnmetric";
            this.rbtnmetric.Size = new System.Drawing.Size(166, 24);
            this.rbtnmetric.TabIndex = 0;
            this.rbtnmetric.Text = "Metric Unit (kg cm)";
            this.rbtnmetric.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 302);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 48);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calculate BMI";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.norText);
            this.groupBox2.Controls.Add(this.txtMessage);
            this.groupBox2.Controls.Add(this.weightCat);
            this.groupBox2.Controls.Add(this.txtBMI);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(22, 358);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(681, 254);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results for Apu";
            // 
            // norText
            // 
            this.norText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.norText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.norText.Location = new System.Drawing.Point(321, 183);
            this.norText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.norText.Name = "norText";
            this.norText.Size = new System.Drawing.Size(351, 35);
            this.norText.TabIndex = 11;
            this.norText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(345, 197);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(288, 35);
            this.txtMessage.TabIndex = 10;
            this.txtMessage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // weightCat
            // 
            this.weightCat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.weightCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightCat.Location = new System.Drawing.Point(321, 106);
            this.weightCat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.weightCat.Name = "weightCat";
            this.weightCat.Size = new System.Drawing.Size(351, 35);
            this.weightCat.TabIndex = 9;
            this.weightCat.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtBMI
            // 
            this.txtBMI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBMI.Location = new System.Drawing.Point(506, 49);
            this.txtBMI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtBMI.Name = "txtBMI";
            this.txtBMI.Size = new System.Drawing.Size(166, 35);
            this.txtBMI.TabIndex = 8;
            this.txtBMI.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Weight Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Your BMI";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.inlbl);
            this.groupBox3.Controls.Add(this.ftlbl);
            this.groupBox3.Controls.Add(this.txtheight2);
            this.groupBox3.Controls.Add(this.txtweight);
            this.groupBox3.Controls.Add(this.txtheight);
            this.groupBox3.Controls.Add(this.txtname);
            this.groupBox3.Controls.Add(this.lblweight);
            this.groupBox3.Controls.Add(this.lblheight);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(22, 18);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(681, 274);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "BMI Calculator";
            // 
            // inlbl
            // 
            this.inlbl.AutoSize = true;
            this.inlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inlbl.Location = new System.Drawing.Point(408, 88);
            this.inlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inlbl.Name = "inlbl";
            this.inlbl.Size = new System.Drawing.Size(27, 25);
            this.inlbl.TabIndex = 20;
            this.inlbl.Text = "in";
            // 
            // ftlbl
            // 
            this.ftlbl.AutoSize = true;
            this.ftlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ftlbl.Location = new System.Drawing.Point(285, 88);
            this.ftlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ftlbl.Name = "ftlbl";
            this.ftlbl.Size = new System.Drawing.Size(22, 25);
            this.ftlbl.TabIndex = 19;
            this.ftlbl.Text = "ft";
            // 
            // txtheight2
            // 
            this.txtheight2.Location = new System.Drawing.Point(314, 82);
            this.txtheight2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtheight2.Name = "txtheight2";
            this.txtheight2.Size = new System.Drawing.Size(82, 26);
            this.txtheight2.TabIndex = 18;
            // 
            // txtweight
            // 
            this.txtweight.Location = new System.Drawing.Point(192, 152);
            this.txtweight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtweight.Name = "txtweight";
            this.txtweight.Size = new System.Drawing.Size(82, 26);
            this.txtweight.TabIndex = 17;
            // 
            // txtheight
            // 
            this.txtheight.Location = new System.Drawing.Point(192, 82);
            this.txtheight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtheight.Name = "txtheight";
            this.txtheight.Size = new System.Drawing.Size(82, 26);
            this.txtheight.TabIndex = 16;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(192, 29);
            this.txtname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(354, 26);
            this.txtname.TabIndex = 15;
            // 
            // lblweight
            // 
            this.lblweight.AutoSize = true;
            this.lblweight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblweight.Location = new System.Drawing.Point(24, 158);
            this.lblweight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblweight.Name = "lblweight";
            this.lblweight.Size = new System.Drawing.Size(118, 25);
            this.lblweight.TabIndex = 14;
            this.lblweight.Text = "Weight (lbs)";
            this.lblweight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblheight
            // 
            this.lblheight.AutoSize = true;
            this.lblheight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheight.Location = new System.Drawing.Point(24, 88);
            this.lblheight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblheight.Name = "lblheight";
            this.lblheight.Size = new System.Drawing.Size(119, 25);
            this.lblheight.TabIndex = 13;
            this.lblheight.Text = "Height (feet)";
            this.lblheight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Your Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Months);
            this.groupBox4.Controls.Add(this.period);
            this.groupBox4.Controls.Add(this.fees);
            this.groupBox4.Controls.Add(this.growth);
            this.groupBox4.Controls.Add(this.initDep);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(988, 18);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(518, 340);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Saving plan";
            // 
            // Months
            // 
            this.Months.Location = new System.Drawing.Point(358, 105);
            this.Months.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Months.Name = "Months";
            this.Months.Size = new System.Drawing.Size(148, 26);
            this.Months.TabIndex = 9;
            // 
            // period
            // 
            this.period.Location = new System.Drawing.Point(358, 151);
            this.period.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.period.Name = "period";
            this.period.Size = new System.Drawing.Size(148, 26);
            this.period.TabIndex = 8;
            // 
            // fees
            // 
            this.fees.Location = new System.Drawing.Point(358, 252);
            this.fees.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fees.Name = "fees";
            this.fees.Size = new System.Drawing.Size(148, 26);
            this.fees.TabIndex = 7;
            // 
            // growth
            // 
            this.growth.Location = new System.Drawing.Point(358, 198);
            this.growth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.growth.Name = "growth";
            this.growth.Size = new System.Drawing.Size(148, 26);
            this.growth.TabIndex = 6;
            // 
            // initDep
            // 
            this.initDep.Location = new System.Drawing.Point(360, 52);
            this.initDep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.initDep.Name = "initDep";
            this.initDep.Size = new System.Drawing.Size(148, 26);
            this.initDep.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 254);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(236, 35);
            this.label8.TabIndex = 4;
            this.label8.Text = "Fees in %";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 195);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(236, 34);
            this.label7.TabIndex = 3;
            this.label7.Text = "Growth (or intrest) in %";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 152);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 37);
            this.label6.TabIndex = 2;
            this.label6.Text = "Period (years)";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 46);
            this.label3.TabIndex = 1;
            this.label3.Text = "Monthly deposit";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Initial deposit";
            // 
            // calculate_saving
            // 
            this.calculate_saving.Location = new System.Drawing.Point(1087, 368);
            this.calculate_saving.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calculate_saving.Name = "calculate_saving";
            this.calculate_saving.Size = new System.Drawing.Size(300, 48);
            this.calculate_saving.TabIndex = 11;
            this.calculate_saving.Text = "Calculate Saving";
            this.calculate_saving.UseVisualStyleBackColor = true;
            this.calculate_saving.Click += new System.EventHandler(this.calculate_saving_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.totalfees);
            this.groupBox5.Controls.Add(this.finalbalance);
            this.groupBox5.Controls.Add(this.amountearned);
            this.groupBox5.Controls.Add(this.amountpaid);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(988, 441);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(516, 198);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Future Value";
            // 
            // totalfees
            // 
            this.totalfees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalfees.Location = new System.Drawing.Point(360, 154);
            this.totalfees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalfees.Name = "totalfees";
            this.totalfees.Size = new System.Drawing.Size(152, 32);
            this.totalfees.TabIndex = 9;
            // 
            // finalbalance
            // 
            this.finalbalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.finalbalance.Location = new System.Drawing.Point(358, 111);
            this.finalbalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.finalbalance.Name = "finalbalance";
            this.finalbalance.Size = new System.Drawing.Size(152, 32);
            this.finalbalance.TabIndex = 8;
            // 
            // amountearned
            // 
            this.amountearned.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.amountearned.Location = new System.Drawing.Point(358, 66);
            this.amountearned.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.amountearned.Name = "amountearned";
            this.amountearned.Size = new System.Drawing.Size(152, 32);
            this.amountearned.TabIndex = 5;
            // 
            // amountpaid
            // 
            this.amountpaid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.amountpaid.Location = new System.Drawing.Point(358, 29);
            this.amountpaid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.amountpaid.Name = "amountpaid";
            this.amountpaid.Size = new System.Drawing.Size(150, 35);
            this.amountpaid.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(42, 155);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "Total fees";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(42, 112);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Final balance";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 66);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Amount earned";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 31);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Amount paid";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button2);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.groupBox8);
            this.groupBox6.Controls.Add(this.textBox1);
            this.groupBox6.Controls.Add(this.agelbl);
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Location = new System.Drawing.Point(22, 649);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox6.Size = new System.Drawing.Size(1482, 360);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "BMR Calculator";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(154, 285);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(300, 48);
            this.button2.TabIndex = 14;
            this.button2.Text = "Calculate BMR\r\n";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(727, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(745, 218);
            this.label13.TabIndex = 4;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.radioButton5);
            this.groupBox8.Controls.Add(this.radioButton4);
            this.groupBox8.Controls.Add(this.radioButton3);
            this.groupBox8.Controls.Add(this.radioButton2);
            this.groupBox8.Controls.Add(this.radioButton1);
            this.groupBox8.Location = new System.Drawing.Point(282, 27);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(399, 250);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Weekly activity level";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(32, 204);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(269, 24);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Extra active, hard exercises or job";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(32, 165);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(195, 24);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Very active(6 to 7 time)";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(31, 126);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(245, 24);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Moderately active (3 to 5 time)";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(32, 86);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(178, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Lightly active (1 to 3)";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(32, 50);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(251, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Sedentary (little or no exercise)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(154, 212);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 2;
            // 
            // agelbl
            // 
            this.agelbl.Location = new System.Drawing.Point(30, 215);
            this.agelbl.Name = "agelbl";
            this.agelbl.Size = new System.Drawing.Size(100, 23);
            this.agelbl.TabIndex = 1;
            this.agelbl.Text = "Age";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.malerbtn);
            this.groupBox7.Controls.Add(this.femalerbtn);
            this.groupBox7.Location = new System.Drawing.Point(29, 27);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(225, 151);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Gender";
            // 
            // malerbtn
            // 
            this.malerbtn.AutoSize = true;
            this.malerbtn.Location = new System.Drawing.Point(14, 100);
            this.malerbtn.Name = "malerbtn";
            this.malerbtn.Size = new System.Drawing.Size(68, 24);
            this.malerbtn.TabIndex = 1;
            this.malerbtn.TabStop = true;
            this.malerbtn.Text = "Male";
            this.malerbtn.UseVisualStyleBackColor = true;
            // 
            // femalerbtn
            // 
            this.femalerbtn.AutoSize = true;
            this.femalerbtn.Location = new System.Drawing.Point(14, 48);
            this.femalerbtn.Name = "femalerbtn";
            this.femalerbtn.Size = new System.Drawing.Size(87, 24);
            this.femalerbtn.TabIndex = 0;
            this.femalerbtn.TabStop = true;
            this.femalerbtn.Text = "Female";
            this.femalerbtn.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1524, 1050);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.calculate_saving);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator by Jwan Mardini";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnimperial;
        private System.Windows.Forms.RadioButton rbtnmetric;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label weightCat;
        private System.Windows.Forms.Label txtBMI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtMessage;
        private System.Windows.Forms.Label norText;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label inlbl;
        private System.Windows.Forms.Label ftlbl;
        private System.Windows.Forms.TextBox txtheight2;
        private System.Windows.Forms.TextBox txtweight;
        private System.Windows.Forms.TextBox txtheight;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblweight;
        private System.Windows.Forms.Label lblheight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Months;
        private System.Windows.Forms.TextBox period;
        private System.Windows.Forms.TextBox fees;
        private System.Windows.Forms.TextBox growth;
        private System.Windows.Forms.TextBox initDep;
        private System.Windows.Forms.Button calculate_saving;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label amountearned;
        private System.Windows.Forms.Label amountpaid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label totalfees;
        private System.Windows.Forms.Label finalbalance;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton femalerbtn;
        private System.Windows.Forms.RadioButton malerbtn;
        private System.Windows.Forms.Label agelbl;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label13;
    }
}

