using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;


namespace SquareVoice
{
    public class FileInBadLocationException : Exception
    {

    }

    public class Helpers
    {
        public string mImagesDir;
        public string mPagesDir;
        public const int MAX_ROWS = 6;
        public const int MAX_COLUMNS = 8;

        private void initPaths()
        {
            string dir = System.Environment.GetFolderPath(
                Environment.SpecialFolder.MyDocuments);
            string squareVoiceDir = Path.Combine(dir, "SquareVoice");
            mImagesDir = Path.Combine(squareVoiceDir, "Images");
            mPagesDir = Path.Combine(squareVoiceDir, "Pages");

            if (!Directory.Exists(mImagesDir))
            {
                Directory.CreateDirectory(mImagesDir);
            }
            if (!Directory.Exists(mPagesDir))
            {
                Directory.CreateDirectory(mPagesDir);
            }
        }


        public string imagePathToName(string path)
        {
            if (!path.StartsWith(mImagesDir))
            {
                throw new FileInBadLocationException();
            }
            path = path.Substring(mImagesDir.Length + 1);

            return path;
        }

        public static void CopyRegionIntoImage(Bitmap srcBitmap, Rectangle srcRegion, ref Bitmap destBitmap, Rectangle destRegion)
        {
            using (Graphics grD = Graphics.FromImage(destBitmap))
            {
                grD.DrawImage(srcBitmap, destRegion, srcRegion, GraphicsUnit.Pixel);
            }
        }

        public Image imageNameToImage(string imageName)
        {
            string imageFileName = Path.Combine(mImagesDir, imageName);

            // This copying may seem a bit wierd, but it's here for a reason.
            // When loading .wmf formatted images, the vector art will scale very 
            // poorly under normal circumstances, and the result will look 
            // jaggy and crude.  By using this copy, the rendering of the 
            // .wmf will be forced to be done at a much higher resolution and 
            // scaled down.  The result is an antiailiased image that looks
            // significantly better.
            // A secondary benefit is that it won't lock all of the files for pages
            // that are open.  Hence, you can now update the images while the
            // application is running (probably a small benefit, but useful
            // at times in a development environment, at least)
            Bitmap myBitmap = new Bitmap(imageFileName);
            int w = myBitmap.Width;
            int h = myBitmap.Height;
            Bitmap newBitmap = new Bitmap(w, h);

            CopyRegionIntoImage(myBitmap, new Rectangle(0, 0, w, h), ref newBitmap, new Rectangle(0, 0, w, h));

            Image myImage = (Image)newBitmap.Clone();


            return myImage;
        }

        public static string pageNameToDisplayName(string pageName)
        {
            string displayName = pageName.Replace(".SquareVoice", "");
            return displayName;
        }

        public Helpers()
        {
            initPaths();
        }
    }
}
