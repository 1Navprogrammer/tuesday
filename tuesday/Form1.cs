using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tuesday
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void output_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void input_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            //lblOutput.Text="Hello World";
            lbxOutput.Text = txtInput.Text;
            lbxOutput.Items.Add(txtInput.Text);


        }
    }
}
