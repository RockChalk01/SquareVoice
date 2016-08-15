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
    public partial class EditCell : Form
    {
        GridPage mPage;
        GridItemObj mCell;
        GridItemObj mProposedCell;

        private void RefreshActionsList()
        {
            ActionListBox.Items.Clear();

            foreach (var actionItem in mCell.Actions)
            {
                ActionListBox.Items.Add(actionItem);
            }
        }

        public EditCell(GridPage grid, GridItemObj cell)
        {
            mCell = cell;
            mProposedCell = new GridItemObj();
            mPage = grid;
            mProposedCell.image = mCell.image;
            InitializeComponent();

            RefreshActionsList();
            if (ActionListBox.Items.Count > 0)
            {
                ActionListBox.SetSelected(0, true);
            }
            RefreshPicture();
            CaptionTextBox.Text = mCell.text;
        }

        public void RefreshPicture()
        {
            if (mProposedCell.image != null)
            {
                ImagePreviewPictureBox.Image = mPage.mHelpers.imageNameToImage(mProposedCell.image);
            }
        }

        private void PickImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = mPage.mHelpers.mImagesDir;
            openFileDialog1.Filter = "Image Files(*.bmp;*.jpg;*.gif;*.png)|*.bmp;*.jpg;*.gif;*.png";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fn = openFileDialog1.FileName;

                string imageName = mPage.mHelpers.imagePathToName(fn);

                mProposedCell.image = imageName;

                ImagePreviewPictureBox.Image = mPage.mHelpers.imageNameToImage(imageName);
            }

        }

        private void OkayButton_Click(object sender, EventArgs e)
        {
            mCell.image = mProposedCell.image;
            mCell.text = CaptionTextBox.Text;
            mCell.Actions.Clear();
            foreach (var item in ActionListBox.Items)
            {
                var actionItem = item as ActionItem;
                mCell.Actions.Add(actionItem);
            }
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearImageButton_Click(object sender, EventArgs e)
        {
            mProposedCell.image = null;
            ImagePreviewPictureBox.Image = null;
        }

        private void DoEditAction()
        {
            if (ActionListBox.SelectedIndex < 0) return;

            var actionToEdit = ActionListBox.Items[ActionListBox.SelectedIndex] as ActionItem;

            if (null == actionToEdit)
            {
                throw new Exception("actionToEdit was null!");
            }
            actionToEdit.Edit();
        }
        private void EditActionButton_Click(object sender, EventArgs e)
        {
            DoEditAction();
        }

        private void AddActionButton_Click(object sender, EventArgs e)
        {
            PickActionType dialog = new PickActionType();
            dialog.ShowDialog();

            if (dialog.ActionPicked != null)
            {
                ActionListBox.Items.Add(dialog.ActionPicked);
                ActionListBox.SetSelected(ActionListBox.Items.Count - 1, true);
                DoEditAction();
            }


        }

        private void DeleteActionButton_Click(object sender, EventArgs e)
        {
            if (ActionListBox.SelectedIndex < 0) return;

            ActionListBox.Items.RemoveAt(ActionListBox.SelectedIndex);
        }

        private void ActionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ActionListBox.Items.Count > 0)
            {
                DeleteActionButton.Enabled = true;
                EditActionButton.Enabled = true;
            }
            else
            {
                DeleteActionButton.Enabled = false;
                EditActionButton.Enabled = false;
            }

        }
    }

}
