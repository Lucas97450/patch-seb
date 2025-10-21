using System;
using System.IO;
using System.Windows.Forms;

namespace patch_seb_lucas
{
	internal static class Program
	{
		[STAThread]
		static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			// If running in Windows PE, launch the offline patcher UI
			string winDir = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
			string wpeInitPath = Path.Combine(winDir, "System32", "wpeinit.exe");
			if (File.Exists(wpeInitPath))
			{
				Application.Run(new OfflinePatcher());
				return;
			}

			// Allow switching to offline mode via command line
			if (args != null && args.Length == 1 &&
				(string.Equals(args[0], "/offline", StringComparison.OrdinalIgnoreCase)))
			{
				Application.Run(new OfflinePatcher());
				return;
			}

			// Default UI
			Application.Run(new Form1());
		}
	}
}





