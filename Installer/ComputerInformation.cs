using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Installer
{
    static class ComputerInformation
    {
        public static string UserName = Environment.UserName;
        public static string ComputerName = Environment.MachineName;
        public static string PathWindows = Environment.CurrentDirectory;
        public static string PathSystemFiles = Environment.SystemDirectory;
        //public static int MouseButtons = System.Windows.Forms.SystemInformation.MouseButtons;
        public static Size PrimaryMonitorSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;
        public static long RAM = Environment.WorkingSet;
        public static long Drive = new DriveInfo(Convert.ToString(Directory.GetCurrentDirectory()[0])).TotalSize;
        public static string TypeKeyboard = Keyboard.PrimaryDevice.ToString();

        public static byte[] AllPropertiesBytes = Encoding.Default.GetBytes(UserName + ComputerName + PathWindows + PathSystemFiles + Convert.ToString(PrimaryMonitorSize.Height) + Convert.ToString(RAM) + Convert.ToString(Drive) + TypeKeyboard);

        
    }
}
