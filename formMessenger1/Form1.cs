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
                Thread th = new Thread(Refresh);
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
                string message = Console.ReadLine();

                if (message.ToLower() == "exit")
                    break;

                Communication.SendMessage(message, peers[peerUserTxt.Text + peerIPTxt.Text].IP);
                me.addMessege(message);
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
        }

        private void Refresh()
        {
            string receiveMessege = null;

            while (true)
            {
                receiveMessege = Communication.StartListening();
                if (peers.ContainsKey(peerUserTxt.Text + peerIPTxt.Text))
                {
                    peers[peerUserTxt.Text + peerIPTxt.Text].addMessege(receiveMessege);
                    for (int i = 0; i < peers[peerUserTxt.Text + peerIPTxt.Text].Messeges.Count(); ++i)
                    {
                        messegeWindowTxt.Text += receiveMessege;
                    }
                }
            }
        }
    }
}
