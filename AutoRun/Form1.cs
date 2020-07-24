using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace AutoRun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddAutoRun_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey key = Registry.LocalMachine;
                key = key.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
                key.SetValue("OurAutoRun",  textBoxURL.Text);
                key.Close();

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey key = Registry.LocalMachine;
                key = key.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");

                string file = key.GetValue("OurAutoRun", "") as string;

                if (file ==  textBoxURL.Text)
                {
                    MessageBox.Show("This programm is autorun");
                }
                else
                {
                    MessageBox.Show("This programm is NOT autorun");
                }

                key.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void buttonDeleteAuto_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey key = Registry.LocalMachine;
                key = key.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");

                string file = key.GetValue("OurAutoRun", "") as string;

                if(file=="")
                {
                    MessageBox.Show("AutoRun is clear");
                }
                else
                {
                    key.DeleteValue("OurAutoRun");
                    MessageBox.Show("Deleting was succeed");
                }

                key.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    textBoxFound.Text += openFileDialog1.FileName;
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
