using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;
using System.Data.Common;

namespace MyTest
{
    public partial class PingTest : Form
    {
        public PingTest()
        {
            InitializeComponent();
        }

        private void FormTest_Load(object sender, EventArgs e)
        {
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            Ping p = new Ping();
            PingOptions op = new PingOptions();
            string ip = ipBox.Text;
            op.DontFragment = true;

            string data = "aaa";
            byte[] buff = Encoding.ASCII.GetBytes(data);
            int timeout = 6000;
            PingReply reply = p.Send(ip, timeout, buff, op);
            if (reply.Status == IPStatus.Success)
                result2Lable.Text = "ping成功啦！";
            else
                result2Lable.Text = "失败了:(";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ipBox.Clear();
            result2Lable.Text = "  ";
        }
    }
}
