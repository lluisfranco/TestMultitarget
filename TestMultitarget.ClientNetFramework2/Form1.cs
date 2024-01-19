using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestMultitarget.Lib;

namespace TestMultitarget.ClientNetFramework2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += (s, e) =>
            {
                //var w = new SimpleClassWrapper();
                //w.GetSimpleClass().ShowForm();

                var ss = new SimpleClass();
                ss.ShowForm();
            };
        }
    }
}
