using System;
using System.Windows.Forms;

namespace BMIS
{
    public partial class frmLoadingScreen : Form
    {
        private frmMainWindow mainWindow = new frmMainWindow();
        public frmLoadingScreen()
        {
            InitializeComponent();
        }

        private void loadingTime_Tick(object sender, EventArgs e)
        {
            panel1.Width += 10;
            if (panel1.Width >= 900)
            {
                loadingTime.Stop();
                this.Dispose();
                mainWindow.Show();

                mainWindow.btnDashboardEffect();
            }
        }
    }
}
