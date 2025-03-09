/*
 * Story Prompt Generator
 * by Anna Vahtera 2025
 * 
 * Displays for images selected randomly from a list of included images.
 * 
 * Version history:
 * Version 0.1: Initial version
 * Version 0.2: Added "rolling" animation when randomizing results.
 * Version 0.2.1: Disabled roll button while animations are running to prevent double.images.
 * 
 */

using System;
using System.Threading.Tasks;

namespace Story_Prompt_Generator
{
    public partial class Form1 : Form
    {
        List<Image> images = new List<Image>();
        List<Image> imgList = new List<Image>();
        string VERSION = "0.2.1";

        public Form1()
        {
            InitializeComponent();
            InitImages();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void InitImages()
        {
            imgList.Clear();
            imgList.Add(Properties.Resources._001);
            imgList.Add(Properties.Resources._002);
            imgList.Add(Properties.Resources._003);
            imgList.Add(Properties.Resources._004);
            imgList.Add(Properties.Resources._005);
            imgList.Add(Properties.Resources._006);
            imgList.Add(Properties.Resources._007);
            imgList.Add(Properties.Resources._008);
            imgList.Add(Properties.Resources._009);
            imgList.Add(Properties.Resources._010);
            imgList.Add(Properties.Resources._011);
            imgList.Add(Properties.Resources._012);
            imgList.Add(Properties.Resources._013);
            imgList.Add(Properties.Resources._014);
            imgList.Add(Properties.Resources._015);
            imgList.Add(Properties.Resources._016);
            imgList.Add(Properties.Resources._017);
            imgList.Add(Properties.Resources._018);
            imgList.Add(Properties.Resources._019);
            imgList.Add(Properties.Resources._020);

        }
        private void ResetImages()
        {
            images.Clear();
            images = images.Concat(imgList).ToList();

            picOne.BackgroundImage = null;
            picTwo.BackgroundImage = null;
            picThree.BackgroundImage = null;
            picFour.BackgroundImage = null;

        }
        private async Task GetRandomImage(PictureBox pBox)
        {
            if (chkAnimate.Checked) { await RollImages(pBox); }

            Random r = new Random();
            Image img = images[r.Next(images.Count)];
            images.Remove(img);
            pBox.BackgroundImage = img;
        }
        private async Task RollImages(PictureBox pBox)
        {
            for (int i = 0; i < images.Count; i++)
            {
                pBox.Image = null;
                pBox.Image = images[i];
                await Task.Delay(10);
            }
            pBox.Image = null;
        }
        private async void SetImages()
        {
            btnRoll.Enabled = false;
            btnRoll.BackgroundImage = Properties.Resources.btnRandomize_disabled;

            ResetImages();
            await Task.WhenAll(
                GetRandomImage(picOne),
                GetRandomImage(picTwo),
                GetRandomImage(picThree),
                GetRandomImage(picFour)
            );
            btnRoll.Enabled = true;
            btnRoll.BackgroundImage = Properties.Resources.btnRandomize_up;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SetImages();
            lblVersion.Text = String.Format("Version: {0}", VERSION);
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            SetImages();
        }
        private void btnRoll_MouseDown(object sender, MouseEventArgs e)
        {
            btnRoll.BackgroundImage = Properties.Resources.btnRandomize_down;
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            btnShuffle.Enabled = false;
            List<Image> pics = new List<Image>();
            Random random = new Random();

            if (picOne.BackgroundImage != null)
                pics.Add(picOne.BackgroundImage);
            if (picTwo.BackgroundImage != null)
                pics.Add(picTwo.BackgroundImage);
            if (picThree.BackgroundImage != null)
                pics.Add(picThree.BackgroundImage);
            if (picFour.BackgroundImage != null)
                pics.Add(picFour.BackgroundImage);

            var shuffledimages = pics.OrderBy(_ => random.Next()).ToList();

            if (shuffledimages.Count >= 4)
            {
                picOne.BackgroundImage = shuffledimages[0];
                picTwo.BackgroundImage = shuffledimages[1];
                picThree.BackgroundImage = shuffledimages[2];
                picFour.BackgroundImage = shuffledimages[3];
            }
            btnShuffle.Enabled = true;
        }
    }
}
