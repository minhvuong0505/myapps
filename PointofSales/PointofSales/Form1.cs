using Gecko;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointofSales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Xpcom.Initialize("Firefox");
            geckoWebBrowser1.Navigate("http://localhost/opensourcepos/public/");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //FormBorderStyle = FormBorderStyle.Sizable;
            geckoWebBrowser1.NoDefaultContextMenu = true;
            geckoWebBrowser1.CreateWindow2 += GeckoWebBrowser1_CreateWindow2;
        }

        private void GeckoWebBrowser1_CreateWindow2(object sender, Gecko.GeckoCreateWindow2EventArgs e)
        {
            Process.Start(e.Uri);
            e.Cancel = true;
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            geckoWebBrowser1.Navigate("http://localhost/pos/public/home/logout");
        }

     
        private void label1_Click(object sender, EventArgs e)
        {
            DialogResult rl = MessageBox.Show("Logout and quit?", "", MessageBoxButtons.OKCancel);
            if (rl == DialogResult.OK)
            {
                Form2 frm = new Form2();
                frm.Show();
                this.Close();
            }
        }
    }
}
