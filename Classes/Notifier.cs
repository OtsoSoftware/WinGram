using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinGram
{
    /// <summary>
    /// A simple implementation of a notification sender
    /// </summary>
    internal static class Notifier
    {
        public static void PlaySound()
        {
            new System.Media.SoundPlayer(WinGram.Properties.Resources.alert_ratchet).Play();
        }
    }
}
