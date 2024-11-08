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

namespace Arduino_LedTest1
{
    public partial class Form1 : Form
    {
        private SerialPort myPort;
        public Form1()
        {
            InitializeComponent();
            init();
        }
        public void init()
        {
            myPort = new SerialPort();
            myPort.BaudRate = 9600;
            myPort.PortName = "COM6";
            myPort.Open();

        }
        private void btn_red_Click(object sender, EventArgs e)
        {
            myPort.WriteLine("r");
        }

        private void btn_blue_Click(object sender, EventArgs e)
        {
            myPort.WriteLine("b");
        }

        private void btn_yellow_Click(object sender, EventArgs e)
        {
            myPort.WriteLine("y");
        }

        private void btn_green_Click(object sender, EventArgs e)
        {
            myPort.WriteLine("g");
        }
    }
}
