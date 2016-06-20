using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NReco.VideoConverter;
using System.IO;


namespace FrameExtactor
{
    public partial class MainFrom : Form
    {
        public MainFrom()
        {
            InitializeComponent();
        }

        private void MainFrom_Load(object sender, EventArgs e)
        {
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tbVideo.Text = ofd.FileName;
            }
        }

        private void btnDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                tboutdir.Text = fbd.SelectedPath;
            }
        }

        private void btnGetFrames_Click(object sender, EventArgs e)
        {
            string inputPath = tbVideo.Text;
            string outputPath = tboutdir.Text;
            
            try
            {

                if (inputPath != null && outputPath != null)
                {
                    float duration = GetVideoDuration(inputPath);
                    FFMpegConverter ffmegc = new FFMpegConverter();
                    float frameTime = 0.3f;
                    int counter = 1;
                    while (frameTime <= duration)
                    {
                        string img = Path.Combine(outputPath, string.Format("frame{0}.jpg", counter));
                        ffmegc.GetVideoThumbnail(inputPath, img, frameTime);
                        counter++;
                        frameTime += 0.3f;
                        Image pic = resizeImage(new Bitmap(img), new Size(293, 163));
                        picBox.Image = new Bitmap(pic);
                    }
                }
            }
            catch (FFMpegException ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private float GetVideoDuration(string videosource)
        {
            var ffProbe = new NReco.VideoInfo.FFProbe();
            var videoInfo = ffProbe.GetMediaInfo(videosource);
            double duration = videoInfo.Duration.TotalSeconds;
            float f_duration = (float)duration;
            return f_duration;
        }


        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }
    }
}
