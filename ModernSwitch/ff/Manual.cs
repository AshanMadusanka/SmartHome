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

namespace ModernSwitch.ff
{
    public partial class Manual : Form
    {
        public Manual()
        {
            InitializeComponent();
        }

        private void onbtn_Click(object sender, EventArgs e)
        {
            try
            {

                onbtn.Enabled = false;
                onbtn.BackColor = Color.Lime;
                offbtn.BackColor = Color.White;
                offbtn.Enabled = true;
                serialPort1.Open();
                serialPort1.WriteLine("1");
                serialPort1.Close();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void offbtn_Click(object sender, EventArgs e)
        {
            try
            {

                offbtn.Enabled = false;
                offbtn.BackColor = Color.Red;
                onbtn.BackColor = Color.White;
                onbtn.Enabled = true;
                serialPort1.Open();
                serialPort1.WriteLine("0");
                serialPort1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Getsetting()
        {
            try
            {
                serialPort1.PortName = Properties.Settings.Default.index.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Manual_Load(object sender, EventArgs e)
        {
            Getsetting();
            try
            {
                
                serialPort1.BaudRate = (9600);
                serialPort1.ReadTimeout = (2000);
                serialPort1.WriteTimeout = (2000);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
