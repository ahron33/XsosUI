using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScintillaNET;

namespace Xsos
{
    public partial class MainForm : Form
    {
        //strings
        WebClient web = new WebClient();
        public static string drivepath = ""; //drivepath
        public static string oldpath = Application.StartupPath; //start path (oldpath)
        public static string fade = "1";
        public static string Move = "false";
        string[] files = null;
        //

        public MainForm()
        {
            try
            {
                InitializeComponent();
            }
            catch { }
        }

        public void Scantilla()
        {
            txtbox.DragDrop += txtbox_DragDrop;
            var alphaChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var numericChars = "0123456789";
            var accentedChars = "ŠšŒœŸÿÀàÁáÂâÃãÄäÅåÆæÇçÈèÉéÊêËëÌìÍíÎîÏïÐðÑñÒòÓóÔôÕõÖØøÙùÚúÛûÜüÝýÞþßö";
            txtbox.AllowDrop = true;
            txtbox.StyleResetDefault();
            txtbox.Styles[Style.Default].Font = "Consolas";
            txtbox.Styles[Style.Default].Size = 10;
            txtbox.StyleClearAll();
            txtbox.Styles[Style.Lua.Default].ForeColor = Color.Silver;
            txtbox.Styles[Style.Lua.Comment].ForeColor = Color.Green;
            txtbox.Styles[Style.Lua.CommentLine].ForeColor = Color.Green;
            txtbox.Styles[Style.Lua.Number].ForeColor = Color.Olive;
            txtbox.Styles[Style.Lua.Word].ForeColor = Color.Blue;
            txtbox.Styles[Style.Lua.Word2].ForeColor = Color.BlueViolet;
            txtbox.Styles[Style.Lua.Word3].ForeColor = Color.DarkSlateBlue;
            txtbox.Styles[Style.Lua.Word4].ForeColor = Color.DarkSlateBlue;
            txtbox.Styles[Style.Lua.String].ForeColor = Color.Red;
            txtbox.Styles[Style.Lua.Character].ForeColor = Color.Red;
            txtbox.Styles[Style.Lua.LiteralString].ForeColor = Color.Red;
            txtbox.Styles[Style.Lua.StringEol].BackColor = Color.Pink;
            txtbox.Styles[Style.Lua.Operator].ForeColor = Color.Purple;
            txtbox.Styles[Style.Lua.Preprocessor].ForeColor = Color.Maroon;
            txtbox.Lexer = Lexer.Lua;
            txtbox.WordChars = alphaChars + numericChars + accentedChars;
            txtbox.SetKeywords(0, "and break do else elseif end false for function if in local nil not or repeat return then true until while");
            txtbox.SetKeywords(1, "warn CFrame CFrame.fromEulerAnglesXYZ Synapse Decompile Synapse Copy Synapse Write CFrame.Angles CFrame.fromAxisAngle CFrame.new gcinfo os os.difftime os.time tick UDim UDim.new Instance Instance.Lock Instance.Unlock Instance.new pairs NumberSequence NumberSequence.new assert tonumber getmetatable Color3 Color3.fromHSV Color3.toHSV Color3.fromRGB Color3.new load Stats _G UserSettings Ray Ray.new coroutine coroutine.resume coroutine.yield coroutine.status coroutine.wrap coroutine.create coroutine.running NumberRange NumberRange.new PhysicalProperties Physicalnew printidentity PluginManager loadstring NumberSequenceKeypoint NumberSequenceKeypoint.new Version Vector2 Vector2.new wait game. game.Players game.ReplicatedStorage Game delay spawn string string.sub string.upper string.len string.gfind string.rep string.find string.match string.char string.dump string.gmatch string.reverse string.byte string.format string.gsub string.lower CellId CellId.new Delay version stats typeof UDim2 UDim2.new table table.setn table.insert table.getn table.foreachi table.maxn table.foreach table.concat table.sort table.remove settings LoadLibrary require Vector3 Vector3.FromNormalId Vector3.FromAxis Vector3.new Vector3int16 Vector3int16.new setmetatable next ypcall ipairs Wait rawequal Region3int16 Region3int16.new collectgarbage game newproxy Spawn elapsedTime Region3 Region3.new time xpcall shared rawset tostring print Workspace Vector2int16 Vector2int16.new workspace unpack math math.log math.noise math.acos math.huge math.ldexp math.pi math.cos math.tanh math.pow math.deg math.tan math.cosh math.sinh math.random math.randomseed math.frexp math.ceil math.floor math.rad math.abs math.sqrt math.modf math.asin math.min math.max math.fmod math.log10 math.atan2 math.exp math.sin math.atan ColorSequenceKeypoint ColorSequenceKeypoint.new pcall getfenv ColorSequence ColorSequence.new type ElapsedTime select Faces Faces.new rawget debug debug.traceback debug.profileend debug.profilebegin Rect Rect.new BrickColor BrickColor.Blue BrickColor.White BrickColor.Yellow BrickColor.Red BrickColor.Gray BrickColor.palette BrickColor.New BrickColor.Black BrickColor.Green BrickColor.Random BrickColor.DarkGray BrickColor.random BrickColor.new setfenv dofile Axes Axes.new error loadfile ");
            txtbox.SetKeywords(2, "getgenv getreg() endscript changereadonly setclipboard clipboard.set toclipboard setupvalue getupvalue proto get_nil_instances getrawmetatable get_thread_context getscriptfunc test getregistry getrenv _G setlp getlocal special console_print lproto readfile bctolua getscintillaects is_protosmasher_closure create_ebc getupvalues getlocals checkreadonly decompile is_protosmasher_func loadstring load_ebc dumpfunc shared copystr writefile bcloadstring loadfile ");
            txtbox.SetProperty("fold", "1");
            txtbox.SetProperty("fold.compact", "1");
            txtbox.Margins[2].Type = MarginType.Symbol;
            txtbox.Margins[2].Mask = Marker.MaskFolders;
            txtbox.Margins[2].Sensitive = true;
            txtbox.Margins[2].Width = 8;
            for (int i = 25; i <= 31; i++)
            {
                txtbox.Markers[i].SetForeColor(SystemColors.ControlLightLight);
                txtbox.Markers[i].SetBackColor(SystemColors.ControlDark);
            }
            // Custom
            txtbox.BackColor = Color.Black;
            txtbox.BorderStyle = BorderStyle.FixedSingle;
            txtbox.Lexer = Lexer.Lua;
            txtbox.Name = "txtbox";
            txtbox.Dock = DockStyle.None;
            txtbox.ScrollWidth = 1;
            txtbox.TabIndex = 0;
            txtbox.Styles[32].Size = 15;
            txtbox.Styles[32].Size = 15;
            txtbox.Styles[32].Size = 15;
            txtbox.SetSelectionBackColor(true, Color.FromArgb(17, 177, 255));
            txtbox.SetSelectionForeColor(true, Color.Black);
            txtbox.Margins[1].Width = -20;
            txtbox.StyleResetDefault();
            txtbox.Styles[32].Font = "Consolas";
            txtbox.Styles[32].BackColor = Color.FromArgb(35, 35, 35);
            txtbox.Styles[32].ForeColor = Color.White;
            txtbox.StyleClearAll();
            txtbox.Styles[11].ForeColor = Color.White;
            txtbox.Styles[1].ForeColor = Color.FromArgb(128, 128, 255);
            txtbox.Styles[2].ForeColor = Color.FromArgb(128, 128, 255);
            txtbox.Styles[3].ForeColor = Color.FromArgb(58, 64, 34);
            txtbox.Styles[4].ForeColor = Color.FromArgb(189, 159, 255);
            txtbox.Styles[6].ForeColor = Color.FromArgb(222, 155, 232);
            txtbox.Styles[7].ForeColor = Color.FromArgb(233, 84, 84);
            txtbox.Styles[8].ForeColor = Color.FromArgb(255, 192, 255);
            txtbox.Styles[9].ForeColor = Color.FromArgb(138, 175, 238);
            txtbox.Styles[10].ForeColor = Color.FromArgb(189, 159, 255);
            txtbox.Styles[5].ForeColor = Color.FromArgb(242, 135, 151);
            txtbox.Styles[13].ForeColor = Color.Aqua;
            txtbox.Styles[13].Bold = true;
            txtbox.Styles[14].ForeColor = Color.DeepSkyBlue;
            txtbox.Styles[14].Bold = true;
            txtbox.Lexer = Lexer.Lua;
            txtbox.SetProperty("fold", "1");
            txtbox.SetProperty("fold.compact", "1");
            txtbox.Margins[0].Width = 18;
            txtbox.Margins[1].Type = 0;
            txtbox.Margins[1].Mask = 4261412864u;
            txtbox.Margins[1].Sensitive = false;
            txtbox.Margins[1].Width = -700;
            for (int i = 25; i <= 31; i++)
            {
                txtbox.Markers[i].SetForeColor(Color.White);
                txtbox.Markers[i].SetBackColor(Color.White);
            }
            txtbox.Styles[33].BackColor = Color.FromArgb(35, 35, 35);
            txtbox.SetFoldMarginColor(true, Color.FromArgb(35, 35, 35));
            txtbox.SetFoldMarginHighlightColor(true, Color.FromArgb(35, 35, 35));
            txtbox.ScrollWidth = 1;
            txtbox.ScrollWidthTracking = true;
            txtbox.CaretForeColor = Color.White;
            txtbox.BackColor = Color.White;
            txtbox.BorderStyle = BorderStyle.None;
            txtbox.WrapIndentMode = WrapIndentMode.Fixed;
            txtbox.WrapMode = WrapMode.Word;
            txtbox.WrapVisualFlagLocation = WrapVisualFlagLocation.EndByText;
            txtbox.BorderStyle = BorderStyle.None;
            txtbox.AutomaticFold = (AutomaticFold.Show | AutomaticFold.Click | AutomaticFold.Change);

            txtbox.Text = "1";
            txtbox.Text = "";
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

        public async Task<bool> UnZipAsync()
        {
            //unzipng
            try
            {
                await Task.Delay(200);
                string zipPath = drivepath + "\\XsosV2" + "\\XsosV2.zip";
                string extractPath = oldpath + "\\";
                ZipFile.ExtractToDirectory(zipPath, extractPath);
                await Task.Delay(700);
                File.Delete(drivepath + "\\XsosV2" + "\\XsosV2.zip");
                //
                mainlbl.ForeColor = Color.DarkGreen;
                mainlbl.Text = "Xsos - Update Finished";
                MessageBox.Show("The new version was installed, It will reset the program", "XsosV2 Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Process.Start(oldpath + "\\Xsos.exe");
                await Task.Delay(200);
                Environment.Exit(0);
            }
            catch
            {
                MessageBox.Show("Can't unzip the file, For support go to ur discord server", "XsosV2 Erorr", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Environment.Exit(0);
            }
            return false;
        }

        private void DownloadCompletedAsync(object sender, AsyncCompletedEventArgs e)
        {
            //unziping the file zip
            UnZipAsync();
        }

        public async Task<bool> XYAsync()
        {
            this.Size = new Size(0, 0); //reset form size
            //YAsync();
            for (int i = 0; i <= 300; i++)
            {
                i++;
                await Task.Delay(1);
                this.Size = new Size(i, i);
                i++;
            }
            await Task.Delay(100);
            MainLoadAsync();
            return true;
        }

        public async Task<bool> MainLoadAsync()
        {
            //string
            string verP = "3";
            string verW = web.DownloadString("https://xsos.000webhostapp.com/version.txt");
            //
            if (Directory.Exists(drivepath + "\\XsosV2")) { }
            else
            {
                Directory.CreateDirectory(drivepath + "\\XsosV2");
            }
            if (File.Exists(drivepath + "\\XsosV2" + "\\Xsos.exe"))
            {
                File.Delete(drivepath + "\\XsosV2" + "\\Xsos.exe");
            }
            await Task.Delay(1000);
            //checking if there are needed updated
            if (verP == verW)
            {
                //update = false

                //deleting file
                try
                {
                    var fileCount = Directory.EnumerateFiles(drivepath + "\\XsosV2\\").Count();
                    if (fileCount == 0){ }
                    else
                    {
                        System.IO.DirectoryInfo di = new DirectoryInfo(drivepath + "\\XsosV2");
                        foreach (FileInfo file in di.GetFiles())
                        {
                            file.Delete();
                        }
                        foreach (DirectoryInfo dir in di.GetDirectories())
                        {
                            dir.Delete(true);
                        }
                    }

                    await Task.Delay(500);
                }
                catch { }
                await Task.Delay(1000);
                web.DownloadFileCompleted += DownloadCompletedDLLAsync;
                web.DownloadFileAsync(new Uri("https://xsos.000webhostapp.com/Xsos.dll"), drivepath + "\\XsosV2" + "\\Xsos.dll");
            }
            else
            {
                //update = true
                try
                {
                    mainlbl.ForeColor = Color.IndianRed;
                    mainlbl.Text = "Xsos - Update Required!";
                    await Task.Delay(500);
                    //moving files
                    File.Move("Xsos.exe", drivepath + "\\XsosV2" + "\\Xsos.exe");
                    await Task.Delay(500);
                    //downliadng
                    await Task.Delay(500);
                    try
                    {
                        web.DownloadFileCompleted += DownloadCompletedAsync;
                        web.DownloadFileAsync(new Uri("https://xsos.000webhostapp.com/XsosV2.zip"), drivepath + "\\XsosV2" + "\\XsosV2.zip");
                    }
                    catch { }
                }
                catch { }
            }
            //
            return true;
        }

        private async void DownloadCompletedDLLAsync(object sender, AsyncCompletedEventArgs e)
        {
            //Done
            Enabled = true;
            Move = "true";
            move();
            mainlbl.ForeColor = Color.Green;
            mainlbl.Text = "Xsos - Ready To Use!";
            await Task.Delay(3000);
            mainlbl.ForeColor = Color.DarkGray;
            mainlbl.Text = "Xsos";
        }

        public void move()
        {
            Move = "true";
        }

        public async Task<bool> ColorsAsync()
        {
            if (NamedPipes.NamedPipeExist(NamedPipes.luapipename))
            {
                //if the pipe is hooked
                hookbtn.BackColor = Color.FromArgb(53, 53, 53);
                await Task.Delay(3000);
                return await ColorsAsync();
            }
            else
            {
                //if not hooked
                if (fade == "1")
                {
                    //Fade in
                    for (int i = 53; i <= 183; i++)
                    {
                        await Task.Delay(15);
                        hookbtn.BackColor = Color.FromArgb(53, i, 53);
                    }
                    fade = "2";
                    return await ColorsAsync();
                }
                else
                {
                    //Fade out
                    for (int i = 183; i <= 183; i--)
                    {
                        if (i == 52)
                        {
                            i = 0;
                        }
                        else if (i == -1)
                        {
                            fade = "1";
                            return await ColorsAsync();
                        }
                        else
                        {
                            await Task.Delay(15);
                            hookbtn.BackColor = Color.FromArgb(53, i, 53);
                        }
                    }
                }
            }
            return true;
        }

        public async Task<bool> MainAsync()
        {
            Enabled = false;
            Scantilla();
            drive();
            mainlbl.ForeColor = Color.IndianRed;
            mainlbl.Text = "Xsos - Loading";
            string a = System.Reflection.Assembly.GetEntryAssembly().Location;
            if (a == Application.StartupPath + @"\Xsos.exe")
            {
                if (Process.GetProcessesByName("Xsos").Length == 1)
                {
                    XYAsync();
                    ColorsAsync();
                }
                else
                {
                    MessageBox.Show("Can't Launch Xsos, You Have Already Xsos Open", "XsosV2 Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(0);
                }
            }
            else
            {
                try
                {
                    File.Delete(Application.StartupPath + "\\Xsos.exe");
                    File.Move(a, Application.StartupPath + "\\Xsos.exe");
                }
                catch { }
                MessageBox.Show("Can't Launch Xsos, Please Reopen It", "XsosV2 Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            return false;
        }

        static bool drive()
        {
            foreach (var drive in DriveInfo.GetDrives())
            {
                drivepath = drive.ToString();
                return false;
            }
            return true;
        }
        public async Task<bool> CheckFormAsync()
        {
            if (Application.OpenForms.OfType<OptionsForm>().Any())
            {
                await Task.Delay(100);
                return await CheckFormAsync();
            }
            else
            {
                Enabled = true;
                TopMost = true;
            }
            return false;
        }

        //

        private async void MainForm_LoadAsync(object sender, EventArgs e)
        {
            MainAsync();
        }

        private void txtbox_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                txtbox.Text = File.ReadAllText(files[0]);
            }
            catch
            {
                return;
            }
        }

        private void txtbox_TextChanged(object sender, EventArgs e)
        {
            Scintilla scintilla = (Scintilla)sender;
            int length = scintilla.Lines.Count.ToString().Length;
            scintilla.Margins[0].Width = scintilla.TextWidth(10, new string('9', length + 1)) + 2;
        }

        private void mainpnl_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void xsospic_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void mainlbl_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void mainpnl_MouseDown(object sender, MouseEventArgs e)
        {
            if (Move == "true")
            {
                Drag_Form(Handle, e);
            }
            else
            { }
        }

        private void mainlbl_MouseDown(object sender, MouseEventArgs e)
        {
            if (Move == "true")
            {
                Drag_Form(Handle, e);
            }
            else
            { }
        }

        private void xsospic_MouseDown(object sender, MouseEventArgs e)
        {
            if (Move == "true")
            {
                Drag_Form(Handle, e);
            }
            else
            { }
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            DialogResult dialogResult = MessageBox.Show("Are u sure that u want to exit?"
                , "XsosV2 Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                //Clsoing form the app
                Environment.Exit(0);
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void minbtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void opnbtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Xsos - Lua Files (*.lua) |*.lua|Xsos - Text Files (*.txt) |*.txt";
                if (ofd.ShowDialog() == DialogResult.OK)

                {
                    FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(fs);
                    string cad = sr.ReadToEnd();

                    txtbox.Text = cad;

                    sr.Close();
                    fs.Close();
                    fs.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void exebtn_Click(object sender, EventArgs e)
        {
            if (NamedPipes.NamedPipeExist(NamedPipes.luapipename))
            {
                NamedPipes.LuaPipe(txtbox.Text);
                return;
            }
            else
            {
                MessageBox.Show("Hook Xsos Before Using This!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void clrbtn_Click(object sender, EventArgs e)
        {
            txtbox.Text = "";
        }

        private void hookbtn_Click(object sender, EventArgs e)
        {
            Functions.Inject();
        }

        private void txtbox_DragEnter(object sender, DragEventArgs e)
        {
            try
            {
                e.Effect = DragDropEffects.All;
                files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (Path.GetExtension(files[0]) == "SL (*.lua) |*.lua|Text Files (*.txt) |*.txt" && files.Count() == 1)
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void optionsbtn_Click(object sender, EventArgs e)
        {
            OptionsForm form = new OptionsForm();
            TopMost = false;
            Enabled = false;
            form.Show();
            CheckFormAsync();
        }

        private void xsospic_Click(object sender, EventArgs e)
        {

        }
    }
}
