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

namespace Station_Météo_Arduino
{
    public partial class Station : Form
    {
        SerialPort com = null;

        public string COM;

        public int BAUD;

        public string data;

        public string valeurs;

        public string tempT0;
        public string tempT1;
        public string tempT2;
        public string humiH0;

        public bool close;
        public bool connected;

        public Station()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            close = true;

            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            déconnexion();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            connexion();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            déconnexion();
        }

        public void COMStarted()
        {
            connected = true;

            textBoxBaud.Enabled = false;
            textBoxCom.Enabled = false;

            buttonStart.Visible = false;
            buttonStop.Visible = true;

            LabelEtat.Text = "État : Connecté       ";
        }

        public void COMStoped()
        {
            connected = false;

            textBoxBaud.Enabled = true;
            textBoxCom.Enabled = true;

            buttonStart.Visible = true;
            buttonStop.Visible = false;

            LabelEtat.Text = "État : Déconnecté   ";
        }

        private void textBoxBaud_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) connexion();            
        }

        private void textBoxCom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) connexion();
        }

        public void connexion()
        {
            COM = textBoxCom.Text;
            BAUD = Convert.ToInt16(textBoxBaud.Text);

            com = new SerialPort(COM, BAUD, Parity.None, 8, StopBits.One);

            try
            {
                com.Open();
                COMStarted();
                com.Write("#");
            }
            catch (Exception) { MessageBox.Show("Le port " + COM + " n'est pas disponible"); }

            com.DataReceived += new SerialDataReceivedEventHandler(lectureValeurs);
        }

        public void déconnexion()
        {
            if (connected == true)
            {
                com.Close();
                COMStoped();
            }

            if (close == true)
            {
                Application.ExitThread();
                Application.Exit();
            }
        }

        void lectureValeurs(object sender, SerialDataReceivedEventArgs e)
        {
            try
            { data = com.ReadLine(); }
            catch (Exception) { };
            
            if (data != null)
            {
                valeurs = data.Substring(0, 16);

                tempT0 = valeurs.Substring(2, 2);
                tempT1 = valeurs.Substring(6, 2);
                tempT2 = valeurs.Substring(10, 2);
                humiH0 = valeurs.Substring(14, 2);

                heure.Text = DateTime.Now.ToString("       hh:mm");
            }

            this.BeginInvoke(new updateAnalogLabel(updateValeurs)); 
        }

        private delegate void updateAnalogLabel();
        private void updateValeurs()
        {
            Rx.Text = "Rx : " + valeurs;

            DHT11t.Text = tempT0 + " °C";
            LM335.Text = tempT1 + " °C";
            DS18S20.Text = tempT2 + " °C";
            DHT11h.Text = humiH0 + " % HR";           

            data = null;
        }
    }


}
