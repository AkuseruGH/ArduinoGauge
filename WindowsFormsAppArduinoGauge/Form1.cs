using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace WindowsFormsAppArduinoGauge
{
    public partial class Form1 : Form
    {
        int times;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            serialPort1.Open();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            userControl11.rotation();
            string cadena;
            int farenheints;
            if (serialPort1.IsOpen)
            {
                cadena = serialPort1.ReadLine();
                Int32.TryParse(cadena, out times);
                userControl11.angle = times;
                trackBar1.Value = times;
                valueLabel.Text = times.ToString() + (" C");
                farenheints = (times * 9 / 5) + 32;
                valueLabel2.Text = farenheints.ToString() + (" F");
            }
        }

        private void valueLabel_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
