using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Windows.Forms;

namespace MOBIeditor {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static int Main() {
			
			if (!OperatingSystem.IsWindows())
			{
				Console.WriteLine(@"This program is only supported on Windows.");
				return 1;
			}

			WindowsOnlyMethod();
			return 0;
		}

		[SupportedOSPlatform("windows")]
		static void WindowsOnlyMethod()
		{
			// Windows-specific code here
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
