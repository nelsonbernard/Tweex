using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Windows.Storage;
using Windows.System.UserProfile;
using Windows.UI.Popups;

namespace Tweex
{
    public partial class Form1 : Form
    {
        MachineInfo machineInfo = new MachineInfo();
        OperatingSystem os = Environment.OSVersion;
        

        private const int SPI_SETSCREENSAVERTIMEOUT = 15;
        private const int SPIF_SENDWININICHANGE = 2;
        private const int SPI_SETSCREENSAVERACTIVE = 17;

        public Form1()
        {
            InitializeComponent();
            // loadData();
        }

        /*private void loadData()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Processor Type");
            table.Columns.Add("Series");
            table.Columns.Add("Price");

            using (StreamReader sr = new StreamReader(@"PriceGuide.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string[] parts = sr.ReadLine().Split(',');
                    table.Rows.Add(parts[0], parts[1], "$" + parts[2]);
                }
            }

            priceGridView.DataSource = table;
        }*/

        public void loadGraphics()
        {
            Image background = Image.FromFile(Application.StartupPath + @"\Resources\testbackground.jpg");
            StreamReader sr = new StreamReader(@"IncludedSoftware.txt");

            int specsX, specsY, specsWidth, specsHeight = 0;
            int softwareX, softwareY, softwareWidth, softwareHeight = 0;
            string strWebcam = "";
            string strTouchscreen = "";

            specsX = softwareX = (int)(background.Width * .60);
            specsY = 20;
            specsHeight = (int)(background.Height * .26);
            specsWidth = softwareWidth = background.Width - softwareX;
            softwareY = specsHeight - 10;
            softwareHeight = background.Height - softwareY;

            if (checkBoxWebcam.Checked && checkBoxTouchscreen.Checked)
            {
                strWebcam = "Webcam";
                strTouchscreen = " / Touchscreen";
            }
            else if (checkBoxWebcam.Checked)
                strWebcam = "Webcam";
            else if (checkBoxTouchscreen.Checked)
                strTouchscreen = "Touchscreen";

            Rectangle rectSpecs = new Rectangle(specsX, specsY, specsWidth, specsHeight);
            Rectangle rectSoftware = new Rectangle(softwareX, softwareY, softwareWidth, softwareHeight);
            Graphics g = Graphics.FromImage(background);
            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            g.DrawString(textBoxOSVersion.Text + "\n" + textBoxMake.Text + "\n" + textBoxModel.Text + "\n" + textBoxCPU.Text + "\n" + textBoxMemory.Text + " RAM\n" + textBoxHDD.Text + " HDD\n" + textBoxVideo.Text + "\n" + strWebcam + strTouchscreen, new Font("Helvetica", 21, FontStyle.Bold), Brushes.Black, rectSpecs, sf);
            g.DrawString(sr.ReadToEnd(), new Font("Helvetica", 17), Brushes.Black, rectSoftware, sf);
            g.Flush();

            pictureBoxBackdrop.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBackdrop.Image = background;
            pictureBoxBackdrop.Image.Save(Application.StartupPath + @"\Resources\BackgroundDefault.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

            g.Dispose();
            sr.Close();
        }

        public void setTheme()
        {
            string strSource = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            strSource = Path.Combine(strSource, "Resources\\DicksPawn.themepack");
            string strThemePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            strThemePath = Path.Combine(strThemePath, "Resources\\ThemeTool.exe");

            if (os.Version.Major >= 6 && os.Version.Minor > 1)
            {
                System.Diagnostics.Process.Start(strSource);
            }
            else
            {
                System.Diagnostics.Process.Start(strThemePath, " changetheme " + strSource);
            }

        }

        public void setUserProfilePicture()
        {
            if (os.Version.Major >= 6 && os.Version.Minor > 1)
            {
                /*StorageFolder folder = await StorageFolder.GetFolderFromPathAsync(Application.StartupPath + @"\Resources");
                StorageFile file = await folder.GetFileAsync(@"user.bmp");
                SetAccountPictureResult result = await UserInformation.SetAccountPictureAsync(file);*/
                /*string strSystemDirectory = Environment.ExpandEnvironmentVariables(@"%ProgramData%\Microsoft\User Account Pictures");

                DirectoryInfo dir = new System.IO.DirectoryInfo(strSystemDirectory);
                dir.Attributes = dir.Attributes & ~System.IO.FileAttributes.ReadOnly;

                string strSource = Application.StartupPath + @"\Resources\user.bmp";
                string strDestination = Environment.ExpandEnvironmentVariables(@"%programdata%\Microsoft\User Account Pictures\user.bmp");
                string strBackupFilename = "user.bak";

                File.Replace(strSource, strDestination, strBackupFilename);*/
               
                /*if(UserInformation.AccountPictureChangeEnabled == true)
                {
                    if (result == SetAccountPictureResult.Success)
                    {
                        MessageDialog messageDialog = new MessageDialog("Set account picture successfully", "OK");
                        //await messageDialog.ShowAsync();
                    }
                    else
                    {
                        MessageDialog messageDialog = new MessageDialog("Error: Could not set account picture", "OK");
                        //await messageDialog.ShowAsync();
                    }
                }
                else
                {
                    MessageDialog messageDialog = new MessageDialog("Error: Account picture changes are not enabled in system settings", "Warning");
                    MessageBox.Show("Error: Account picture changes are not enabled in system settings", "OK");
                }*/
            }
            else
            {
                string strSource = Application.StartupPath + @"\Resources\user.bmp";
                string strDestination = Environment.ExpandEnvironmentVariables(@"%programdata%\Microsoft\User Account Pictures\user.bmp");

                File.Copy(strSource, strDestination, true);
            }
        }

        public async void setLockScreen()
        {
            if (os.Version.Major >= 6 && os.Version.Minor > 1)
            {
                StorageFolder folder = await StorageFolder.GetFolderFromPathAsync(Application.StartupPath + @"\Resources");
                StorageFile file = await folder.GetFileAsync(@"BackgroundDefault.jpg");
                await LockScreen.SetImageFileAsync(file);
            }
            else
            {
                string path = Environment.ExpandEnvironmentVariables(@"%system32%\oobe\info\backgrounds");

                if (!Directory.Exists(path))
                {
                    DirectoryInfo di = new DirectoryInfo(path);
                }

                string BackgroundDefault = Path.Combine(path, @"\BackgroundDefault.jpg");

                if (File.Exists(BackgroundDefault))
                {
                    if ((File.GetAttributes(BackgroundDefault) & System.IO.FileAttributes.ReadOnly) == System.IO.FileAttributes.ReadOnly)
                        File.SetAttributes(BackgroundDefault, System.IO.FileAttributes.Normal);
                }

                Process regeditProcess = Process.Start("regedit.exe", "/s \"" + @"Resources\customBackground.reg");
                regeditProcess.WaitForExit();

                try
                {
                    File.Copy((Application.StartupPath + @"\Resources\BackgroundDefault.jpg"), BackgroundDefault, true);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Error setting custom background", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }

        }

        /// <summary>A simple <see cref="System.Collections.Generic.IEqualityComparer&lt;string&gt;"/>
        /// implementation to support a case insensitive comparison of registry values.</summary>
        internal class RegKeyComparer : IEqualityComparer<string>
        {
            public bool Equals(string x, string y)
            {
                return string.Compare(x, y, StringComparison.InvariantCultureIgnoreCase) == 0;
            }

            public int GetHashCode(string obj)
            {
                return (obj as string).GetHashCode();
            }
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern bool SystemParametersInfo(int uAction, int uParam, ref int lpvParam, int flags);

        public static void setScreenSaver(Int32 Value, int Active)
        {

            int nullVar = 0;

            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);

            if (key == null)
            {
                Registry.CurrentUser.CreateSubKey(@"Control Panel\Desktop");
            }

            key.SetValue("ScreenSaverIsSecure", 1, RegistryValueKind.String);
            SystemParametersInfo(SPI_SETSCREENSAVERACTIVE, Active, ref nullVar, SPIF_SENDWININICHANGE);  // 0 to deactivate, 1 to enable screensaver
            SystemParametersInfo(SPI_SETSCREENSAVERTIMEOUT, Value, ref nullVar, SPIF_SENDWININICHANGE);
        }

        private void buttonGatherInfo_Click_1(object sender, EventArgs e)
        {
            textBoxMake.Text = machineInfo.Make;
            textBoxModel.Text = machineInfo.Model;
            textBoxCPU.Text = machineInfo.CPU;
            textBoxMemory.Text = machineInfo.RAM;
            textBoxHDD.Text = machineInfo.HDD;
            checkBoxTouchscreen.Checked = machineInfo.TouchScreen;
            checkBoxWebcam.Checked = machineInfo.Webcam;
            textBoxVideo.Text = machineInfo.Video;
            textBoxOSVersion.Text = machineInfo.OSVersion;
            //textBoxPrice.Text = "$" + machineInfo.Price.ToString() + ".00";
            buttonPreview.Enabled = true;
        }

        private void buttonPreview_Click(object sender, EventArgs e)
        {
            loadGraphics();
            buttonExecute.Enabled = true;
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            
            //setUserProfilePicture();
            setLockScreen();
            setTheme();
            setScreenSaver(60, 0);
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(cboxTheme.SelectedItem.ToString() == "Browse...")
            {
                openFileDialog1.InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString();
                openFileDialog1.Filter = "Themepack Files (*.themepack)|*.themepack*|Theme Files (*.theme)|*.theme*";
                openFileDialog1.ShowDialog();
            }
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            cboxTheme.SelectedItem = openFileDialog1.SafeFileName.ToString();
        }
    }
}
