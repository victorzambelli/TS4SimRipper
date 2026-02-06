using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TS4SimRipper
{
    public partial class StartMessage : Form
    {
        public StartMessage()
        {
            this.CenterToScreen();
            InitializeComponent();
            try { this.Icon = new System.Drawing.Icon(System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "Resources", "ts4.ico")); } catch { }
        }
    }
}
