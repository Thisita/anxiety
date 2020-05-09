using System;
using System.Drawing;
using System.Windows.Forms;

namespace anxiety
{
    public partial class FormMain : Form
    {
        private readonly Random random;
        public FormMain()
        {
            InitializeComponent();
            random = new Random();
        }

        private void DisplayWarning()
        {
            MessageBox.Show("", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        private void SetTimerWarningInterval()
        {
            int type = random.Next(3);
            int interval;
            switch(type)
            {
                case 2:
                    interval = random.Next(300, 1000);
                    break;
                case 3:
                    interval = random.Next(1000, 60000);
                    break;
                case 0:
                case 1:
                default:
                    interval = random.Next(15, 300);
                    break;
            }
            TimerWarning.Interval = interval * 100;
        }

        private void TimerWarning_Tick(object sender, EventArgs e)
        {
            TimerWarning.Enabled = false;
            TimerWarning.Stop();
            DisplayWarning();
            SetTimerWarningInterval();
            TimerWarning.Enabled = true;
            TimerWarning.Start();
        }

        private void TimerMoveEyes_Tick(object sender, EventArgs e)
        {
            TimerMoveEyes.Enabled = false;
            TimerMoveEyes.Stop();
            int x = random.Next(SystemInformation.VirtualScreen.Width);
            int y = random.Next(SystemInformation.VirtualScreen.Height);
            Location = new Point(x, y);
            TimerMoveEyes.Interval = random.Next(15, 300) * 100;
            TimerMoveEyes.Enabled = true;
            TimerMoveEyes.Start();
        }
    }
}
