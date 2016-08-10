using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SquareVoice
{
    public partial class LoadPage : Form
    {
        public string PageToLoad { get; set; } 
        Helpers mHelpers;
        public LoadPage(Helpers helpers, string defaultPage="")
        {
            mHelpers = helpers;
            InitializeComponent();

            var files = System.IO.Directory.EnumerateFiles(mHelpers.mPagesDir);

            foreach (var file in files)
            {
                bool isMatch = false;
                string pageName = file.Replace(mHelpers.mPagesDir + "\\", "");

                if (defaultPage == pageName)
                {
                    isMatch = true;
                }
                pageName = pageName.Replace(".SquareVoice", "");
                PageList.Items.Add(pageName);
                if (isMatch)
                {
                    PageList.SetSelected(PageList.Items.Count - 1, true);
                }
            }

        }

        private void OkayBttn_Click(object sender, EventArgs e)
        {
            PageToLoad = PageList.Items[PageList.SelectedIndex] as string + ".SquareVoice";
            //mGridPage.load(PageList.Items[PageList.SelectedIndex] as string + ".SquareVoice");
            this.Close();
        }

        private void CancelBttn_Click(object sender, EventArgs e)
        {
            PageToLoad = null;
            this.Close();
        }

        private void PageList_SelectedIndexChanged(object sender, EventArgs e)
        {
            OkayBttn.Enabled = true;
        }
    }
}
