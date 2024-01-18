using TestMultitarget.Lib;

namespace TestMultitarget.ClientNetCore
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
    }
}
