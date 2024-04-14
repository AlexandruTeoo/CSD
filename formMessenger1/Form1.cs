using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace formMessenger1
{
    public partial class Form1 : Form
    {
        User me = new User();
        Dictionary<string, User> peers = new Dictionary<string, User>();
        
        public Form1()
        {
            InitializeComponent();

            try
            {
                Thread th = new Thread(refresh);
                th.Start();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }


        private void sendBtn_Click(object sender, EventArgs e)
        {
            while (Communication.isRunning)
            {
                Console.Write("You: ");
                string message = messegeToSendTxt.Text;
                messegeToSendTxt.Clear();

                if (message != null)
                {
                    Communication.SendMessage(message, peers[peerUserTxt.Text + peerIPTxt.Text].IP);
                    me.addMessege(message);
                } 
            }

            Communication.isRunning = false;
            Console.WriteLine("Program terminated.");

        }

        private void connBtn_Click(object sender, EventArgs e)
        {
            me.Username = myUserTxt.Text;
            me.IP = myIPTxt.Text;

            peers[peerUserTxt.Text + peerIPTxt.Text] = new User { Username = peerUserTxt.Text, IP = peerIPTxt.Text };

            Communication.StartListening();

            MessageBox.Show("ok");
        }

        private void refresh()
        {
            string receiveMessege = null;
            string key = peerUserTxt.Text + peerIPTxt.Text;
            while (true)
            {
                receiveMessege = Communication.StartListening();

                if (peers.ContainsKey(key) && receiveMessege != "")
                {
                    peers[key].addMessege(receiveMessege);
                    for (int i = 0; i < peers[key].Messeges.Count(); ++i)
                    {
                        RefreshMessages(receiveMessege);
                    }
                }
            }
        }

        private void RefreshMessages(string message)
        {
            if (messegeWindowTxt.InvokeRequired)
            {
                // Dacă suntem pe un fir de execuție diferit de cel UI, folosim Invoke pentru a accesa controlul UI
                this.Invoke(new MethodInvoker(delegate { RefreshMessages(message); }));
            }
            else
            {
                // Adăugăm mesajul în fereastra text
                messegeWindowTxt.Text += message + Environment.NewLine;
            }
        }
    }
}
