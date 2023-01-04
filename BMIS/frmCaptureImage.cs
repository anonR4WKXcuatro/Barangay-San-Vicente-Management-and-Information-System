using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BMIS
{
    public partial class frmCaptureImage : Form
    {
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice VideoDevices;
        public frmCaptureImage()
        {
            InitializeComponent();
            cameraList();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        //To round border.
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );

        void cameraList()
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Devices in CaptureDevice)
            {
                cboCameraList.Items.Add(Devices.Name);
            }
        }


        private void NewVideoFrame(Object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

       


        private void btnCapture_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox2.Image = (Bitmap)pictureBox1.Image.Clone();
            }
            else
            {
                MessageBox.Show("There's no running camera device!", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Title = "Save Image As";
            fileDialog.Filter = "Image files (*.jpg, *.png) | *.jpg; *.png";
            ImageFormat imageFormat = ImageFormat.Png;

            if (pictureBox2.Image != null)
            {
                if (fileDialog.ShowDialog().Equals(DialogResult.OK))
                {
                    string ext = System.IO.Path.GetExtension(fileDialog.FileName);
                    switch (ext)
                    {
                        case ".jpg":
                            imageFormat = ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            imageFormat = ImageFormat.Bmp;
                            break;

                    }
                    pictureBox2.Image.Save(fileDialog.FileName, imageFormat);
                    MessageBox.Show("Image saved successfully!", "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("There's no image to save!", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (VideoDevices.IsRunning == true)
            {
                VideoDevices.Stop();

            }
            this.Dispose();
        }

        private void frmCaptureImage_Load(object sender, EventArgs e)
        {
            try
            {
                VideoDevices = new VideoCaptureDevice(CaptureDevice[cboCameraList.SelectedIndex = 0].MonikerString);
                VideoDevices.NewFrame += new NewFrameEventHandler(NewVideoFrame);
                VideoDevices.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a camera device!", "Notice", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
    }
}
