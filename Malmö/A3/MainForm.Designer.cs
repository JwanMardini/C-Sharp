namespace BMICalculator
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnimperial);
            this.groupBox1.Controls.Add(this.rbtnmetric);
            this.groupBox1.Location = new System.Drawing.Point(502, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 159);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unit";
            // 
            // rbtnimperial
            // 
            this.rbtnimperial.AutoSize = true;
            this.rbtnimperial.Checked = true;
            this.rbtnimperial.Location = new System.Drawing.Point(7, 84);
            this.rbtnimperial.Name = "rbtnimperial";
            this.rbtnimperial.Size = new System.Drawing.Size(108, 17);
            this.rbtnimperial.TabIndex = 1;
            this.rbtnimperial.TabStop = true;
            this.rbtnimperial.Text = "US Unit (foot, lbs)";
            this.rbtnimperial.UseVisualStyleBackColor = true;
            this.rbtnimperial.CheckedChanged += new System.EventHandler(this.rbtnimperial_CheckedChanged);
            // 
            // rbtnmetric
            // 
            this.rbtnmetric.AutoSize = true;
            this.rbtnmetric.Location = new System.Drawing.Point(7, 49);
            this.rbtnmetric.Name = "rbtnmetric";
            this.rbtnmetric.Size = new System.Drawing.Size(114, 17);
            this.rbtnmetric.TabIndex = 0;
            this.rbtnmetric.Text = "Metric Unit (kg cm)";
            this.rbtnmetric.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calculate";
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
            this.groupBox2.Location = new System.Drawing.Point(15, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 207);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results for Apu";
            // 
            // norText
            // 
            this.norText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.norText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.norText.Location = new System.Drawing.Point(214, 119);
            this.norText.Name = "norText";
            this.norText.Size = new System.Drawing.Size(234, 23);
            this.norText.TabIndex = 11;
            this.norText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(230, 128);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(192, 23);
            this.txtMessage.TabIndex = 10;
            this.txtMessage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // weightCat
            // 
            this.weightCat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.weightCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightCat.Location = new System.Drawing.Point(214, 69);
            this.weightCat.Name = "weightCat";
            this.weightCat.Size = new System.Drawing.Size(234, 23);
            this.weightCat.TabIndex = 9;
            this.weightCat.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtBMI
            // 
            this.txtBMI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBMI.Location = new System.Drawing.Point(337, 32);
            this.txtBMI.Name = "txtBMI";
            this.txtBMI.Size = new System.Drawing.Size(111, 23);
            this.txtBMI.TabIndex = 8;
            this.txtBMI.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Weight Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
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
            this.groupBox3.Location = new System.Drawing.Point(15, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(454, 178);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "BMI Calculator";
            // 
            // inlbl
            // 
            this.inlbl.AutoSize = true;
            this.inlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inlbl.Location = new System.Drawing.Point(272, 57);
            this.inlbl.Name = "inlbl";
            this.inlbl.Size = new System.Drawing.Size(17, 16);
            this.inlbl.TabIndex = 20;
            this.inlbl.Text = "in";
            // 
            // ftlbl
            // 
            this.ftlbl.AutoSize = true;
            this.ftlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ftlbl.Location = new System.Drawing.Point(190, 57);
            this.ftlbl.Name = "ftlbl";
            this.ftlbl.Size = new System.Drawing.Size(13, 16);
            this.ftlbl.TabIndex = 19;
            this.ftlbl.Text = "ft";
            // 
            // txtheight2
            // 
            this.txtheight2.Location = new System.Drawing.Point(209, 53);
            this.txtheight2.Name = "txtheight2";
            this.txtheight2.Size = new System.Drawing.Size(56, 20);
            this.txtheight2.TabIndex = 18;
            // 
            // txtweight
            // 
            this.txtweight.Location = new System.Drawing.Point(128, 99);
            this.txtweight.Name = "txtweight";
            this.txtweight.Size = new System.Drawing.Size(56, 20);
            this.txtweight.TabIndex = 17;
            // 
            // txtheight
            // 
            this.txtheight.Location = new System.Drawing.Point(128, 53);
            this.txtheight.Name = "txtheight";
            this.txtheight.Size = new System.Drawing.Size(56, 20);
            this.txtheight.TabIndex = 16;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(128, 19);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(237, 20);
            this.txtname.TabIndex = 15;
            // 
            // lblweight
            // 
            this.lblweight.AutoSize = true;
            this.lblweight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblweight.Location = new System.Drawing.Point(16, 103);
            this.lblweight.Name = "lblweight";
            this.lblweight.Size = new System.Drawing.Size(78, 16);
            this.lblweight.TabIndex = 14;
            this.lblweight.Text = "Weight (lbs)";
            this.lblweight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblheight
            // 
            this.lblheight.AutoSize = true;
            this.lblheight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheight.Location = new System.Drawing.Point(16, 57);
            this.lblheight.Name = "lblheight";
            this.lblheight.Size = new System.Drawing.Size(79, 16);
            this.lblheight.TabIndex = 13;
            this.lblheight.Text = "Height (feet)";
            this.lblheight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
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
            this.groupBox4.Location = new System.Drawing.Point(659, 31);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(345, 221);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Saving plan";
            // 
            // Months
            // 
            this.Months.Location = new System.Drawing.Point(239, 68);
            this.Months.Name = "Months";
            this.Months.Size = new System.Drawing.Size(100, 20);
            this.Months.TabIndex = 9;
            // 
            // period
            // 
            this.period.Location = new System.Drawing.Point(239, 98);
            this.period.Name = "period";
            this.period.Size = new System.Drawing.Size(100, 20);
            this.period.TabIndex = 8;
            // 
            // fees
            // 
            this.fees.Location = new System.Drawing.Point(239, 164);
            this.fees.Name = "fees";
            this.fees.Size = new System.Drawing.Size(100, 20);
            this.fees.TabIndex = 7;
            // 
            // growth
            // 
            this.growth.Location = new System.Drawing.Point(239, 129);
            this.growth.Name = "growth";
            this.growth.Size = new System.Drawing.Size(100, 20);
            this.growth.TabIndex = 6;
            // 
            // initDep
            // 
            this.initDep.Location = new System.Drawing.Point(240, 34);
            this.initDep.Name = "initDep";
            this.initDep.Size = new System.Drawing.Size(100, 20);
            this.initDep.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "Fees in %";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 22);
            this.label7.TabIndex = 3;
            this.label7.Text = "Growth (or intrest) in %";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Period (years)";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Monthly deposit";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Initial deposit";
            // 
            // calculate_saving
            // 
            this.calculate_saving.Location = new System.Drawing.Point(724, 257);
            this.calculate_saving.Name = "calculate_saving";
            this.calculate_saving.Size = new System.Drawing.Size(200, 31);
            this.calculate_saving.TabIndex = 11;
            this.calculate_saving.Text = "Calculate";
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
            this.groupBox5.Location = new System.Drawing.Point(659, 311);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(344, 129);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Future Value";
            // 
            // totalfees
            // 
            this.totalfees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalfees.Location = new System.Drawing.Point(240, 100);
            this.totalfees.Name = "totalfees";
            this.totalfees.Size = new System.Drawing.Size(101, 21);
            this.totalfees.TabIndex = 9;
            // 
            // finalbalance
            // 
            this.finalbalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.finalbalance.Location = new System.Drawing.Point(239, 72);
            this.finalbalance.Name = "finalbalance";
            this.finalbalance.Size = new System.Drawing.Size(101, 21);
            this.finalbalance.TabIndex = 8;
            // 
            // amountearned
            // 
            this.amountearned.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.amountearned.Location = new System.Drawing.Point(239, 43);
            this.amountearned.Name = "amountearned";
            this.amountearned.Size = new System.Drawing.Size(101, 21);
            this.amountearned.TabIndex = 5;
            // 
            // amountpaid
            // 
            this.amountpaid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.amountpaid.Location = new System.Drawing.Point(239, 19);
            this.amountpaid.Name = "amountpaid";
            this.amountpaid.Size = new System.Drawing.Size(100, 23);
            this.amountpaid.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Total fees";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Final balance";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Amount earned";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Amount paid";
            // 
            // groupBox6
            // 
            this.groupBox6.Location = new System.Drawing.Point(15, 454);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(988, 280);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "BMR Calculator";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 760);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.calculate_saving);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator by Jwan Mardini";
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
    }
}

