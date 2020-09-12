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
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }
         bool toggle;
        private void Setting_Load(object sender, EventArgs e)
        {
            Getsetting();
         
         try
                {


                    Portbox.Items.AddRange(SerialPort.GetPortNames());
                    serialPort1.BaudRate = (9600);
                    serialPort1.ReadTimeout = (2000);
                    serialPort1.WriteTimeout = (2000);
                    


            }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
        }
        
        public void Savesetting()
        {
            Properties.Settings.Default.index = Portbox.Text;
        }

        public void Getsetting()
        {
            Portbox.Text = Properties.Settings.Default.index.ToString();
        }

        public void btngetsetting()
        {
            toggle = Properties.Settings.Default.toggle1;
        }
        public void btnsavesetting()
        {
            Properties.Settings.Default.toggle1 = toggle;
        }
        private void cntbtn_Click(object sender, EventArgs e)
        {
            Savesetting();
            Getsetting();
            


            if (toggle == true)
            {
                cntbtn.Text = "Connect";
                toggle = false;
                Portbox.Enabled = true;
                btnsavesetting();
                btngetsetting();
            }
            else
            {
                cntbtn.Text = "Disconnect";
                toggle = true;
                Portbox.Enabled = false;
                btnsavesetting();
                btngetsetting();
               

            }
        }

        private void Portbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
