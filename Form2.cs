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
    public partial class Form2 : Form
    {
        double total, points;
        bool chkMem = false, dining = false;
        DataTable dt = new DataTable();

        private void btnPay_Click(object sender, EventArgs e)
        {
            double payment, change;

            payment = double.Parse(txtPay.Text);
               if(payment < total)
            {
                DialogResult dg = MessageBox.Show("Kulang ang iyong Pera" , "Paalala", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    if(dg == DialogResult.Retry)
                    {
                        txtPay.Clear();
                        txtPay.Focus();
                    }
                    else
                    {
                        this.Close();
                    }

            }
            else
            {
                 change = payment - total;
                MessageBox.Show("Your Total Amount is : " + total + "\nYour Change is: " + change,"Reciept", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public Form2(double _total ,double _pnts, bool _chkMem, bool _dining, DataTable _dt )
        {
            InitializeComponent();
            total = _total;
            points = _pnts;
            chkMem = _chkMem;
            dining = _dining;
            dt = _dt;
            dgvDisplay.DataSource = dt;
            

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (chkMem == true)
            {
                lblMember.Text = "Yes";
            }
            else
            {
                lblMember.Text = "No";
            }

            if (dining == true)
            {
                lblDining.Text = "For here";
            }
            else
            {
                lblDining.Text = " To go";
            }


            
            lblTotal.Text = total.ToString();   
            lblPoints.Text = points.ToString();
        }
    }
}
