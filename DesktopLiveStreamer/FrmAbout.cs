using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesktopLiveStreamer
{
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
        }

        private void FrmAbout_Load(object sender, EventArgs e)
        {
            lblVersion.Text = Application.ProductVersion.ToString();
            lblMaker.Text = "Charaf \"" + Application.CompanyName + "\" Errachidi";
        }

        private void linkLiveStreamer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/chrippa/livestreamer");
        }

        private void linkDLS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/charnet3d/DesktopLiveStreamer");
        }
    }
}
