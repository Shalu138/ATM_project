namespace CS_ATM
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBalance = new System.Windows.Forms.Button();
            this.btnWithdrawl = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnLoan = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.lblLoan = new System.Windows.Forms.Label();
            this.lblPin = new System.Windows.Forms.Label();
            this.lblWithdrawl = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMonthlyPayment = new System.Windows.Forms.Label();
            this.btnExitSystem = new System.Windows.Forms.Button();
            this.btnResetSystem = new System.Windows.Forms.Button();
            this.btnReceiptSystem = new System.Windows.Forms.Button();
            this.btnLoanSystem = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Total_Payment = new System.Windows.Forms.Label();
            this.Monthly_Payment = new System.Windows.Forms.Label();
            this.Interest_Rate = new System.Windows.Forms.Label();
            this.No_OfYear = new System.Windows.Forms.Label();
            this.AmtOfLoan = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBalance);
            this.groupBox1.Controls.Add(this.btnWithdrawl);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnBalance
            // 
            this.btnBalance.Image = ((System.Drawing.Image)(resources.GetObject("btnBalance.Image")));
            this.btnBalance.Location = new System.Drawing.Point(22, 23);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(93, 39);
            this.btnBalance.TabIndex = 0;
            this.btnBalance.UseVisualStyleBackColor = true;
            // 
            // btnWithdrawl
            // 
            this.btnWithdrawl.Image = ((System.Drawing.Image)(resources.GetObject("btnWithdrawl.Image")));
            this.btnWithdrawl.Location = new System.Drawing.Point(22, 82);
            this.btnWithdrawl.Name = "btnWithdrawl";
            this.btnWithdrawl.Size = new System.Drawing.Size(93, 44);
            this.btnWithdrawl.TabIndex = 1;
            this.btnWithdrawl.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeposit);
            this.groupBox2.Controls.Add(this.btnLoan);
            this.groupBox2.Location = new System.Drawing.Point(389, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 142);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Image = ((System.Drawing.Image)(resources.GetObject("btnDeposit.Image")));
            this.btnDeposit.Location = new System.Drawing.Point(21, 82);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(95, 44);
            this.btnDeposit.TabIndex = 2;
            this.btnDeposit.UseVisualStyleBackColor = true;
            // 
            // btnLoan
            // 
            this.btnLoan.Image = ((System.Drawing.Image)(resources.GetObject("btnLoan.Image")));
            this.btnLoan.Location = new System.Drawing.Point(21, 19);
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.Size = new System.Drawing.Size(95, 43);
            this.btnLoan.TabIndex = 1;
            this.btnLoan.UseVisualStyleBackColor = true;
            this.btnLoan.Click += new System.EventHandler(this.btnLoan_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox3.Controls.Add(this.lblDeposit);
            this.groupBox3.Controls.Add(this.lblLoan);
            this.groupBox3.Controls.Add(this.lblPin);
            this.groupBox3.Controls.Add(this.lblWithdrawl);
            this.groupBox3.Controls.Add(this.lblBalance);
            this.groupBox3.Location = new System.Drawing.Point(166, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(207, 142);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposit.Location = new System.Drawing.Point(120, 106);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(71, 20);
            this.lblDeposit.TabIndex = 4;
            this.lblDeposit.Text = "Deposit";
            this.lblDeposit.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblLoan
            // 
            this.lblLoan.AutoSize = true;
            this.lblLoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoan.Location = new System.Drawing.Point(138, 19);
            this.lblLoan.Name = "lblLoan";
            this.lblLoan.Size = new System.Drawing.Size(49, 20);
            this.lblLoan.TabIndex = 3;
            this.lblLoan.Text = "Loan";
            // 
            // lblPin
            // 
            this.lblPin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPin.Location = new System.Drawing.Point(10, 51);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(177, 47);
            this.lblPin.TabIndex = 2;
            this.lblPin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPin.Click += new System.EventHandler(this.lblPin_Click);
            // 
            // lblWithdrawl
            // 
            this.lblWithdrawl.AutoSize = true;
            this.lblWithdrawl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWithdrawl.Location = new System.Drawing.Point(5, 106);
            this.lblWithdrawl.Name = "lblWithdrawl";
            this.lblWithdrawl.Size = new System.Drawing.Size(87, 20);
            this.lblWithdrawl.TabIndex = 1;
            this.lblWithdrawl.Text = "Withdrawl";
            this.lblWithdrawl.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(6, 19);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(74, 20);
            this.lblBalance.TabIndex = 0;
            this.lblBalance.Text = "Balance";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button19);
            this.groupBox4.Controls.Add(this.button20);
            this.groupBox4.Controls.Add(this.button17);
            this.groupBox4.Controls.Add(this.button18);
            this.groupBox4.Controls.Add(this.button15);
            this.groupBox4.Controls.Add(this.button16);
            this.groupBox4.Controls.Add(this.button13);
            this.groupBox4.Controls.Add(this.button14);
            this.groupBox4.Controls.Add(this.button11);
            this.groupBox4.Controls.Add(this.button12);
            this.groupBox4.Controls.Add(this.button9);
            this.groupBox4.Controls.Add(this.button10);
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Controls.Add(this.button8);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Location = new System.Drawing.Point(12, 191);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(512, 365);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // button19
            // 
            this.button19.Image = ((System.Drawing.Image)(resources.GetObject("button19.Image")));
            this.button19.Location = new System.Drawing.Point(347, 274);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(146, 79);
            this.button19.TabIndex = 17;
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Image = ((System.Drawing.Image)(resources.GetObject("button20.Image")));
            this.button20.Location = new System.Drawing.Point(347, 188);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(146, 76);
            this.button20.TabIndex = 16;
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button17
            // 
            this.button17.Image = ((System.Drawing.Image)(resources.GetObject("button17.Image")));
            this.button17.Location = new System.Drawing.Point(237, 274);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(93, 68);
            this.button17.TabIndex = 15;
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Image = ((System.Drawing.Image)(resources.GetObject("button18.Image")));
            this.button18.Location = new System.Drawing.Point(237, 187);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(93, 63);
            this.button18.TabIndex = 14;
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button15
            // 
            this.button15.Image = ((System.Drawing.Image)(resources.GetObject("button15.Image")));
            this.button15.Location = new System.Drawing.Point(128, 274);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(88, 68);
            this.button15.TabIndex = 13;
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Image = ((System.Drawing.Image)(resources.GetObject("button16.Image")));
            this.button16.Location = new System.Drawing.Point(128, 187);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(88, 63);
            this.button16.TabIndex = 12;
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button13
            // 
            this.button13.Image = ((System.Drawing.Image)(resources.GetObject("button13.Image")));
            this.button13.Location = new System.Drawing.Point(22, 274);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(83, 68);
            this.button13.TabIndex = 11;
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Image = ((System.Drawing.Image)(resources.GetObject("button14.Image")));
            this.button14.Location = new System.Drawing.Point(22, 187);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(83, 63);
            this.button14.TabIndex = 10;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button11
            // 
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.Location = new System.Drawing.Point(347, 110);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(146, 72);
            this.button11.TabIndex = 9;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Image = ((System.Drawing.Image)(resources.GetObject("button12.Image")));
            this.button12.Location = new System.Drawing.Point(347, 25);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(146, 79);
            this.button12.TabIndex = 8;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button9
            // 
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.Location = new System.Drawing.Point(237, 110);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(93, 62);
            this.button9.TabIndex = 7;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.Location = new System.Drawing.Point(237, 25);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(93, 66);
            this.button10.TabIndex = 6;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button7
            // 
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(128, 110);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(88, 62);
            this.button7.TabIndex = 5;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(128, 25);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(88, 66);
            this.button8.TabIndex = 4;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(22, 110);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(83, 62);
            this.button5.TabIndex = 3;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(22, 25);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(83, 66);
            this.button6.TabIndex = 2;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblMonthlyPayment);
            this.panel1.Controls.Add(this.btnExitSystem);
            this.panel1.Controls.Add(this.btnResetSystem);
            this.panel1.Controls.Add(this.btnReceiptSystem);
            this.panel1.Controls.Add(this.btnLoanSystem);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.txtInterestRate);
            this.panel1.Controls.Add(this.TextBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.Total_Payment);
            this.panel1.Controls.Add(this.Monthly_Payment);
            this.panel1.Controls.Add(this.Interest_Rate);
            this.panel1.Controls.Add(this.No_OfYear);
            this.panel1.Controls.Add(this.AmtOfLoan);
            this.panel1.Location = new System.Drawing.Point(542, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 530);
            this.panel1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(179, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 40);
            this.label7.TabIndex = 18;
            // 
            // lblMonthlyPayment
            // 
            this.lblMonthlyPayment.BackColor = System.Drawing.Color.White;
            this.lblMonthlyPayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMonthlyPayment.Location = new System.Drawing.Point(179, 270);
            this.lblMonthlyPayment.Name = "lblMonthlyPayment";
            this.lblMonthlyPayment.Size = new System.Drawing.Size(114, 35);
            this.lblMonthlyPayment.TabIndex = 17;
            // 
            // btnExitSystem
            // 
            this.btnExitSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitSystem.Location = new System.Drawing.Point(415, 439);
            this.btnExitSystem.Name = "btnExitSystem";
            this.btnExitSystem.Size = new System.Drawing.Size(86, 55);
            this.btnExitSystem.TabIndex = 16;
            this.btnExitSystem.Text = "Exit";
            this.btnExitSystem.UseVisualStyleBackColor = true;
            this.btnExitSystem.Click += new System.EventHandler(this.btnExitSystem_Click);
            // 
            // btnResetSystem
            // 
            this.btnResetSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetSystem.Location = new System.Drawing.Point(291, 439);
            this.btnResetSystem.Name = "btnResetSystem";
            this.btnResetSystem.Size = new System.Drawing.Size(94, 55);
            this.btnResetSystem.TabIndex = 15;
            this.btnResetSystem.Text = "Reset";
            this.btnResetSystem.UseVisualStyleBackColor = true;
            this.btnResetSystem.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnReceiptSystem
            // 
            this.btnReceiptSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceiptSystem.Location = new System.Drawing.Point(141, 439);
            this.btnReceiptSystem.Name = "btnReceiptSystem";
            this.btnReceiptSystem.Size = new System.Drawing.Size(113, 55);
            this.btnReceiptSystem.TabIndex = 14;
            this.btnReceiptSystem.Text = "Receipt";
            this.btnReceiptSystem.UseVisualStyleBackColor = true;
            this.btnReceiptSystem.Click += new System.EventHandler(this.btnReceiptSystem_Click);
            // 
            // btnLoanSystem
            // 
            this.btnLoanSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoanSystem.Location = new System.Drawing.Point(26, 439);
            this.btnLoanSystem.Name = "btnLoanSystem";
            this.btnLoanSystem.Size = new System.Drawing.Size(89, 55);
            this.btnLoanSystem.TabIndex = 13;
            this.btnLoanSystem.Text = "Loan";
            this.btnLoanSystem.UseVisualStyleBackColor = true;
            this.btnLoanSystem.Click += new System.EventHandler(this.btnLoanSystem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(312, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(201, 373);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterestRate.Location = new System.Drawing.Point(179, 184);
            this.txtInterestRate.Multiline = true;
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(114, 38);
            this.txtInterestRate.TabIndex = 7;
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(179, 95);
            this.TextBox2.Multiline = true;
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(114, 40);
            this.TextBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(179, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 35);
            this.textBox1.TabIndex = 5;
            // 
            // Total_Payment
            // 
            this.Total_Payment.AutoSize = true;
            this.Total_Payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Payment.Location = new System.Drawing.Point(14, 362);
            this.Total_Payment.Name = "Total_Payment";
            this.Total_Payment.Size = new System.Drawing.Size(108, 16);
            this.Total_Payment.TabIndex = 4;
            this.Total_Payment.Text = "Total Payment";
            this.Total_Payment.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // Monthly_Payment
            // 
            this.Monthly_Payment.AutoSize = true;
            this.Monthly_Payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monthly_Payment.Location = new System.Drawing.Point(14, 270);
            this.Monthly_Payment.Name = "Monthly_Payment";
            this.Monthly_Payment.Size = new System.Drawing.Size(125, 16);
            this.Monthly_Payment.TabIndex = 3;
            this.Monthly_Payment.Text = "Monthly Payment";
            this.Monthly_Payment.Click += new System.EventHandler(this.label4_Click);
            // 
            // Interest_Rate
            // 
            this.Interest_Rate.AutoSize = true;
            this.Interest_Rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Interest_Rate.Location = new System.Drawing.Point(3, 190);
            this.Interest_Rate.Name = "Interest_Rate";
            this.Interest_Rate.Size = new System.Drawing.Size(136, 16);
            this.Interest_Rate.TabIndex = 2;
            this.Interest_Rate.Text = "Enter Interest Rate";
            // 
            // No_OfYear
            // 
            this.No_OfYear.AutoSize = true;
            this.No_OfYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No_OfYear.Location = new System.Drawing.Point(3, 106);
            this.No_OfYear.Name = "No_OfYear";
            this.No_OfYear.Size = new System.Drawing.Size(158, 16);
            this.No_OfYear.TabIndex = 1;
            this.No_OfYear.Text = "Enter Number Of Year";
            // 
            // AmtOfLoan
            // 
            this.AmtOfLoan.AutoSize = true;
            this.AmtOfLoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmtOfLoan.Location = new System.Drawing.Point(3, 27);
            this.AmtOfLoan.Name = "AmtOfLoan";
            this.AmtOfLoan.Size = new System.Drawing.Size(156, 16);
            this.AmtOfLoan.TabIndex = 0;
            this.AmtOfLoan.Text = "Enter Amount Of Loan";
            this.AmtOfLoan.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnWithdrawl;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnLoan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.Label lblLoan;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.Label lblWithdrawl;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AmtOfLoan;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.TextBox TextBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Total_Payment;
        private System.Windows.Forms.Label Monthly_Payment;
        private System.Windows.Forms.Label Interest_Rate;
        private System.Windows.Forms.Label No_OfYear;
        private System.Windows.Forms.Button btnExitSystem;
        private System.Windows.Forms.Button btnResetSystem;
        private System.Windows.Forms.Button btnReceiptSystem;
        private System.Windows.Forms.Button btnLoanSystem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMonthlyPayment;
    }
}

