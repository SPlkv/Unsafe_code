using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Lab5.TiMP
{
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
            
            for (double i = 0; i < 20; i++) 
            {
                DateTime time = DateTime.Now;
                double value = i; 
                double point = Program.Graphic(time, value);
                textBox1.Text =Convert.ToString(point);
            }
            




        }
        public class Program
        {
            [DllImport("DllAmplitude.dll", CallingConvention = CallingConvention.StdCall)]
            public static extern struct Func(DateTime time, double value);
            public static double Graphic(DateTime time, double value)
            {
                return Func(time, value);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
