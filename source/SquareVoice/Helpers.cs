using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;


namespace SquareVoice
{
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
                throw new Exception("File in bad location. Need to make this more robust");
            }
            path = path.Substring(mImagesDir.Length + 1);

            return path;
        }

        public Image imageNameToImage(string imageName)
        {
            string imageFileName = Path.Combine(mImagesDir, imageName);
            return Image.FromFile(imageFileName);
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
