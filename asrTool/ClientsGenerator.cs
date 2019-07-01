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
    public partial class ClientsGenerator : Form
    {

        public Form1 f = new Form1();

        Thread EmuCLIENT;

        public ClientsGenerator()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 501; i++)
            {
                TcpTool.ipc = f.asrip.Text;
                TcpTool.portc = int.Parse(f.asrport.Text);

                EmuCLIENT = new Thread(new ThreadStart(TcpTool.Client));
                EmuCLIENT.Start();
            }
        }
    }
}
