using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace kalkulejtav1
{
    public partial class Form1 : Form
    {
        public Form1() { 
            InitializeComponent();
        }

        private void kalkulejtaIP(object sender, EventArgs e) {
            IPAddress ipAddress = IPAddress.Parse(oknoIPTextBox.Text);
            IPAddress maskAddress = IPAddress.Parse(MaskaTextBox.Text);
            byte[] ip = ipAddress.GetAddressBytes();
            byte[] mask = maskAddress.GetAddressBytes();
            byte[] network = new byte[4];
            byte[] bc = new byte[4];
            byte[] revmask = maskAddress.GetAddressBytes();
            for (int i = 0; i < 4; i++) {
                network[i] = (byte)(ip[i] & mask[i]);
                revmask[i] = (byte)~mask[i];
                bc[i] = (byte)(network[i] | revmask[i]);
            }
            Array.Copy(network, bc, 4);
            string networkAddressString = "";
            string bcaddressString = "";
            for (int i = 0; i < 4; i++) {
                String ipFragment = network[i].ToString();
                ipFragment = ipFragment.PadLeft(3, '0');
                networkAddressString += ipFragment;
                ipFragment = bc[i].ToString();
                ipFragment = ipFragment.PadLeft(3, '0');
                bcaddressString += ipFragment;
            }
            netTextBox1.Text = networkAddressString;
            bcTextBox1.Text = bcaddressString;
        }


    }
}
