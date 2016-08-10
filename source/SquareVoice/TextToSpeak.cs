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
    public partial class TextToSpeak : Form
    {
        private ActionSpeakText mAction;
        public TextToSpeak(ActionSpeakText action)
        {
            InitializeComponent();
            TextToSpeakTextBox.Text = action.TextToSpeak;
            mAction = action;
        }

        private void OkayButton_Click(object sender, EventArgs e)
        {
            mAction.TextToSpeak = TextToSpeakTextBox.Text;
            this.Close();
        }

        private void CancelBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
