using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Net.FreeORM.ZZZ_TestAppWFA
{
    public partial class TutorialCreatingASlideViewerWithRadRotator : Telerik.WinControls.UI.RadForm
    {
        public TutorialCreatingASlideViewerWithRadRotator()
        {
            InitializeComponent();
            radRotator1.BeginRotate += new BeginRotateEventHandler(radRotator1_BeginRotate);
        }

        private void TutorialCreatingASlideViewerWithRadRotator_Load(object sender, EventArgs e)
        {

            string myPicturesPath = "E:/HD";//Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            foreach (string fileName in Directory.GetFiles(myPicturesPath, "*.jpg"))
            {
                radRotator1.Items.Add(GetThumbNail(fileName));
            }
            radRotator1.Start(true);
            radRotator1.ShouldStopOnMouseOver = false;

        }
        private RadImageItem GetThumbNail(string path)
        {
            RadImageItem imageItem = new RadImageItem();
            Image image = Image.FromFile(path);
            // workaround to prevent using internal image thumbnail
            image.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone);
            image.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone);
            // calculate aspect ratio so image is not distorted
            double ratio = 0;
            if (image.Width > image.Height)
            {
                ratio = ClientRectangle.Width / image.Width;
            }
            else
            {
                ratio = ClientRectangle.Height / image.Height;
            }
            int newWidth = (int)(image.Width * ratio);
            int newHeight = (int)(image.Height * ratio);
            imageItem.Image = image.GetThumbnailImage(newWidth, newHeight, null, IntPtr.Zero);
            return imageItem;
        }

        void radRotator1_BeginRotate(object sender, BeginRotateEventArgs e)
        {
            radLabel1.Text = String.Format("Rotating from item {0} to {1}", e.From, e.To);
        }
    }
}
