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
    public partial class Form1 : Form
    {

        Thread Emu;
        Thread EmuCLIENT;
        System.Windows.Forms.Timer checkASConnected = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer checkCLConnected = new System.Windows.Forms.Timer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (TcpTool.QuickSend(asrip.Text, int.Parse(asrport.Text), "AsrTool") != "timedout")
                {
                    asrstatus.Text = "Success";
                }
                else { asrstatus.Text = "Timed out"; }
            }
            catch (Exception) { asrstatus.Text = "An error occured"; }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            tcpfrontOne.Text = "Basic:Testing...";
            if (TcpTool.QuickSend(asrip.Text, int.Parse(asrport.Text), "AsrTool") != "timedout") { tcpfrontOne.Text = "Basic:Success"; tcpfrontOne.ForeColor = Color.Green; } else { tcpfrontOne.Text = "Basic:Failed"; tcpfrontOne.ForeColor = Color.DarkRed; }

            tcpfrontTwo.Text = "Plugin injection:Testing...";
            if (TcpTool.QuickSend(asrip.Text, int.Parse(asrport.Text), "$internAUP printl AsrTool Plugin Injection") == "Injected.") { tcpfrontTwo.Text = "Plugin injection:Success"; tcpfrontTwo.ForeColor = Color.Green; } else { tcpfrontTwo.Text = "Plugin injection:Failed"; tcpfrontTwo.ForeColor = Color.DarkRed; }

            tcpfrontThird.Text = "AsrShare:Testing...";
            if (TcpTool.QuickSend(asrip.Text, int.Parse(asrport.Text), "c:askconnect") == "c:acceptconnect") { tcpfrontThird.Text = "AsrShare:Success"; tcpfrontThird.ForeColor = Color.Green; } else { tcpfrontThird.Text = "AsrShare:Failed"; tcpfrontThird.ForeColor = Color.DarkRed; }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if(button3.Text == "Run emulator")
            {
                button3.Text = "Stop";
                asrshareOne.Text = "Emulating on: 127.0.0.1:15440";
                asrshareTwo.Text = "AsrShare: Not connected, waiting...";

                Emu = new Thread(new ThreadStart(TcpTool.AsrShare));
                Emu.Start();
                checkASConnected.Start();
                checkASConnected.Tick += CheckASConnected_Tick;
                checkASConnected.Interval = 1;
            }
            else
            {
                TcpTool.StopAS = true;
                Emu = null;
                checkASConnected.Stop();
                button3.Text = "Run emulator";
                asrshareOne.Text = "Not emulating";
                asrshareTwo.Text = "AsrShare: Not connected";
            }
        }

        private void CheckASConnected_Tick(object sender, EventArgs e)
        {
            if (TcpTool.ConnectedAsrShare) { asrshareTwo.Text = "AsrShare: Connected"; }
            if (!TcpTool.ConnectedAsrShare) { asrshareTwo.Text = "AsrShare: Not connected, waiting..."; }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = TcpTool.QuickSend(asrip.Text, int.Parse(asrport.Text), "phone.getinfo").Replace("\n", Environment.NewLine);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            textBox2.Text = TcpTool.QuickSend(asrip.Text, int.Parse(asrport.Text), "phone.getids").Replace("\n", Environment.NewLine);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (button5.Text == "Run emulator")
                {
                    button5.Text = "Stop";

                    TcpTool.ipc = asrip.Text;
                    TcpTool.portc = int.Parse(asrport.Text);

                    EmuCLIENT = new Thread(new ThreadStart(TcpTool.Client));
                    EmuCLIENT.Start();
                    checkCLConnected.Start();
                    checkCLConnected.Tick += CheckCLConnected_Tick; ;
                    checkCLConnected.Interval = 1;
                    clientOne.Text = "Emulating... (id:" + TcpTool.id + ")";
                    clientTwo.Text = "Client: Not connected, connecting...";

                }
                else
                {
                    TcpTool.StopCL = true;
                    EmuCLIENT = null;
                    checkCLConnected.Stop();
                    button5.Text = "Run emulator";
                    clientOne.Text = "Not emulating";
                    clientTwo.Text = "Client: Not connected";
                }
            }
            catch (Exception) { }
        }

        private void CheckCLConnected_Tick(object sender, EventArgs e)
        {
            clientOne.Text = "Emulating... (id:" + TcpTool.id + ")";
            if (TcpTool.ConnectedCLIENT) { clientTwo.Text = "Client: Connected"; }
            if (!TcpTool.ConnectedCLIENT) { clientTwo.Text = "Client: Not connected, connecting..."; }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            TcpTool.QuickSend(asrip.Text, int.Parse(asrport.Text), "$internAUP " + textBox3.Text);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TcpTool.QuickSend(asrip.Text, int.Parse(asrport.Text), "execute exit");
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            ClientGen cg = new ClientGen();
            cg.ip = asrip.Text;
            cg.port = int.Parse(asrport.Text);

            cg.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                if (TcpTool.QuickSend(asrip.Text, int.Parse(usocketport.Text), "AsrTool").IndexOf("usocket | version") != -1) { MessageBox.Show("USocket is running on the port " + usocketport.Text, "USocket", MessageBoxButtons.OK, MessageBoxIcon.Information); } else { MessageBox.Show("USocket is not running on the port " + usocketport.Text, "USocket", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception) { }
        }
    }
}
