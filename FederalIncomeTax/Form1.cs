using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FederalIncomeTax
{
    public partial class FrmFedIncomeTax : Form
    {
        public FrmFedIncomeTax()
        {
            InitializeComponent();
        }

        //Write a program which determines the amount of Federal Income Tax one owes when given the taxable income.
        //Federal tax is determined as follows:
        //Taxable Income Tax
        //$1295 or less 6%
        //greater than 1295 and less than or equal to 2590 $78 + 16% on next 1295
        //greater than 2590 and less than or equal to 5180 $285 + 17% on next 2590
        //greater than 5180 and less than or equal to 7770 $725 + 18% on next 2590
        //greater than 7770 and less than or equal to 12950 $1191 + 19% on next 5180
        //greater than 12950 and less than or equal to 18130 $2176 + 20% on next 5180
        //greater than 18130 and less than or equal to 23310 $3212 + 23% on next 5180
        //greater than 23310 and less than or equal to 36260 $4403 + 25% on next 12950
        //greater than 36260 and less than or equal to 62160 $7641 + 30% on next 25900
        //greater than 62160 $15411 + 34% on remainder

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double taxEntered = double.Parse(txtTextBox.Text);

            if(taxEntered <= 1295)
            {
                double charge = taxEntered * 0.06;
                string formattedMoneyValue = String.Format("{0:C2}", charge);
                lblResult.Text = "Your charge is " + formattedMoneyValue;
                lblResult.Visible = true;
            }
            else if(taxEntered > 1295 && taxEntered <= 2590)
            {
                double charge = ((taxEntered - 1295) * 0.16) + 78;
                string formattedMoneyValue = String.Format("{0:C2}", charge);
                lblResult.Text = "Your charge is " + formattedMoneyValue;
                lblResult.Visible = true;
            }
            else if (taxEntered > 2590 && taxEntered <= 5180)
            {
                double charge = ((taxEntered - 2590) * 0.17) + 285;
                string formattedMoneyValue = String.Format("{0:C2}", charge);
                lblResult.Text = "Your charge is " + formattedMoneyValue;
                lblResult.Visible = true;
            }
            else if (taxEntered > 5180 && taxEntered <= 7770)
            {
                double charge = ((taxEntered - 5180) * 0.18) + 725;
                string formattedMoneyValue = String.Format("{0:C2}", charge);
                lblResult.Text = "Your charge is " + formattedMoneyValue;
                lblResult.Visible = true;
            }
            else if (taxEntered > 7770 && taxEntered <= 12950)
            {
                double charge = ((taxEntered - 7770) * 0.19) + 1191;
                string formattedMoneyValue = String.Format("{0:C2}", charge);
                lblResult.Text = "Your charge is " + formattedMoneyValue;
                lblResult.Visible = true;
            }
            else if (taxEntered > 12950 && taxEntered <= 18130)
            {
                double charge = ((taxEntered - 12950) * 0.20) + 2176;
                string formattedMoneyValue = String.Format("{0:C2}", charge);
                lblResult.Text = "Your charge is " + formattedMoneyValue;
                lblResult.Visible = true;
            }
            else if (taxEntered > 18130 && taxEntered <= 23310)
            {
                double charge = ((taxEntered - 18130) * 0.23) + 3212;
                string formattedMoneyValue = String.Format("{0:C2}", charge);
                lblResult.Text = "Your charge is " + formattedMoneyValue;
                lblResult.Visible = true;
            }
            else if (taxEntered > 23310 && taxEntered <= 36260)
            {
                double charge = ((taxEntered - 23310) * 0.25) + 4403;
                string formattedMoneyValue = String.Format("{0:C2}", charge);
                lblResult.Text = "Your charge is " + formattedMoneyValue;
                lblResult.Visible = true;
            }
            else if (taxEntered > 36260 && taxEntered <= 62160)
            {
                double charge = ((taxEntered - 36260) * 0.30) + 7641;
                string formattedMoneyValue = String.Format("{0:C2}", charge);
                lblResult.Text = "Your charge is " + formattedMoneyValue;
                lblResult.Visible = true;
            }
            else if (taxEntered > 62160)
            {
                double charge = ((taxEntered - 62160) * 0.34) + 15411;
                string formattedMoneyValue = String.Format("{0:C2}", charge);
                lblResult.Text = "Your charge is " + formattedMoneyValue;
                lblResult.Visible = true;
            }
        }
    }
}
