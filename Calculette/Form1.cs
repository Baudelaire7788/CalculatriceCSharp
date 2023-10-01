using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculette
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(Button b in Controls.OfType<Button>().Where(x=>x.Tag != null))
            {
                b.Click += B_Click;
            }
        }

        private void B_Click(object sender, EventArgs e)
        {
            var leBtnClique = (Button)sender;
            textCalc.Text += leBtnClique.Text;
            button13.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textCalc.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textCalc.Text.Length >0)
                textCalc.Text = textCalc.Text.Remove(textCalc.Text.Length - 1);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textCalc.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.Enabled = false;
            DataTable dt = new DataTable();
            textCalc.Text=dt.Compute(textCalc.Text.Replace(",",".").Replace("x","*"), "").ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textCalc.Text.Length > 0)
                textCalc.Text = textCalc.Text.Remove(textCalc.Text.Length - 1);
        }
    }
}
