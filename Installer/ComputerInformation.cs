using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Installer
{
    static class ComputerInformation
    {
        static ComputerInformation() 
        { 

        }
        public static  string sd = Environment.UserName;
        public static string UserName { get; set; }
        public static string ComputerName { get; set; }
        public static string PathWindows { get; set; }
        public static string PathSystemFiles { get; set; }
        public static int MouseButtons { get; set; }
        public static Size PrimaryMonitorSize { get; set; }
        public static int RAM { get; set; }
    }
}
