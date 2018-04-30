using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Plugin4
{
    public partial class Form1 : Form
    {
        PluginInterface.IPluginHost _iHost;
        public Form1(PluginInterface.IPluginHost iHost)
        {
            InitializeComponent();
            _iHost = iHost;
            label1.Text = iHost.HotelID().ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Plugin4 pl = new Plugin4();
            _iHost.Feedback("fsfs", pl);
        }
    }
}
