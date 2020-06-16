using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19_PA9_Leo_Eng
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            double AmountEntered;
            double convertedvalue;

            if((rdb_USdollars.Checked == false)||(rdb_JapaneseYen.Checked == false))
            {
                txt_convertedAmt.Text = "Select atleast one type of currency to convert";
            }
            try
            {
                if (rdb_USdollars.Checked == true)
                {
                    AmountEntered = double.Parse(txt_amount.Text);
                    convertedvalue = AmountEntered * 0.74;

                    txt_convertedAmt.Text = convertedvalue.ToString();
                }

                if (rdb_JapaneseYen.Checked == true)
                {
                    AmountEntered = double.Parse(txt_amount.Text);
                    convertedvalue = AmountEntered * 81.97;

                    txt_convertedAmt.Text = convertedvalue.ToString();
                }

                if (rdb_ringgit.Checked == true)
                {
                    AmountEntered = double.Parse(txt_amount.Text);
                    convertedvalue = AmountEntered * 3.01;

                    txt_convertedAmt.Text = convertedvalue.ToString();
                }

            }
            catch (System.FormatException)
            {
                txt_convertedAmt.Text = "Only Number is allow";
            }

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_convertedAmt.Text = "";
            txt_amount.Text = "";
            rdb_JapaneseYen.Checked = false;
            rdb_USdollars.Checked = false;
        }

    }
}
