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
 * Version 0.3: Added disposing of images and fixed memory leak by initiating main images list only once.
 * Revision 0.3: Added versioning from GitHub commits. 
 * Revision 0.4: Added animation to Shuffle.
 * Revision 0.5: Changed Shuffle animation into a much smoother and better one. 
 * 
 */

using System;
using System.Threading.Tasks;
using AutoGenerated;

namespace Story_Prompt_Generator
{
    public partial class Form1 : Form
    {
        List<Image> images = new List<Image>();
        List<Image> imgList = new List<Image>();
        List<PictureBox> pBoxList = new List<PictureBox>();
        List<Label> LabelList = new List<Label>();

        int LabelWidth = 200;
        int LabelHeight = 200;
        int pBoxWidth;
        int pBoxHeight;

        string[] REVISION = { "0.5", $"{CommitInfo.CommitCount}" };
        string VERSION => String.Format("Revision {0} Version {1}", REVISION);

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
        private void InitPicBoxes()
        {
            pBoxList.Clear();
            LabelList.Clear();
            pBoxHeight = LabelWidth - 2;
            pBoxWidth = LabelWidth - 2;

            for (int i = 0; i < udNumPicBoxes.Value; i++)
            {
                var pictureBox = new PictureBox();
                var label = new Label();

                pictureBox.Size = new Size(pBoxWidth, pBoxHeight);
                label.Size = new Size(LabelWidth, LabelHeight);

                pBoxList.Add(pictureBox);
                LabelList.Add(label);

                Controls.Add(pictureBox);
                Controls.Add(label);
            }

            LabelList[0].Top = 72;
            LabelList[0].BackColor = Color.White;
            LabelList[0].Left = 12;
            LabelList[0].FlatStyle = FlatStyle.Flat;
            LabelList[0].BorderStyle = BorderStyle.FixedSingle;
            pBoxList[0].Top = 73;
            pBoxList[0].Left = 13;
            pBoxList[0].BackColor = Color.White;
            pBoxList[0].BackgroundImageLayout = ImageLayout.Zoom;

            for (int i = 1; i < LabelList.Count; i++)
            {
                LabelList[i].BackColor = Color.White;
                LabelList[i].Visible = true;
                LabelList[i].Top = LabelList[i - 1].Top;
                LabelList[i].Left = LabelList[i - 1].Left + 206;
                LabelList[i].FlatStyle = FlatStyle.Flat;
                LabelList[i].BorderStyle = BorderStyle.FixedSingle;
                pBoxList[i].BackColor = Color.White;
                pBoxList[i].Top = pBoxList[i - 1].Top;
                pBoxList[i].Left = pBoxList[i - 1].Left + 206;
                pBoxList[i].BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        private void NullPicBoxes()
        {
            for (int i = 0; i < udNumPicBoxes.Value; i++)
            {
                pBoxList[i].BackgroundImage = null;
            }
        }
        private void ResetImages()
        {
            images.Clear();
            images = images.Concat(imgList).ToList();

            NullPicBoxes();

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
        private async void FlipFlip()
        {
            btnShuffle.Enabled = false;
            List<Image> pics = new List<Image>();
            Random random = new Random();

            for (int i = 0; i < pBoxList.Count; i++)
            {
                if (pBoxList[i].BackgroundImage != null) { pics.Add(pBoxList[i].BackgroundImage); }
            }

            var shuffledimages = pics.OrderBy(_ => random.Next()).ToList();

            if (shuffledimages.Count >= pBoxList.Count)
            {
                if (chkAnimate.Checked)
                {
                    var tasks = new List<Task>();
                    for (int i = 0; i < pBoxList.Count; i++)
                    {
                        tasks.Add(ZoomInOut(pBoxList[i], shuffledimages[i]));
                    }
                    await Task.WhenAll(tasks);
                }
                else
                {
                    NullPicBoxes();
                    SetpBoxImage(shuffledimages);
                }

                shuffledimages.Clear();
                pics.Clear();
                btnShuffle.Enabled = true;
            }
        }
        private void SetpBoxImage(List<Image> imgs)
        {
            for (int i = 0; i < imgs.Count; i++)
            {
                pBoxList[i].BackgroundImage = imgs[i];
            }
        }
        private async void SetImages()
        {
            btnRoll.Enabled = false;
            btnRoll.BackgroundImage?.Dispose();
            btnRoll.BackgroundImage = Properties.Resources.btnRandomize_disabled;

            ResetImages();

            var tasks = new List<Task>();
            for (int i = 0; i < pBoxList.Count; i++)
            {
                tasks.Add(GetRandomImage(pBoxList[i]));
            }
            await Task.WhenAll(tasks);

            btnRoll.Enabled = true;
            btnRoll.BackgroundImage?.Dispose();
            btnRoll.BackgroundImage = Properties.Resources.btnRandomize_up;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            InitPicBoxes();
            SetImages();
            lblVersion.Text = VERSION;
            Size = new Size(854, 319);
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            SetImages();
        }
        private void btnRoll_MouseDown(object sender, MouseEventArgs e)
        {
            btnRoll.BackgroundImage?.Dispose();
            btnRoll.BackgroundImage = Properties.Resources.btnRandomize_down;
        }        
        private async Task ZoomInOut(PictureBox pic, Image img)
        {
            int zoomFactor = 16;
            int speed = 10;
            int origWidth = pic.Width;
            int origHeight = pic.Height;
            int origLeft = pic.Left;
            int origTop = pic.Top;

            

            // Zoom out
            for (int i = 0; i < zoomFactor; i++)
            {
                pic.Width -= speed;
                pic.Height -= speed;
                pic.Left += speed / 2;
                pic.Top += speed / 2;
                await Task.Delay(10);
            }

            pic.BackgroundImage = img;

            // Zoom in
            for (int i = 0; i < zoomFactor; i++)
            {
                pic.Width += speed;
                pic.Height += speed;
                pic.Left -= speed / 2;
                pic.Top -= speed / 2;
                await Task.Delay(10);
            }

            // Restore original size and position
            pic.Width = origWidth;
            pic.Height = origHeight;
            pic.Left = origLeft;
            pic.Top = origTop;
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            FlipFlip();
        }
    }
}
