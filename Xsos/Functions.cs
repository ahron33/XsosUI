using System;
using System.Threading;
using System.Windows.Forms;

namespace Xsos
{
    class Functions
    {
        public static string exploitdllname = Xsos.MainForm.drivepath + "XsosV2" + "\\Xsos.dll";
        public static void Inject()
        {
            if (NamedPipes.NamedPipeExist(NamedPipes.luapipename))
            {
                MessageBox.Show("Xsos Already Hooked", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            else if (!NamedPipes.NamedPipeExist(NamedPipes.luapipename))
            {
                switch (Injector.DllInjector.GetInstance.Inject("RobloxPlayerBeta"))
                {
                    case Injector.DllInjectionResult.DllNotFound:
                        MessageBox.Show("Couldn't Find Xsos.dll, Your Antivirus Is Blocking Xsos Files!", "Dll Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    case Injector.DllInjectionResult.GameProcessNotFound:
                        MessageBox.Show("Please Open RobloxPlayerBeta.exe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    case Injector.DllInjectionResult.InjectionFailed:
                        MessageBox.Show("Hooked Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }
                if (!NamedPipes.NamedPipeExist(NamedPipes.luapipename))
                {
                }
            }
        }
    }
}
