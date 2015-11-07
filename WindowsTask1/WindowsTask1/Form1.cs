using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsTask1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void Form1_Load(object sender, EventArgs e)
        {
            lbinput.Items.Add("Red");
            lbinput.Items.Add("green");
            lbinput.Items.Add("white");
            lbinput.Items.Add("black");
            lbinput.Items.Add("yellow");
            lbinput.SelectionMode = SelectionMode.MultiSimple;

            lboutput.SelectionMode = SelectionMode.MultiSimple;
        }

        private void btnaddsingle_Click(object sender, EventArgs e)
        {
            lbinput.SelectionMode = SelectionMode.One;


            if (lboutput.Items.Count == 0)
            {
                lboutput.Items.Add(lbinput.SelectedItem.ToString());

            }
            else
            {
                for (int i = 0; i < lboutput.Items.Count; i++)
                {

                    if (lboutput.Items[i].ToString().Equals(lbinput.SelectedItem.ToString()))
                    {
                        MessageBox.Show("duplications not allowed");
                        break;
                    }
                    else
                    {
                        lboutput.Items.Add(lbinput.SelectedItem.ToString());
                        break;

                    }
                }
            }
        }

        private void btnaddmultiple_Click(object sender, EventArgs e)
        {

            if (lboutput.Items.Count == 0)
            {
                foreach (string s in lbinput.SelectedItems)
                {
                    lboutput.Items.Add(s.ToString());
                }

            }
            else
            {

                for (int j = 0; j < lbinput.SelectedItems.Count; j++)
                {
                    if (lbinput.Items[j].ToString().Equals(lboutput.Items[j].ToString()))
                    {

                        MessageBox.Show("duplications not allowed");

                    }
                    else
                    {
                        lboutput.Items.Add(lbinput.SelectedItems.ToString());

                    }
                }
            }

            //{
            //    foreach (string s in lbinput.SelectedItems)
            //    {
            //        if (s.ToString().Equals(lboutput.Items.ToString()))
            //        {
            //            MessageBox.Show("duplicate not allowed");
            //        }
            //        else
            //        {
            //            lboutput.Items.Add(s.ToString());
            //        }
            //    }
        }
        //else
        //{
        //    for (int i = 0; i < lboutput.Items.Count; i++)
        //    {

        //        if (lboutput.Items[i].ToString().Equals(lbinput.SelectedItems.ToString()))
        //        {
        //            MessageBox.Show("duplications not allowed");

        //        }
        //        else
        //        {
        //            foreach (string s in lbinput.SelectedItems)
        //            {
        //                lboutput.Items.Add(s.ToString());
        //            }


        //        }
        //    }
        //}
        private void btndeletesingle_Click(object sender, EventArgs e)
        {
            lboutput.Items.RemoveAt(lboutput.SelectedIndex);
        }

        private void btndeletemultiple_Click(object sender, EventArgs e)
        {
            List<String> deleteditems = new List<string>();
            foreach (String s in lboutput.SelectedItems)
            {
                deleteditems.Add(s);

            }
            deleteditems.Clear();

            for (int l = 0; l <lboutput.SelectedItems.Count; l++)
            {
                lboutput.Items.RemoveAt(lboutput.SelectedIndex);
                //if (lboutput.Items.Contains(lboutput.SelectedItems[l]))
                //{
                   
                //}

            }

        }
    }
}

    

    