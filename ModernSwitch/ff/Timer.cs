using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernSwitch.ff
{
    public partial class Timer : Form
    {
        System.Timers.Timer timer;
        public Timer()
        {
            InitializeComponent();
        }
        private void Timer_Load(object sender, EventArgs e)
        {
            checkBox1.Hide();
            Getsetting();
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
        }

        public void writeone()
        {
            serialPort1.Open();
            serialPort1.WriteLine("1");
            serialPort1.Close();
        }

        public void writezero()
        {
            serialPort1.Open();
            serialPort1.WriteLine("0");
            serialPort1.Close();
        }

        public void Getsetting()
        {
            try
            {
                serialPort1.PortName = Properties.Settings.Default.index.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            DateTime userTime = dateTimePicker1.Value;
            if (currentTime.Hour == userTime.Hour && currentTime.Minute == userTime.Minute && currentTime.Second == userTime.Second && checkBox1.Checked==false)
            {
                timer.Stop();
                writezero();

            }

            else if (currentTime.Hour == userTime.Hour && currentTime.Minute == userTime.Minute && currentTime.Second == userTime.Second && checkBox1.Checked==true)
            {
                timer.Stop();
                writeone();
            }
        }

        public void to_onbtn_Click(object sender, EventArgs e)
        {

            writezero();
            timer.Start();
            checkBox1.Checked = true;
            
        }

        private void to_offbtn_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            timer.Start();
            writeone();
       
        }
    }  
    

    
}
