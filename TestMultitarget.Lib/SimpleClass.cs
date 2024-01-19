using System.Drawing;

namespace TestMultitarget.Lib
{
    public class SimpleClass
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }   

        public void ShowForm()
        {
            var f = new XtraForm1();
            f.ShowDialog();
        }
    }
}
