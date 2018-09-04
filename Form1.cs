using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_ATM
{
    public partial class Form1 : Form
    {
        double InterestRate, monthlyInterestRate, loanAmount, MonthlyPayment, TotalPayment;

        int numberOfYears;
        string iMonthlyPayment, iTotalPAyment;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblBalance.Visible = false;
            lblDeposit.Visible = false;
            lblLoan.Visible = false;
            lblWithdrawl.Visible = false;

            btnBalance.Enabled = false;
            btnLoan.Enabled= false;
            btnWithdrawl.Enabled = false;
            btnDeposit.Enabled = false;

            btnLoanSystem.Enabled = false;
            btnReceiptSystem.Enabled = false;
            btnResetSystem.Enabled = false;
            btnExitSystem.Enabled = false;

            
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "7";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "2";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "3";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "5";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "6";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "8";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "9";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            lblPin.Text ="";

            lblBalance.Visible = false;
            lblLoan.Visible = false;
            lblWithdrawl.Visible = false;
            lblDeposit.Visible = false;

            btnBalance.Enabled = false;
            btnLoan.Enabled = false;
            btnWithdrawl.Enabled = false;
            btnDeposit.Enabled = false;

            btnLoanSystem.Enabled = false;
            btnReceiptSystem.Enabled = false;
            btnResetSystem.Enabled = false;
            btnExitSystem.Enabled = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm you want to exit", "ATM System", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
             
             if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void button20_Click(object sender, EventArgs e)
        {
            String pin1 = String.Format(lblPin.Text);
            String pin2 = String.Format(lblPin.Text);
            String pin3 = String.Format(lblPin.Text);
            String pin4 = String.Format(lblPin.Text);
            String pin5 = String.Format(lblPin.Text);

            if (pin1 == "1234")
            {
                lblBalance.Visible = true;
                lblDeposit.Visible = true;
                lblLoan.Visible = true;
                lblWithdrawl.Visible = true;

                btnBalance.Enabled = true;
                btnLoan.Enabled = true;
                btnWithdrawl.Enabled = true;
                btnDeposit.Enabled = true;

            }

            else if (pin1 == "2345")
            {
                lblBalance.Visible = true;
                lblDeposit.Visible = true;
                lblLoan.Visible = true;
                lblWithdrawl.Visible = true;

                btnBalance.Enabled = true;
                btnLoan.Enabled = true;
                btnWithdrawl.Enabled = true;
                btnDeposit.Enabled = true;
            }

            else if (pin1 == "3456")
            {
                lblBalance.Visible = true;
                lblDeposit.Visible = true;
                lblLoan.Visible = true;
                lblWithdrawl.Visible = true;

                btnBalance.Enabled = true;
                btnLoan.Enabled = true;
                btnWithdrawl.Enabled = true;
                btnDeposit.Enabled = true;
            }

            else if (pin1 == "4567")
            {
                lblBalance.Visible = true;
                lblDeposit.Visible = true;
                lblLoan.Visible = true;
                lblWithdrawl.Visible = true;

                btnBalance.Enabled = true;
                btnLoan.Enabled = true;
                btnWithdrawl.Enabled = true;
                btnDeposit.Enabled = true;
            }

            else if (pin1 == "5678")
            {
                lblBalance.Visible = true;
                lblDeposit.Visible = true;
                lblLoan.Visible = true;
                lblWithdrawl.Visible = true;

                btnBalance.Enabled = true;
                btnLoan.Enabled = true;
                btnWithdrawl.Enabled = true;
                btnDeposit.Enabled = true;
            }

            else
            {
                lblPin.Text = "Invalid Pin";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            TextBox2.Clear();
            txtInterestRate.Clear();
            lblMonthlyPayment.Text = " ";
            label7.Text = " ";
            richTextBox1.Clear();

            btnReceiptSystem.Enabled = false;

        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            btnLoanSystem.Enabled = true;
            btnReceiptSystem.Enabled = true;
            btnResetSystem.Enabled = true;
            btnExitSystem.Enabled = true;
        }

        private void btnExitSystem_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm you want to exit", "ATM System", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lblPin_Click(object sender, EventArgs e)
        {

        }

        private void btnLoanSystem_Click(object sender, EventArgs e)
        {
            InterestRate = Convert.ToDouble(txtInterestRate.Text);
            monthlyInterestRate = InterestRate / 1200;
            numberOfYears = Convert.ToInt32(TextBox2.Text);
            loanAmount = Convert.ToDouble(textBox1.Text);


            MonthlyPayment = loanAmount * monthlyInterestRate / (1 - 1 / Math.Pow(1 + monthlyInterestRate,
                numberOfYears * 12));
            //......................................

            iMonthlyPayment = Convert.ToString(MonthlyPayment);
            iMonthlyPayment = String.Format("{0:c}", MonthlyPayment);
            lblMonthlyPayment.Text = (iMonthlyPayment);
            //.........................................

            TotalPayment = MonthlyPayment * numberOfYears * 19;
            iTotalPAyment = String.Format("{0:c}", TotalPayment);
            label7.Text = (iTotalPAyment);
            textBox1.Text = String.Format("{0:c}", loanAmount);




        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnReceiptSystem_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("Loan Management System Calculator" + "\n");
            richTextBox1.AppendText("...................................." + "\n");
            richTextBox1.AppendText("Enter amount of Loan" + "\t" + textBox1.Text + "\n");
            richTextBox1.AppendText("Enter Number of Year" + "\t" + TextBox2.Text + "\n");
            richTextBox1.AppendText("Enter Interest Rate" + "\t" + "\t" + txtInterestRate.Text + "\n");
            richTextBox1.AppendText("Monthly Payment" + "\t" + "\t" + "\t" + label7.Text + "\n");
            richTextBox1.AppendText("................................." + "\n");
            richTextBox1.AppendText("...................Thank You.................." + "\n");
        }
    }
}
