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
        
        public Form1()
        {
            InitializeComponent();
        }

        public async Task SetText(string textBtc)
        {

            textBox1.Text = textBtc;

        }

        public async Task SetTextEth(string textEth)
        {

            textBox2.Text = textEth;
        }

        public async Task SetTextMatic(string textMatic)
        {

            textBox3.Text = textMatic;

        }

    }
}
