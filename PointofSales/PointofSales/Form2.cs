using Gecko;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PointofSales
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Xpcom.Initialize("Firefox");
            geckoWebBrowser1.Navigate("http://localhost/pos/public/home/logout");
            
        }
    }
}
