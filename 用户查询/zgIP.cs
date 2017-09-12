using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 用户查询
{
    public partial class zgIP : Form
    {
        public zgIP()
        {
            InitializeComponent();
        }

        int index = 0;//错误次数统计
        private void Analysis_Click(object sender, EventArgs e)
        {
            PortPanel.Text = "端口扫描";
            try
            {
                text2.Text = "";
                //获取你输入的IP地址或者主机名称
                string pHostName = text1.Text.Trim().Replace("。", ".");
                //Host
                IPHostEntry myAddress = Dns.GetHostEntry(pHostName);
                //myAddress.Aliases
                IPAddress[] myIPAddress = myAddress.AddressList;
                //相互解析
                IPHostEntry myHostName = Dns.GetHostEntry(pHostName);
                //获取IP的用户名称
                text2.Text = myHostName.HostName.ToString().Replace(".mshome.net", "") + "\n";
                //获得IP相关参数
                foreach (IPAddress add in myIPAddress)
                {
                    text2.Text += add.ToString() + "\n";
                }
            }
            catch
            {
                index++;
                text2.Text = "很抱歉,解析失败！\n请检查是否输入正确。\n错误次数:(" + index.ToString() + ")";
                //MessageBox.Show("解析失败！");
            }
        }

        private void PortPanel_Click(object sender, EventArgs e)
        {
            if (PortPanel.Text == "导出")
            {
                //获取我的文档路径
                string Documents = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                System.IO.File.AppendAllText(Documents + "/端口扫描导出数据.ini", DateTime.Now.ToString("yy年MM月dd日") + "\r\n" + text2.Text);
                MessageBox.Show("导出完成，请到我的文档查看！");
            }
            else
            {
                panel.Visible = true;
            }
        }

        private void Port_Click(object sender, EventArgs e)
        {
            //获取你输入的IP地址或者主机名称
            string pHostName = text1.Text.Trim().Replace("。", ".");
            int a = 0;
            int b = 255;
            if (text3.Text != "" && text4.Text != "")
            {
                try
                {
                    a = Convert.ToInt32(text3.Text);
                    b = Convert.ToInt32(text4.Text);
                }
                catch
                {
                    return;
                }
            }
            if (a > b)//防止a大于b
            {
                int k = a;
                a = b;
                b = k;
            }
            panel.Visible = false;
            text2.Text = "";
            for (int i = a; i <= b; i++)//循环连接输入范围内的端口
            {
                TcpClient myTcpClient = new TcpClient();//实例化一个Tcp客户端
                //多线程池扫描
                TcpConnect端口 myTcpConnect端口 = new TcpConnect端口(pHostName, i, myTcpClient);//封装要发送的参数
                ThreadPool.QueueUserWorkItem(new WaitCallback(ThreadScan), myTcpConnect端口);
            }
            //PortPanel.Text = "导出";
        }

        public class TcpConnect端口
        {
            //封装的参数
            public string hostname;
            public int x;
            public TcpClient myTcpClient;
            public TcpConnect端口(string host, int i, TcpClient tcp)//构造函数
            {
                hostname = host;
                x = i;
                myTcpClient = tcp;
            }
        }

        //线程池要委托的方法
        void ThreadScan(object obj)
        {
            TcpConnect端口 myTcpConnect端口 = (TcpConnect端口)obj;//把发送的结构转换成自己自定义的结构/拆箱
            try
            {
                myTcpConnect端口.myTcpClient.Connect(myTcpConnect端口.hostname, myTcpConnect端口.x);
                SetText("目标端口: " + myTcpConnect端口.x.ToString() + " 目前打开!!");//输出当前打开的端口
                myTcpConnect端口.myTcpClient.Close();//关闭TCP客户端实例
            }
            catch
            {
                SetText("目标端口: " + myTcpConnect端口.x.ToString() + " 关闭!!");//输出连接失败的原因
            }
        }

        #region 线程不能控制控件，通过委托来控制控件
        delegate void SetTextCallBack(string text);
        private void SetText(string text)
        {
            if (this.text2.InvokeRequired)
            {
                SetTextCallBack stcb = new SetTextCallBack(SetText);
                this.Invoke(stcb, new object[] { text });
            }
            else
            {
                this.text2.Text = text + "\n" + text2.Text;
            }
        }
        #endregion

        private void zgIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                Analysis_Click(null, null);
            }
        }
    }
}