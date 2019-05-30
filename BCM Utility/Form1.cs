using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BCM_Utility
{
    public partial class Form1 : Form
    {
        string extension;
        string url;
        string ipAddress;
        string currentDisplay;
        int displays;
        int rows;
        int columns; 
        

        public Form1()
        {
            InitializeComponent();
            ClientButton.Checked = true;
            MainButton.Checked = true;
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            bool RBool = int.TryParse(RowText.Text, out rows);
            bool CBool = int.TryParse(ColumnText.Text, out columns);
            displays = rows * columns;

            if (WallButton.Checked)
            {
                ipAddress = "172.29.10.";
                int counterWall = 1;
                for (int i = 0; i < displays; i++)
                {
                    currentDisplay = counterWall.ToString();
                    url = "http://" + ipAddress + currentDisplay + extension;
                    Process.Start(url);
                    counterWall = counterWall + 1;
                }
            }
            else
            {
                ipAddress = IPText.Text;
                int counterClient = 40001;
                for (int i = 0; i < displays; i++)
                {
                    currentDisplay = counterClient.ToString();
                    url = "http://" + ipAddress + ":" + currentDisplay + extension;
                    Process.Start(url);
                    counterClient = counterClient + 1;
                }
            }
        }

        private void MainButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MainButton.Checked)
            {
                extension = "";
            }
        }

        private void MaintButton_CheckedChanged(object sender, EventArgs e)
        {
            if(MaintButton.Checked)
            {
                extension = "/cgi-bin/iface?page=maint&action=GET";
            }
        }

        private void ClientButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ClientButton.Checked)
            {
                IPText.Enabled = true;
                IPText.Text = "";
            }
        }

        private void WallButton_CheckedChanged(object sender, EventArgs e)
        {
            if (WallButton.Checked)
            {
                IPText.Enabled = false;
                IPText.Text = "172.29.1.1";
            }
        }
    }
}
