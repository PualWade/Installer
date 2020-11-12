using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;


namespace Installer
{
    public partial class Form1 : Form
    {

        static string nameExe = "Authentication 2.0";
        static string pathExe = Directory.GetCurrentDirectory() + "\\" + nameExe + ".exe";
        public Form1()
        {
            InitializeComponent();
            label1.Text = Directory.GetCurrentDirectory();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;
            DialogResult dialogResult = folderBrowserDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                label1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.Copy(pathExe, label1.Text + "\\" + textBox2.Text + ".exe");
        }
    }
}
