using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmpRegistration_asp_
{
    public partial class Calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

      

        protected void btn1_Click(object sender, EventArgs e)
        {
            String value = (sender as Button).Text;
            if (txtresult.Text == "0")
            {
                txtresult.Text = value;
            }
            else
            {
                txtresult.Text += value;
            }
        }
        private static String value1;
        private static String operation;

        protected void btnadd_Click(object sender, EventArgs e)
        {
            value1 = txtresult.Text;
            operation = btnadd.Text;
            txtstatus.Text = value1;
            txtresult.Text = "0";

        }

        protected void btnsub_Click(object sender, EventArgs e)
        {
            value1 = txtresult.Text;
            txtstatus.Text = value1;
            txtresult.Text = "0";
            operation = btnsub.Text;
        }

        protected void btnmul_Click(object sender, EventArgs e)
        {
            value1 = txtresult.Text;
            txtstatus.Text = value1;
            txtresult.Text = "0";
            operation = btnmul.Text;
        }

        protected void btndiv_Click(object sender, EventArgs e)
        {
            value1 = txtresult.Text;
            txtstatus.Text = value1;
            txtresult.Text = "0";
            operation = btndiv.Text;
        }

        protected void btncalculate_Click(object sender, EventArgs e)
        {
            String result;
            switch (operation)
            {
                case "+":

                    result = (double.Parse(value1) + double.Parse(txtresult.Text)).ToString();
                    txtstatus.Text = value1 + "+" + txtresult.Text;
                    txtresult.Text = result;
                    break;
                case "-":
                    result = (double.Parse(value1) - double.Parse(txtresult.Text)).ToString();
                    txtstatus.Text = value1 + "-" + txtresult.Text;
                    txtresult.Text = result;
                    break;
                case "*":
                    result = (double.Parse(value1) * double.Parse(txtresult.Text)).ToString();
                    txtstatus.Text = value1 + "*" + txtresult.Text;
                    txtresult.Text = result;
                    break;
                case "/":
                    result = (double.Parse(value1) / double.Parse(txtresult.Text)).ToString();
                    txtstatus.Text = value1 + "/" + txtresult.Text;
                    txtresult.Text = result;
                    break;

            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtresult.Text = "0";
            txtstatus.Text = "0";

        }

       
    }
}