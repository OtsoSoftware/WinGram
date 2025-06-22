using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TL;

namespace WinGram
{
    public partial class ProfileForm: Form
    {
        public ProfileForm(Peer peer)
        {
            MessageBox.Show(Account.UpdatesManager.UserOrChat(peer).MainUsername);
            InitializeComponent();
            this.WinStylize();
        }

        void picAvatar_Click(object sender, EventArgs e)
        {

        }
    }
}
