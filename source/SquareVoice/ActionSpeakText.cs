using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace SquareVoice
{
    public class ActionSpeakText : ActionItem
    {
        public ActionSpeakText(string text)
        {
            TextToSpeak = text;
        }
        public const string staticActionName = "Speak Text";
        public override string ActionName { get { return staticActionName; } }
        public string TextToSpeak;
        public override void Trigger(object sender, EventArgs e)
        {
            var arg = e as System.Windows.Forms.MouseEventArgs;
            if (null == arg || arg.Button != System.Windows.Forms.MouseButtons.Left)
            {
                return;
            }
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();

            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Child);

            synthesizer.Volume = 100;  // 0...100
            synthesizer.Rate = -2;     // -10...10
            Program.EyeXHost.TriggerActivationModeOff();
            // Synchronous
            synthesizer.Speak(TextToSpeak);
            Program.EyeXHost.TriggerActivationModeOn();

            synthesizer.Dispose();

            // Asynchronous
            //synthesizer.SpeakAsync("Hello World");
        }
        public override void Edit()
        {
            TextToSpeak dialog = new TextToSpeak(this);
            dialog.ShowDialog();
        }

        public override string ToString()
        {
            return "Speak Text (\"" + this.TextToSpeak + "\")";
        }

    }

    public class ActionSpeakTextFactory : ActionItemFactory
    {
        public override ActionItem getActionItem() { return new ActionSpeakText(""); }
        public override string getActionName { get {return ActionSpeakText.staticActionName;}}
        public override string ToString()
        {
            return getActionName;
        }
    }

}
