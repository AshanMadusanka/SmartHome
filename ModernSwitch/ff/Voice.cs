using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.IO.Ports;

namespace ModernSwitch.ff
{
    public partial class Voice : Form
    {
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        public Voice()
        {
            InitializeComponent();
        }

        private void Voice_Load(object sender, EventArgs e)
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

            Choices commands = new Choices();
            commands.Add(new string[] { "Turn On", "Turn Off","Who are you","Who am I"});
            GrammarBuilder gBuilder = new GrammarBuilder();
            gBuilder.Append(commands);
            Grammar grammar = new Grammar(gBuilder);

            recEngine.LoadGrammarAsync(grammar);
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.SpeechRecognized += RecEngine_SpeechRecognized;

            synthesizer.SpeakAsync("Initializing. Activating biometric and voice recognizing process. Activation succeeds. Checking current Bluetooth status. Access granted. Loading voice recognizing process. Voice recognize process is 40 present. Voice recognizing process is 60 present. Voice recognizing process is 99 present. Voice recognizing process is completed. You are now connected to smart switch.");
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

        private void RecEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text)
            {
                case "Turn On":
                    speechOk();
                  
                    serialPort1.Open();
                    serialPort1.WriteLine("1");
                    serialPort1.Close();
                 
                    
                    
                    break;

                case "Turn Off":
                    speechOk();
              
                    serialPort1.Open();
                    serialPort1.WriteLine("0");
                    serialPort1.Close();
              
                   
                    break;

                case "Who are you":
                    synthesizer.SpeakAsync("I am smart switch Developed by University of colombo faculty of technology");
                    break;
                case "Who am I":
                    synthesizer.SpeakAsync("You are My sir. Your name is Ashan ");
                    break;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                recEngine.RecognizeAsync(RecognizeMode.Multiple);
                button2.Enabled = true;
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsyncStop();
            button2.Enabled = false;
        }

        public void speechOk()
        {
            synthesizer.SpeakAsync("Ok sir");
        }

       
    }
}
