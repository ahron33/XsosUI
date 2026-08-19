using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xsos
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public static void Drag_Form(IntPtr Handle, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        //public stuff

        private void OptionsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void minbtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void mainpnl_MouseDown(object sender, MouseEventArgs e)
        {
            Drag_Form(Handle, e);
        }

        private void mainlbl_MouseDown(object sender, MouseEventArgs e)
        {
            Drag_Form(Handle, e);
        }

        private void xsospic_MouseDown(object sender, MouseEventArgs e)
        {
            Drag_Form(Handle, e);
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            
        }

        private void checkedit_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkedit_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkedit.Checked)
            {
                WindowsIdentity identity = WindowsIdentity.GetCurrent();
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                bool isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);
                string check = isAdmin.ToString();

                if (check == "True")
                {
                    RegistryKey localMachine = RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, RegistryView.Registry64);

                    var reg = localMachine.OpenSubKey("Software\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", true);
                    if (reg == null)
                    {
                        reg = localMachine.CreateSubKey("Software\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection");
                    }

                    if (reg.GetValue("DisableRealtimeMonitoring") == null)
                    {
                        reg.SetValue("DisableRealtimeMonitoring", 1, RegistryValueKind.DWord);
                    }
                }
                else
                {
                    checkedit.Checked = false;
                    MessageBox.Show("You Have To Run The Program As Administrator!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                RegistryKey localMachine = RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, RegistryView.Registry64);
                var reg = localMachine.OpenSubKey("Software\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", true);

                reg.DeleteValue("DisableRealtimeMonitoring");
            }
        }
    }
}
