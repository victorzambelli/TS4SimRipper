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
    public partial class ListingForm : Form
    {
        public ListingForm(string listing, string title)
        {
            InitializeComponent();
            try { this.Icon = new System.Drawing.Icon(System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "Resources", "ts4.ico")); } catch { }
            this.Listing_textBox.Text = listing;
            this.Listing_textBox.Select(0, 0);
            this.Text = title;
        }
    }
}
