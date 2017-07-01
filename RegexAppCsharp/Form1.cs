using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegexAppCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /* Do Rgex Button Click*/
        private void button1_Click(object sender, EventArgs e)
        {
            //if search or replaced 
            //if search
            if (rd_Search.Checked) {
               // Match m = Regex.Match(txt_input.Text,txt_Pattern.Text);
               foreach(Match m  in Regex.Matches(txt_input.Text, txt_Pattern.Text))
                {
                    txt_Output.Text += m + "\n";
                }


            }else if (rd_Replace.Checked)
            {  // if Replaced
                txt_Output.Clear();
                txt_Output.Text = Regex.Replace(txt_input.Text, txt_From.Text, txt_To.Text);

            }
           



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rd_Search.Checked = true;
        }

        private void txt_Output_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
