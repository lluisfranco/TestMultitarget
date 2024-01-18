using System;
using System.Windows.Forms;
using TestMultitarget.Lib;

namespace TestMultitarget.ClientNetFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += (s, e) =>
            {
                MessageBox.Show(new SimpleClass().Sum(2, 2).ToString());
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
