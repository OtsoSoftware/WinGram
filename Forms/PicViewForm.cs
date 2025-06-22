using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinGram
{
    public partial class PicViewForm: Form
    {
        public PicViewForm(Image image)
        {
            InitializeComponent();
            this.WinStylize();
            //temporary solution to always fullsreen the photo opened.
            //as it is now - it may umpscare someone. it better should remember last state...
            WindowState = FormWindowState.Maximized; 
            pictureBox1.Image = image;

            Bitmap icon = new(image, new Size(128, 128));
            this.Icon = Icon.FromHandle(icon.GetHicon());
        }

        void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }
    }
}
