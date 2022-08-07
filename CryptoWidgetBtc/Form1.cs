using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoWidgetBtc
{
    public partial class Form1 : Form
    {
        private string txt;

        private string txtEth;

        private string txtMatic;
        public Form1()
        {
            InitializeComponent();
        }

        public async Task SetText(string tt)
        {
            txt = tt;
            textBox1.Text = txt;

        }

        public async Task SetTextEth(string ttEth)
        {
            txtEth = ttEth;
            textBox2.Text = txtEth;
        }

        public async Task SetTextMatic(string ttMatic)
        {
            txtMatic = ttMatic;
            textBox3.Text = txtMatic;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
