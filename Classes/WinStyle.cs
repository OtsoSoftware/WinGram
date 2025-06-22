using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace WinGram
{
	/// <summary>
	/// Adds some style to our forms.
	/// </summary>
	internal static class WinStyle
	{


		#region For window styling
		[DllImport("dwmapi.dll", PreserveSig = false)]
		public static extern void DwmSetWindowAttribute(IntPtr hwnd, DWMWINDOWATTRIBUTE attr, ref int attrValue, int attrSize);

		public enum DWMWINDOWATTRIBUTE : uint
		{
			DWMWA_NCRENDERING_POLICY = 2
		}

		public enum DWMNCRENDERINGPOLICY
		{
			DWMNCRP_USEWINDOWSTYLE,
			DWMNCRP_DISABLED,
			DWMNCRP_ENABLED,
			DWMNCRP_LAST
		}

		public static void WinStylize(this Form form)
		{
			IntPtr hwnd = form.Handle;
			if (!IsProcessRunning("WBSrv")) //don't disable DWM if the user is already cool using WindowBlinds
			{
				int dwmDisabled = (int)DWMNCRENDERINGPOLICY.DWMNCRP_DISABLED;
				DwmSetWindowAttribute(hwnd, DWMWINDOWATTRIBUTE.DWMWA_NCRENDERING_POLICY, ref dwmDisabled, 4);
			}
		}

		private static bool IsProcessRunning(string processName) => Process.GetProcessesByName(processName).Length > 0;
		#endregion

	}
}
