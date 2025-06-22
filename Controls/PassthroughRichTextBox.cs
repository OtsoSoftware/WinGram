using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WinGram
{
    /// <summary>
    /// RichTextBox that ignores scrolling it's contents. 
    /// To be used inside of a parent control that wants to scroll many richtextboxes but not their fucking content
    /// </summary>
    public class PassthroughRichTextBox : RichTextBox
    {
        private const int WM_MOUSEWHEEL = 0x020A;

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_MOUSEWHEEL)
            {
                // Assume parent supports scrolling:
                Control parent = this.Parent;
                while (parent != null && !(parent is ScrollableControl))
                    parent = parent.Parent;

                if (parent != null)
                {
                    SendMessage(parent.Handle, m.Msg, m.WParam, m.LParam);
                    return; // don't perform scrolling iteslf
                }
            }

            base.WndProc(ref m);
        }
    }

}
