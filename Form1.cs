using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_ordering_System
{
    public partial class Form1 : Form
    {
        
        double item1 = 120.00, item2 = 110.00, item3 = 125.00, item4 = 150.00, item5 = 90.00, 
               item6 = 135, item7 = 155.00, item8 = 162.00, membershipDisc = 50 , addFee = 10 ,
               total , pnts = 0.03; 

        public Form1()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void btnComplete_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Item");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Total");

            total = (item1 * (double)nud1.Value) + (item2 * (double)nud2.Value) +
                    (item3 * (double)nud3.Value) + (item4 * (double)nud4.Value) +
                    (item5 * (double)nud5.Value) + (item6 * (double)nud6.Value) +
                    (item7 * (double)nud7.Value) + (item8 * (double)nud8.Value);
            pnts = total * 0.03;
           



            if (chk1.Checked || chk2.Checked || chk3.Checked || chk4.Checked ||
              chk5.Checked || chk6.Checked || chk7.Checked || chk8.Checked)
            {
                if (rbForHere.Checked)
                {
                    total = total;

                }
                else if (rbToGO.Checked)
                {
                    total += addFee;
                    
                }
                else
                {
                    MessageBox.Show("Please select dining method", "Dining", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Please select an item in the menu");
            }

            if (chkMember.Checked)
            {
                if (rbForHere.Checked)
                {
                    total -= membershipDisc;
                   
                }
                else if (rbToGO.Checked)
                {
                    total -= membershipDisc;
                    
                }
            }
            if (chk1.Checked)
            {

                dt.Rows.Add("Item 1", nud1.Value, item1 * (double)nud1.Value);
            }


            if (chk2.Checked)
            {

                dt.Rows.Add("Item 2", nud2.Value, item2 * (double)nud2.Value);
            }

            if (chk3.Checked)
            {

                dt.Rows.Add("Item 3", nud3.Value, item3 * (double)nud3.Value);
            }

            if (chk4.Checked)
            {

                dt.Rows.Add("Item 4", nud4.Value, item4 * (double)nud4.Value);
            }

            if (chk5.Checked)
            {

                dt.Rows.Add("Item 5", nud5.Value, item5 * (double)nud5.Value);
            }

            if (chk6.Checked)
            {

                dt.Rows.Add("Item 6", nud6.Value, item6 * (double)nud6.Value);
            }

            if (chk7.Checked)
            {

                dt.Rows.Add("Item 7", nud7.Value, item7 * (double)nud7.Value);
            }

            if (chk8.Checked)
            {

                dt.Rows.Add("Item 8", nud8.Value, item8 * (double)nud8.Value);
            }

            Form2 frm = new Form2(total , pnts, chkMember.Checked, rbForHere.Checked, dt);
                  frm.ShowDialog(); 
        }


        private void Form1_Load(object sender, EventArgs e)
        {

           
        }
        private void chk1_CheckedChanged(object sender, EventArgs e)
        {
            nud1.Enabled = true; nud1.Value = 1;
        }
        private void chk2_CheckedChanged(object sender, EventArgs e)
        {
            nud2.Enabled = true; nud2.Value = 1;
        }
        private void chk3_CheckedChanged(object sender, EventArgs e)
        {
             nud3.Enabled = true; nud3.Value = 1;
        }
        private void chk4_CheckedChanged(object sender, EventArgs e)
        {
            nud4.Enabled = true; nud4.Value = 1;
        }
        private void chk5_CheckedChanged(object sender, EventArgs e)
        {
            nud5.Enabled = true; nud5.Value = 1;
        }
        private void chk6_CheckedChanged(object sender, EventArgs e)
        {
            nud6.Enabled = true; nud6.Value = 1;
        }
        private void chk7_CheckedChanged(object sender, EventArgs e)
        {
            nud7.Enabled = true; nud7.Value = 1;
        }
        private void chk8_CheckedChanged(object sender, EventArgs e)
        {
            nud8.Enabled = true; nud8.Value = 1;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            chk1.Checked = false;
            chk2.Checked = false;
            chk3.Checked = false;
            chk4.Checked = false;
            chk5.Checked = false;
            chk6.Checked = false;
            chk7.Checked = false;
            chk8.Checked = false;
            chkMember.Checked = false;


            nud1.Enabled = false;
            nud2.Enabled = false; 
            nud3.Enabled = false; 
            nud4.Enabled = false; 
            nud5.Enabled = false; 
            nud6.Enabled = false;
            nud7.Enabled = false; 
            nud8.Enabled = false; 


            rbForHere.Checked = false;
            rbToGO.Checked = false;


          

            total = 0;
            pnts = 0;
        }

    }
}
