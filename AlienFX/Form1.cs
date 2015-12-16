using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using LightFX;

namespace AlienFX
{

    public partial class Form1 : Form
    {
        Object lockObject = new Object();

        NotifyIcon mynotifyicon;

        AlienFXControl control;
        ScreenControl screenControl;
        System.Timers.Timer timer;
        DateTime time;

        int startX, stopX, startY, stopY;
        int steps;

        Thread oThread;
        int availableThreads;
        int maxThreads;
        int temp;

        public Form1()
        {
            InitializeComponent();

            mynotifyicon = new NotifyIcon();
            mynotifyicon.Icon = new Icon(SystemIcons.Application, 40, 40);
            mynotifyicon.MouseDoubleClick += new MouseEventHandler(mynotifyicon_MouseDoubleClick);
            ContextMenu contextMenu = new ContextMenu();
            contextMenu.MenuItems.Add(0,
                new MenuItem("Show", new System.EventHandler(tray_Show_Click)));
            contextMenu.MenuItems.Add(1,
                new MenuItem("Exit", new System.EventHandler(tray_Exit_Click)));
            mynotifyicon.ContextMenu = contextMenu;
            mynotifyicon.Visible = false;
        }

        private void tray_Show_Click(object sender, EventArgs e)
        {
            restore();
        }

        private void tray_Exit_Click(object sender, EventArgs e)
        {
            mynotifyicon.Dispose();
            Close();
        }

        private void OnTimedEvent(object source, System.Timers.ElapsedEventArgs e)
        {
            lock (lockObject)
            {
                System.Threading.ThreadPool.GetAvailableThreads(out availableThreads, out temp);
                System.Threading.ThreadPool.GetMaxThreads(out maxThreads, out temp);
                if (maxThreads - availableThreads > 5)
                {
                    numericUpDownRefreshRate.Invoke((MethodInvoker)delegate
                    {
                        timer.Interval++;
                        numericUpDownRefreshRate.Value++;
                        Properties.Settings.Default.RefreshRate++;
                    });
                    return;
                }

                // Console.WriteLine((DateTime.Now - time).Milliseconds);
                time = DateTime.Now;
                control.setColor(screenControl.calcAverageColor());
            }
        }

        private void buttonStartAmbilight_Click(object sender, EventArgs e)
        {
            if (radioButtonCustomResolution.Checked)
            {
                if ((int)numericUpDownTopLeftX.Value > Screen.PrimaryScreen.Bounds.Width || (int)numericUpDownTopLeftY.Value > Screen.PrimaryScreen.Bounds.Height || (int)numericUpDownBottomRightX.Value > Screen.PrimaryScreen.Bounds.Width || (int)numericUpDownBottomRightY.Value > Screen.PrimaryScreen.Bounds.Height)
                {
                    labelStatus.Text = "values to big!";
                    labelStatus.ForeColor = Color.Red;
                    return;
                }
            }

            labelStatus.Text = "starting...";
            labelStatus.ForeColor = Color.Black;

            control = new AlienFXControl();
            screenControl = new ScreenControl();

            if (control.initialize())
            {
                startX = (int)numericUpDownTopLeftX.Value;
                stopX = (int)numericUpDownBottomRightX.Value;
                startY = (int)numericUpDownTopLeftY.Value;
                stopY = (int)numericUpDownBottomRightY.Value;

                steps = (int)numericUpDownQuality.Value;

                if (radioButtonCustomResolution.Checked)
                {
                    screenControl.calculatePixels(startX, stopX, startY, stopY, steps, steps);
                }
                else if (radioButton_235_100_ratio.Checked)
                {
                    startX = 0;
                    stopX = Screen.PrimaryScreen.Bounds.Width;
                    startY = ((int) (Screen.PrimaryScreen.Bounds.Height - (Screen.PrimaryScreen.Bounds.Width / 2.35)) / 2);
                    stopY = Screen.PrimaryScreen.Bounds.Height - startY;

                    screenControl.calculatePixels(startX, stopX, startY, stopY, steps, steps);
                } else
                {
                    screenControl.calculatePixels(steps, steps);
                }

                timer.Interval = (int)numericUpDownRefreshRate.Value;
                timer.Enabled = true;

                labelStatus.Text = "Running!";
                labelStatus.ForeColor = Color.Green;
            }
            else
            {
                labelStatus.Text = "Error!";
                labelStatus.ForeColor = Color.Red;
            }
        }

        private void buttonStopAmbilight_Click(object sender, EventArgs e)
        {
            try
            {
                if (oThread != null && oThread.IsAlive)
                {
                    oThread.Abort();
                }
                oThread = null;
                timer.Enabled = false;
                control.release();
                labelStatus.Text = "Stopped...";
                labelStatus.ForeColor = Color.Black;
            }
            catch
            {
                labelStatus.Text = "Error!";
                labelStatus.ForeColor = Color.Red;
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.StartMinimized)
            {
                minimizeToTray(false);
            }

            checkBox_startMinimized.Checked = Properties.Settings.Default.StartMinimized;
            checkBox_startAutomatically.Checked = Properties.Settings.Default.StartAutomatically;

            radioButtonFullscreen.Checked = Properties.Settings.Default.Fullscreen;
            radioButtonCustomResolution.Checked = Properties.Settings.Default.CustomResolution;
            radioButton_235_100_ratio.Checked = Properties.Settings.Default.cinemaRatio;
            numericUpDownTopLeftX.Value = Properties.Settings.Default.TopLeftX;
            numericUpDownTopLeftY.Value = Properties.Settings.Default.TopLeftY;
            if (Properties.Settings.Default.BottomRightX == 0)
            {
                Properties.Settings.Default.BottomRightX = Screen.PrimaryScreen.Bounds.Width;
                numericUpDownBottomRightX.Value = Properties.Settings.Default.BottomRightX;
            }
            else
            {
                numericUpDownBottomRightX.Value = Properties.Settings.Default.BottomRightX;
            }

            if (Properties.Settings.Default.BottomRightY == 0)
            {
                Properties.Settings.Default.BottomRightY = Screen.PrimaryScreen.Bounds.Height;
                numericUpDownBottomRightY.Value = Properties.Settings.Default.BottomRightY;
            }
            else
            {
                numericUpDownBottomRightY.Value = Properties.Settings.Default.BottomRightY;
            }

            numericUpDownQuality.Value = Properties.Settings.Default.Quality;
            numericUpDownRefreshRate.Value = Properties.Settings.Default.RefreshRate;

            timer = new System.Timers.Timer();
            timer.Elapsed += new System.Timers.ElapsedEventHandler(OnTimedEvent);
            timer.Enabled = false;

            if (Properties.Settings.Default.StartAutomatically)
            {
                buttonStartAmbilight_Click(null, null);
            }
        }

        private void radioButtonCustomResolution_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCustomResolution.Checked)
            {
                radioButtonFullscreen.Checked = false;
                radioButton_235_100_ratio.Checked = false;
            }
            Properties.Settings.Default.Fullscreen = radioButtonFullscreen.Checked;
            Properties.Settings.Default.CustomResolution = radioButtonCustomResolution.Checked;
            Properties.Settings.Default.cinemaRatio = radioButton_235_100_ratio.Checked;
        }

        private void radioButtonFullscreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFullscreen.Checked)
            {
                radioButtonCustomResolution.Checked = false;
                radioButton_235_100_ratio.Checked = false;
            }
            Properties.Settings.Default.Fullscreen = radioButtonFullscreen.Checked;
            Properties.Settings.Default.CustomResolution = radioButtonCustomResolution.Checked;
            Properties.Settings.Default.cinemaRatio = radioButton_235_100_ratio.Checked;
        }

        private void numericUpDownTopLeftX_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.TopLeftX = numericUpDownTopLeftX.Value;
        }

        private void numericUpDownTopLeftY_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.TopLeftY = numericUpDownTopLeftY.Value;
        }

        private void numericUpDownBottomRightX_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.BottomRightX = numericUpDownBottomRightX.Value;
        }

        private void numericUpDownBottomRightY_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.BottomRightY = numericUpDownBottomRightY.Value;
        }

        private void numericUpDownQuality_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Quality = numericUpDownQuality.Value;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Properties.Settings.Default.Save();

                if (oThread != null && oThread.IsAlive)
                {
                    oThread.Abort();
                }
                oThread = null;
                control.release();
                labelStatus.Text = "Stopped...";
                labelStatus.ForeColor = Color.Black;

                mynotifyicon.Dispose();
            }
            catch
            {
                labelStatus.Text = "Error!";
                labelStatus.ForeColor = Color.Red;
            }
        }

        private void numericUpDownRefreshRate_ValueChanged(object sender, EventArgs e)
        {
            if (timer != null)
            {
                timer.Interval = (int)numericUpDownRefreshRate.Value;
            }
            Properties.Settings.Default.RefreshRate = numericUpDownRefreshRate.Value;
        }

        private void checkBox_startAutomatically_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.StartAutomatically = checkBox_startAutomatically.Checked;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                minimizeToTray(true);
            }
        }

        private void minimizeToTray(Boolean showTip)
        {
            WindowState = FormWindowState.Minimized;
            mynotifyicon.Visible = true;
            this.ShowInTaskbar = false;
        }

        private void mynotifyicon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            restore();
        }

        private void restore()
        {
            WindowState = FormWindowState.Normal;
            mynotifyicon.Visible = false;
            this.ShowInTaskbar = true;
        }

        private void checkBox_startMinimized_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.StartMinimized = checkBox_startMinimized.Checked;
        }

        private void radioButton_235_100_ratio_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_235_100_ratio.Checked)
            {
                radioButtonCustomResolution.Checked = false;
                radioButtonFullscreen.Checked = false;
            }
            Properties.Settings.Default.Fullscreen = radioButtonFullscreen.Checked;
            Properties.Settings.Default.CustomResolution = radioButtonCustomResolution.Checked;
            Properties.Settings.Default.cinemaRatio = radioButton_235_100_ratio.Checked;
        }
    }
}
