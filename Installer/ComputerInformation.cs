using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Installer
{
    static class ComputerInformation
    {
        public static string UserName = Environment.UserName;
        public static string ComputerName = Environment.MachineName;
        public static string PathWindows = "";
        public static string PathSystemFiles = Environment.SystemDirectory;
        public static int MouseButtons = System.Windows.Forms.SystemInformation.MouseButtons;
        public static Size PrimaryMonitorSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;
        public static long RAM = Environment.WorkingSet;

        public static long Drive = new DriveInfo(Convert.ToString(Directory.GetCurrentDirectory()[0])).TotalSize;
    }
}
