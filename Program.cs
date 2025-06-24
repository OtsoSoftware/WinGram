using System;
using System.Threading;
using System.Windows.Forms;

namespace WinGram
{
	static public class Program
	{
		/// <summary>
		/// Determines if data files should be created and stored in a subfolder by the executablr
		/// </summary>
		public static readonly bool IsPortable = true;
		/// <summary>
		/// If the build is intended for public use (e.g. don't keep&store keys in config)
		/// </summary>
		public static readonly bool IsPublish = false;


		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
			Application.ThreadException += new ThreadExceptionEventHandler(Program.Exception);

			Application.Run(new LoginForm());
		}

		public static void Exception(object sender, ThreadExceptionEventArgs e) //global exception handler. very human-friendly
		{
			new MsgBox($"{e.Exception.Message}\n{e.Exception.TargetSite}\n{e.Exception.Data}",
				"We are doomed", msgicon: MessageBoxIcon.Error).ShowDialog();
		}
	}
}