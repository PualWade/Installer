using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Installer
{
    class ComputerInformation
    {
        public string UserName { get; set; }
        public string ComputerName { get; set; }
        public string PathWindows { get; set; }
        public string PathSystemFiles { get; set; }
        public int MouseButtons { get; set; }
        public Size PrimaryMonitorSize { get; set; }
        public int RAM { get; set; }
    }
}
