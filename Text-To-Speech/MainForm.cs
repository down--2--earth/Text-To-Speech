using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Runtime.InteropServices;

namespace Text_To_Speech
{
    public partial class MainForm : Form
    {

        private SpeechSynthesizer speechSynthesizer;

        private int volume = 0;
        private int rate = 0;

        private Font defaultFont;

        int richTextBox_lastPosition = 0;

        //==============================================
        [DllImport("user32.dll")]
        static extern uint SendInput(uint nInputs, ref INPUT pInputs, int cbSize);

        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(ushort vKey);

        struct MOUSEINPUT
        {
            public int dx;
            public int dy;
            public uint mouseData;
            public uint dwFlags;
            public uint time;
            public IntPtr dwExtraInfo;
        }

        struct KEYBDINPUT
        {
            public ushort wVk;
            public ushort wScan;
            public uint dwFlags;
            public uint time;
            public IntPtr dwExtraInfo;
        }

        struct HARDWAREINPUT
        {
            public int uMsg;
            public short wParamL;
            public short wParamH;
        }

        [StructLayout(LayoutKind.Explicit)]
        struct MOUSEKEYBDHARDWAREINPUT
        {
            [FieldOffset(0)]
            public MOUSEINPUT mi;

            [FieldOffset(0)]
            public KEYBDINPUT ki;

            [FieldOffset(0)]
            public HARDWAREINPUT hi;
        }

        struct INPUT
        {
            public int type;
            public MOUSEKEYBDHARDWAREINPUT mkhi;
        }

        const int INPUT_KEYBOARD = 1;
        const uint KEYEVENTF_KEYUP = 0x0002;

        const ushort VK_SHIFT = 0x10;
        const ushort VK_CONTROL = 0x11;
        const ushort VK_MENU = 0x12;
        //==============================================

        public MainForm()
        {
            InitializeComponent();

            FontFamily[] ffArray = FontFamily.Families;
            foreach (FontFamily ff in ffArray)
            {
                if (ff.IsStyleAvailable(FontStyle.Regular))
                {
                    comboBoxFontFamily.Items.Add(ff.Name);
                }
            }

            comboBoxFontFamily.SelectedItem = richTextBox.Font.FontFamily.Name;

            for (int x = 5; x <= 50; x++)
            {
                comboBoxFontSize.Items.Add(x);
            }

            comboBoxFontSize.SelectedItem = Convert.ToInt32(richTextBox.Font.Size);

            defaultFont = new Font(richTextBox.Font.FontFamily.Name, richTextBox.Font.Size, richTextBox.Font.Style);

            InitTextToSpeech();

            trackBarVolume.Value = speechSynthesizer.Volume;
            trackBarRate.Value = speechSynthesizer.Rate;

            volume = speechSynthesizer.Volume;
            rate = speechSynthesizer.Rate;
        }



        private void InitTextToSpeech()
        {

            if (speechSynthesizer != null)
            {
                speechSynthesizer.Dispose();
            }

            speechSynthesizer = new SpeechSynthesizer();

            speechSynthesizer.SpeakProgress += new EventHandler<SpeakProgressEventArgs>(synthesizer_SpeakProgress);

            speechSynthesizer.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>(synthesizer_SpeakCompleted);

            richTextBox.SelectAll();
            richTextBox.SelectionColor = Color.Black;
            richTextBox.Select(0, 0);

            comboBoxVoice.Items.Clear();

            foreach (InstalledVoice voice in speechSynthesizer.GetInstalledVoices())
            {
                comboBoxVoice.Items.Add(voice.VoiceInfo.Name);
            }

            if (comboBoxVoice.Items.Count > 0)
            {
                comboBoxVoice.SelectedIndex = 0;
            }

            buttonRead.Enabled = true;
            buttonCopyRead.Enabled = true;
            buttonPause.Text = "Pause";

            buttonPause.Enabled = false;
            buttonStop.Enabled = false;
        }

        private void Read()
        {
            richTextBox.Refresh();
            string text = richTextBox.SelectedText;

            if (string.IsNullOrEmpty(text))
            {
                text = richTextBox.Text;
            }

            if (text.Length > 0)
            {
                buttonRead.Enabled = false;
                buttonCopyRead.Enabled = false;
                buttonPause.Enabled = true;
                buttonStop.Enabled = true;
            }
            else
            {
                buttonCopyRead.Enabled = true;
                buttonRead.Enabled = true;
            }

            speechSynthesizer.Volume = volume;
            speechSynthesizer.Rate = rate;

            speechSynthesizer.SpeakAsync(text);

            richTextBox.Focus();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            InitTextToSpeech();

            trackBarVolume.Value = speechSynthesizer.Volume;
            trackBarRate.Value = speechSynthesizer.Rate;

            volume = speechSynthesizer.Volume;
            rate = speechSynthesizer.Rate;

            richTextBox.Font = defaultFont;

        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            Read();
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            if (buttonPause.Text == "Pause")
            {
                speechSynthesizer.Pause();
                buttonPause.Text = "Resume";
            }
            else if (buttonPause.Text == "Resume")
            {
                speechSynthesizer.Volume = volume;
                speechSynthesizer.Rate = rate;

                speechSynthesizer.Resume();
                buttonPause.Text = "Pause";

                richTextBox.Focus();
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            InitTextToSpeech();
        }

        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            speechSynthesizer.Volume = trackBarVolume.Value;
            volume = trackBarVolume.Value;
        }

        private void trackBarRate_Scroll(object sender, EventArgs e)
        {
            speechSynthesizer.Rate = trackBarRate.Value;
            rate = trackBarRate.Value;
        }

        private void comboBoxVoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            speechSynthesizer.SelectVoice(comboBoxVoice.SelectedItem.ToString());
        }

        private void synthesizer_SpeakProgress(object sender, SpeakProgressEventArgs e)
        {
            richTextBox.Select(e.CharacterPosition, e.CharacterCount);
            if (checkBoxColorText.Checked)
            {
                richTextBox.SelectionColor = Color.Blue;
            }
        }

        private void synthesizer_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            InitTextToSpeech();

            richTextBox.SelectAll();
            richTextBox.SelectionColor = Color.Black;
            richTextBox.Select(0, 0);
        }

        private void checkBoxColorText_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox.Focus();
        }

        private void comboBoxFontFamily_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Font font = new Font(comboBoxFontFamily.SelectedItem.ToString(), richTextBox.Font.Size);
            richTextBox.Font = font;
            richTextBox.Focus();
        }

        private void comboBoxFontSize_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Font font = new Font(richTextBox.Font.FontFamily.Name, float.Parse(comboBoxFontSize.SelectedItem.ToString()));
            richTextBox.Font = font;
            richTextBox.Focus();
        }

        private void checkBoxTopMost_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = checkBoxTopMost.Checked;
        }

        public void SimulateKeyStroke(char key, bool ctrl = false, bool alt = false, bool shift = false)
        {
            List<ushort> keys = new List<ushort>();

            if (ctrl)
                keys.Add(VK_CONTROL);

            if (alt)
                keys.Add(VK_MENU);

            if (shift)
                keys.Add(VK_SHIFT);

            keys.Add(char.ToUpper(key));

            INPUT input = new INPUT();
            input.type = INPUT_KEYBOARD;
            int inputSize = Marshal.SizeOf(input);

            for (int i = 0; i < keys.Count; ++i)
            {
                input.mkhi.ki.wVk = keys[i];

                bool isKeyDown = (GetAsyncKeyState(keys[i]) & 0x10000) != 0;

                if (!isKeyDown)
                    SendInput(1, ref input, inputSize);
            }

            input.mkhi.ki.dwFlags = KEYEVENTF_KEYUP;
            for (int i = keys.Count - 1; i >= 0; --i)
            {
                input.mkhi.ki.wVk = keys[i];
                SendInput(1, ref input, inputSize);
            }
        }

        private void buttonCopyRead_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
            buttonCopyRead.Enabled = false;
            buttonRead.Enabled = false;
            labelCopyRead.Visible = true;
            labelCopyRead.Refresh();
            System.Threading.Thread.Sleep(3000);
            SimulateKeyStroke('c', ctrl:true);
            System.Threading.Thread.Sleep(1000);
            this.Activate();
            richTextBox.Focus();
            System.Threading.Thread.Sleep(1000);
            SimulateKeyStroke('v', ctrl: true);
            labelCopyRead.Visible = false;
            Application.DoEvents();
            Read();
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox.SelectionStart - richTextBox_lastPosition > 2)
            {
                // Text was pasted int; text box
                if (checkBoxChangeFontStyle.Checked)
                {
                    Font font = new Font(richTextBox.Font.FontFamily.Name, float.Parse(comboBoxFontSize.SelectedItem.ToString()));
                    richTextBox.Font = font;
                    richTextBox.Focus();

                    font = new Font(comboBoxFontFamily.SelectedItem.ToString(), richTextBox.Font.Size);
                    richTextBox.Font = font;
                    richTextBox.Focus();
                }
            }
            richTextBox_lastPosition = richTextBox.SelectionStart;

            

        }

    }
}