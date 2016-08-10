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
    public partial class NewPage : Form
    {
        private GridPage mGridPage;
        public NewPage(GridPage gridPage)
        {
            mGridPage = gridPage;
            InitializeComponent();
        }

        private void OkayButton_Click(object sender, EventArgs e)
        {
            if (PageNameTextBox.Text == "")
            {
                throw new Exception("No text in text box");
            }
            mGridPage.createNewPage(PageNameTextBox.Text);
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
