using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace IfMyComputer
{
    public partial class Form1 : Form
    {
        private enum WorkState { Hide, Show };
        private WorkState workstate = WorkState.Show;

        //private SessionWatcher sWatcher;

        public Form1()
        {
            InitializeComponent();
            SystemEvents.SessionSwitch += loginEventChanged;
        }

        private void showMaxScreen()
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Maximized;
            workstate = WorkState.Show;
        }

        private string getTime()
        {
            //return DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] ");
            return DateTime.Now.ToString("yyyy年MM月dd日 HH时mm分ss秒：");
        }

        private void writeLog(string logitem)
        {
            this.textBox1.Text += getTime() + logitem + "\r\n";
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.ShowInTaskbar = false;
            this.Hide();
            workstate = WorkState.Hide;
            passwdTextbox.Text = "";
            writeLog(usernameTextbox.Text + " log in");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                //If define close event as hide window, you need use this code below
                //关闭即隐藏时启用下面的代码
                //this.ShowInTaskbar = false;
                //this.Hide();
            }
        }

        private void windowsNnotifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            showMaxScreen();
        }

        private void loginEventChanged(object sender, Microsoft.Win32.SessionSwitchEventArgs e)
        {
            if (workstate == WorkState.Show)
            {
                return;
            }

            if (e.Reason == SessionSwitchReason.ConsoleConnect)
            {
                writeLog("ConsoleConnect");
            }
            else if (e.Reason == SessionSwitchReason.ConsoleDisconnect)
            {
                writeLog("ConsoleDisconnect");

            }
            else if (e.Reason == SessionSwitchReason.RemoteConnect)
            {
                writeLog("RemoteConnect");

            }
            else if (e.Reason == SessionSwitchReason.RemoteDisconnect)
            {
                writeLog("RemoteDisconnect");

            }
            else if (e.Reason == SessionSwitchReason.SessionLock)
            {
                writeLog("SessionLock");

            }
            else if (e.Reason == SessionSwitchReason.SessionLogoff)
            {
                writeLog("SessionLogoff");

            }
            else if (e.Reason == SessionSwitchReason.SessionLogon)
            {
                writeLog("SessionLogon");

            }
            else if (e.Reason == SessionSwitchReason.SessionRemoteControl)
            {
                writeLog("SessionRemoteControl");

            }
            else if (e.Reason == SessionSwitchReason.SessionUnlock)
            {
                writeLog("SessionUnlock");

            }
            else
            {
                writeLog("Others");

            }
            showMaxScreen();
        }

        //private void locktimer_Tick(object sender, EventArgs e)
        //{
        //    //writeLog(sWatcher.getState());

        //    if (workstate == WorkState.Show)
        //    {
        //        return;
        //    }

        //    if (sWatcher.isLock())
        //    {
        //        showMaxScreen();
        //        writeLog("lock");
        //        return;
        //    }

        //    if (sWatcher.isRemoteConnected())
        //    {
        //        showMaxScreen();
        //        writeLog("remote connected");
        //        return;
        //    }
        //}
    }
}
