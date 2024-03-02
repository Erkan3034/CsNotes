using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradingDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void propertyGrid1_Click(object sender, EventArgs e)
         {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşlem 1 çalıştı");
        }

        private void btnProcess2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşlem 2 çalıştı");
        }
    }
}
