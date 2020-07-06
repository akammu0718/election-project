using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ElectionProject
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                DataSet ds = new DataSet();
                ds.ReadXml("VoterDetails.xml");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
            
            }

        private void Home_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Form3 form3 = new Form3();
            form3.Show();
            form3.Hide();

        }
    }
}
