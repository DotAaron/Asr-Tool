using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asrTool
{
    public partial class ClientGen : Form
    {
        public string ip = "";
        public int port = 0;

        Thread[] EmuCLIENT = new Thread[5000];

        public ClientGen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Maximum = int.Parse(textBox1.Text) -1;
                progressBar1.Value = 0;
                if (button1.Text == "Deploy")
                {
                    textBox1.ReadOnly = true;
                    button1.Text = "Stop";
                    for (int i = 0; i < int.Parse(textBox1.Text); i++)
                    {
                        label1.Text = "Processing...";
                        progressBar1.Value = i;
                        TcpTool.ipc = ip;
                        TcpTool.portc = port;

                        EmuCLIENT[i] = new Thread(new ThreadStart(TcpTool.Client));
                        EmuCLIENT[i].Start();
                    }
                    label1.Text = "Started.";
                }
                else
                {
                    label1.Text = "Processing...";
                    textBox1.ReadOnly = false;
                    button1.Text = "Deploy";
                    for (int i = 0; i < int.Parse(textBox1.Text); i++)
                    {
                        progressBar1.Value = i;
                        EmuCLIENT[i].Abort();
                    }
                    label1.Text = "Stopped.";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label1.Text = "Error.";
            }
        }

        private void ClientGen_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                label1.Text = "Processing...";
                textBox1.ReadOnly = false;
                button1.Text = "Deploy";
                for (int i = 0; i < int.Parse(textBox1.Text); i++)
                {
                    progressBar1.Value = i;
                    EmuCLIENT[i].Abort();
                }
                label1.Text = "Stopped.";
            }
            catch (Exception) { }
        }
    }
}
