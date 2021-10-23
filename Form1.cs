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


namespace GUI
{
    
    public partial class Form1 : Form
    {
        SerialPort port;
        public Form1()
        {
            InitializeComponent();
            init();
        }
       private void Form1_load(object sendner, EventArgs e)
        {
            if (port.IsOpen)
            {
                port.WriteLine(progressBar1.Value.ToString());
            }
            
            
        }
        private void init()
        {
            port = new SerialPort();
            port.PortName = "COM2";
            try
            {
                port.Open();
            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        
    }
}
