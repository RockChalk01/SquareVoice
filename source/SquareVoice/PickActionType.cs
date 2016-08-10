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
    public partial class PickActionType : Form
    {
        public ActionItem ActionPicked { get; set; } 
        public PickActionType(string defaultAction = "")
        {
            InitializeComponent();


            ActionList.Items.Add(new ActionLoadPageFactory());
            ActionList.Items.Add(new ActionSpeakTextFactory());
            for (int i=0; i < ActionList.Items.Count; i++) 
            {
                var item = ActionList.Items[i];
                var factory = item as ActionItemFactory;
                if (factory.getActionName == defaultAction)
                {
                    ActionList.SetSelected(i, true);
                }
            }
        }

        private void OkayBttn_Click(object sender, EventArgs e)
        {
            ActionPicked = (ActionList.Items[ActionList.SelectedIndex] as ActionItemFactory).getActionItem();
            this.Close();
        }

        private void CancelBttn_Click(object sender, EventArgs e)
        {
            ActionPicked = null;
            this.Close();
        }

        private void ActionItemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            OkayBttn.Enabled = true;
        }
    }
}
