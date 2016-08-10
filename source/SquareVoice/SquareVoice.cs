using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EyeXFramework;

namespace SquareVoice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //EyeXFramework.Forms.FormsEyeXHost
            Program.EyeXHost.Connect(behaviorMap1);
            behaviorMap1.Add(pictureBoxYes, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = 500 });
            behaviorMap1.Add(pictureBoxNo, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = 500 });

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
//            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            //this.BackColor = Color.Black;
        }

        private void OuterPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OnGaze(object sender, GazeAwareEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("In OnGaze");
            var panel = sender as Panel;
            if (panel != null)
            {
                panel.BorderStyle = (e.HasGaze) ? BorderStyle.FixedSingle : BorderStyle.None;
            }
            var picBox = sender as PictureBox;
            if (picBox != null)
            {
                picBox.BackColor = (e.HasGaze) ? Color.Yellow : Color.Transparent;
                //picBox.BorderStyle = (e.HasGaze) ? BorderStyle.FixedSingle : BorderStyle.None;


                if (e.HasGaze)
                {
                    if (picBox == pictureBoxYes)
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"yes.wav");
                        player.Play();
                    }
                    if (picBox == pictureBoxNo)
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"no.wav");
                        player.Play();
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void cbDelayTimeout_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            
            string selectedNumber = (string)comboBox.SelectedItem;
            int num = Convert.ToInt32(selectedNumber);


            this.components = new System.ComponentModel.Container();
            this.behaviorMap1 = new EyeXFramework.Forms.BehaviorMap(this.components);

            Program.EyeXHost.Connect(behaviorMap1);

            behaviorMap1.Add(pictureBoxYes, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = num });
            behaviorMap1.Add(pictureBoxNo, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = num });
        }

        private void pictureBoxYes_Click(object sender, EventArgs e)
        {

        }
    }
}
