using CognitiveServicesTTS;
using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Translation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeechTelop
{
    public partial class Form : System.Windows.Forms.Form
    {
        private LanguageSupport languageSupport;

        private string hotKey;

        private string ctrlKey;

        private string shiftKey;

        private string altKey;

        private string pushedKey;

        private bool canRecognizeTranslatio;

        private bool isHotKeyMatch;

        private System.Timers.Timer hideAfterSecondsTimer;

        private Authentication authentication;

        public Form()
        {
            InitializeComponent();

            canRecognizeTranslatio = true;
            isHotKeyMatch = false;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            Location = Properties.Settings.Default.SpeechTelopLocation;

            subscriptionKeyTextBox.Text = Properties.Settings.Default.SubscriptionKeyTextBoxText;
            showSubscriptionKeyCheckBox.Checked = Properties.Settings.Default.ShowSubscriptionKeyCheckBoxChecked;

            serviceRegionComboBox.Items.Clear();
            foreach (string item in Properties.Resources.SpeechServiceRegion.Split(','))
            {
                serviceRegionComboBox.Items.Add(item);
            }
            serviceRegionComboBox.SelectedIndex = Properties.Settings.Default.ServiceRegionComboBoxSelectedIndex;

            languageSupport = JsonConvert.DeserializeObject<LanguageSupport>(Properties.Resources.LanguageSupport);

            fromLanguageComboBox.Items.Clear();
            foreach (LanguageData item in languageSupport.language_data)
            {
                fromLanguageComboBox.Items.Add(item.speech_translation_from_language);
            }

            toLanguageComboBox.Items.Clear();
            foreach (LanguageData item in languageSupport.language_data)
            {
                toLanguageComboBox.Items.Add(item.speech_translation_to_language);
            }

            fromLanguageComboBox.SelectedIndex = Properties.Settings.Default.FromLanguageComboBoxSelectedIndex;
            toLanguageComboBox.SelectedIndex = Properties.Settings.Default.ToLanguageComboBoxSelectedIndex;

            enableTextToSpeechCheckBox.Checked = Properties.Settings.Default.EnableTextToSpeechCheckBoxChecked;

            hotKeyComboBox.Items.Clear();
            foreach (string item in Properties.Resources.HotKeys.Split(','))
            {
                hotKeyComboBox.Items.Add(item);
            }
            hotKeyComboBox.SelectedIndex = Properties.Settings.Default.HotKeyComboBoxSelectedIndex;

            addShiftKeyCheckBox.Checked = Properties.Settings.Default.AddShiftKeyCheckBox;
            addCtrlKeyCheckBox.Checked = Properties.Settings.Default.AddCtrlKeyCheckBox;
            addAltKeyCheckBox.Checked = Properties.Settings.Default.AddAltKeyCheckBox;

            outputFileTextBox.Text = Properties.Settings.Default.OutputFileTextBoxText;

            hideAfterSecondsMaskedTextBox.Text = Properties.Settings.Default.HideAfterSecondsMaskedTextBoxText;

            MMFrame.Windows.GlobalHook.KeyboardHook.AddEvent(HookKeyboard);
            MMFrame.Windows.GlobalHook.KeyboardHook.Start();

            MMFrame.Windows.GlobalHook.MouseHook.AddEvent(HookMouse);
            MMFrame.Windows.GlobalHook.MouseHook.Start();
        }

        private void HookKeyboard(ref MMFrame.Windows.GlobalHook.KeyboardHook.StateKeyboard s)
        {
            switch (s.Key)
            {
                case Keys.LShiftKey:
                    if (s.Stroke == MMFrame.Windows.GlobalHook.KeyboardHook.Stroke.KEY_DOWN)
                    {
                        shiftKey = "Shift + ";
                    }
                    else if (s.Stroke == MMFrame.Windows.GlobalHook.KeyboardHook.Stroke.KEY_UP)
                    {
                        shiftKey = "";
                    }
                    break;

                case Keys.LControlKey:
                    if (s.Stroke == MMFrame.Windows.GlobalHook.KeyboardHook.Stroke.KEY_DOWN)
                    {
                        ctrlKey = "Ctrl + ";
                    }
                    else if (s.Stroke == MMFrame.Windows.GlobalHook.KeyboardHook.Stroke.KEY_UP)
                    {
                        ctrlKey = "";
                    }
                    break;

                case Keys.LMenu:
                    if (s.Stroke == MMFrame.Windows.GlobalHook.KeyboardHook.Stroke.KEY_DOWN)
                    {
                        altKey = "Alt + ";
                    }
                    else if (s.Stroke == MMFrame.Windows.GlobalHook.KeyboardHook.Stroke.KEY_UP)
                    {
                        altKey = "";
                    }
                    break;

                default:
                    if (s.Stroke == MMFrame.Windows.GlobalHook.KeyboardHook.Stroke.KEY_DOWN)
                    {
                        pushedKey = s.Key.ToString();
                    }
                    else if (s.Stroke == MMFrame.Windows.GlobalHook.KeyboardHook.Stroke.KEY_UP)
                    {
                        pushedKey = "";
                    }
                    break;
            }

            if (shiftKey + ctrlKey + altKey + pushedKey == hotKey)
            {
                isHotKeyMatch = true;

                if (canRecognizeTranslatio)
                {
                    canRecognizeTranslatio = false;

                    if (subscriptionKeyTextBox.Text == "")
                    {
                        MessageBox.Show("Subscription-Key is null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        RecognizeTranslatioAsync().Wait();
                    }
                }
            }
            else
            {
                isHotKeyMatch = false;
            }
        }

        private void HookMouse(ref MMFrame.Windows.GlobalHook.MouseHook.StateMouse s)
        {
            if (s.Stroke == MMFrame.Windows.GlobalHook.MouseHook.Stroke.MOVE)
            {
                return;
            }
            if (s.Stroke == MMFrame.Windows.GlobalHook.MouseHook.Stroke.WHEEL_DOWN || s.Stroke == MMFrame.Windows.GlobalHook.MouseHook.Stroke.WHEEL_UP)
            {
                return;
            }

            pushedKey = "";
            if (s.Stroke == MMFrame.Windows.GlobalHook.MouseHook.Stroke.LEFT_DOWN)
            {
                pushedKey = Keys.LButton.ToString();
            }
            else if (s.Stroke == MMFrame.Windows.GlobalHook.MouseHook.Stroke.RIGHT_DOWN)
            {
                pushedKey = Keys.RButton.ToString();
            }
            else if (s.Stroke == MMFrame.Windows.GlobalHook.MouseHook.Stroke.MIDDLE_DOWN)
            {
                pushedKey = Keys.MButton.ToString();
            }

            if (shiftKey + ctrlKey + altKey + pushedKey == hotKey)
            {
                isHotKeyMatch = true;

                if (canRecognizeTranslatio)
                {
                    canRecognizeTranslatio = false;

                    if (subscriptionKeyTextBox.Text == "")
                    {
                        MessageBox.Show("Subscription-Key is null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        RecognizeTranslatioAsync().Wait();
                    }
                }
            }
            else
            {
                isHotKeyMatch = false;
            }
        }

        private void Form_ClientSizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();

                notifyIcon.Visible = true;
            }
        }

        private void NotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            Visible = true;

            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }

            Activate();
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            notifyIcon.Visible = false;
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = true;

            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }

            Activate();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                Properties.Settings.Default.SpeechTelopLocation = Location;
            }

            Properties.Settings.Default.SubscriptionKeyTextBoxText = subscriptionKeyTextBox.Text;
            Properties.Settings.Default.ShowSubscriptionKeyCheckBoxChecked = showSubscriptionKeyCheckBox.Checked;

            Properties.Settings.Default.ServiceRegionComboBoxSelectedIndex = serviceRegionComboBox.SelectedIndex;

            Properties.Settings.Default.ToLanguageComboBoxSelectedIndex = toLanguageComboBox.SelectedIndex;
            Properties.Settings.Default.FromLanguageComboBoxSelectedIndex = fromLanguageComboBox.SelectedIndex;

            Properties.Settings.Default.EnableTextToSpeechCheckBoxChecked = enableTextToSpeechCheckBox.Checked;
            Properties.Settings.Default.VoiceNameComboBoxSelectedIndex = voiceNameComboBox.SelectedIndex;

            Properties.Settings.Default.HotKeyComboBoxSelectedIndex = hotKeyComboBox.SelectedIndex;

            Properties.Settings.Default.AddShiftKeyCheckBox = addShiftKeyCheckBox.Checked;
            Properties.Settings.Default.AddCtrlKeyCheckBox = addCtrlKeyCheckBox.Checked;
            Properties.Settings.Default.AddAltKeyCheckBox = addAltKeyCheckBox.Checked;

            Properties.Settings.Default.OutputFileTextBoxText = outputFileTextBox.Text;

            Properties.Settings.Default.HideAfterSecondsMaskedTextBoxText = hideAfterSecondsMaskedTextBox.Text;

            Properties.Settings.Default.Save();

            MMFrame.Windows.GlobalHook.KeyboardHook.Stop();
            MMFrame.Windows.GlobalHook.MouseHook.Stop();
        }

        private void OutputFileTextBox_TextChanged(object sender, EventArgs e)
        {
            FileInfo fileInfo;

            try
            {
                fileInfo = new FileInfo(outputFileTextBox.Text);

                openFileDialog.InitialDirectory = fileSystemWatcher.Path = fileInfo.DirectoryName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OutputFileBrowseButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;

            dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                outputFileTextBox.Text = openFileDialog.FileName;
            }
        }

        private void ShowSubscriptionKeyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            subscriptionKeyTextBox.UseSystemPasswordChar = !showSubscriptionKeyCheckBox.Checked;
        }

        private void ServiceRegionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void ToLanguageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex;

            voiceNameComboBox.Items.Clear();
            foreach (VoiceName item in languageSupport.language_data[toLanguageComboBox.SelectedIndex].voice_name)
            {
                voiceNameComboBox.Items.Add(item.name + " (" + item.gender + ")");
            }

            selectedIndex = Properties.Settings.Default.VoiceNameComboBoxSelectedIndex;
            if (selectedIndex >= voiceNameComboBox.Items.Count)
            {
                selectedIndex = voiceNameComboBox.Items.Count - 1;
            }
            voiceNameComboBox.SelectedIndex = selectedIndex;
        }

        private void EnableTextToSpeechCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (enableTextToSpeechCheckBox.Checked)
            {
                voiceNameLabel.Enabled = true;
                voiceNameComboBox.Enabled = true;
            }
            else
            {
                voiceNameLabel.Enabled = false;
                voiceNameComboBox.Enabled = false;
            }
        }

        private void HotKeyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateHotKey();
        }

        private void AddShiftKeyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateHotKey();
        }

        private void AddCtrlKeyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateHotKey();
        }

        private void AddAltKeyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateHotKey();
        }

        private void UpdateHotKey()
        {
            hotKey = "";
            if (addShiftKeyCheckBox.Checked)
            {
                hotKey += Properties.Resources.AddShiftKeyText;
            }
            if (addCtrlKeyCheckBox.Checked)
            {
                hotKey += Properties.Resources.AddCtrlKeyText;
            }
            if (addAltKeyCheckBox.Checked)
            {
                hotKey += Properties.Resources.AddAltKeyText;
            }

            hotKey += hotKeyComboBox.Text;
        }

        private int GetToLanguageComboBoxSelectedIndex()
        {
            return toLanguageComboBox.SelectedIndex;
        }

        private int GetVoiceNameComboBoxSelectedIndex()
        {
            return voiceNameComboBox.SelectedIndex;
        }

        private async Task RecognizeTranslatioAsync()
        {
            int timerInterval;
            string fromLanguage, toLanguage;
            SpeechTranslationConfig translationConfig;
            FileStream fileStream;

            if (hideAfterSecondsTimer != null)
            {
                hideAfterSecondsTimer.Stop();
                hideAfterSecondsTimer.Elapsed -= OnHideAfterSecondsTimerElapsed;
                hideAfterSecondsTimer = null;
            }

            hideAfterSecondsTimer = new System.Timers.Timer();

            timerInterval = int.Parse(hideAfterSecondsMaskedTextBox.Text) * 1000;
            if (timerInterval > 0)
            {
                hideAfterSecondsTimer.Interval = timerInterval;
            }

            hideAfterSecondsTimer.AutoReset = false;
            hideAfterSecondsTimer.Elapsed += OnHideAfterSecondsTimerElapsed;

            fromLanguage = fromLanguageComboBox.Text;
            toLanguage = toLanguageComboBox.Text;

            translationConfig = SpeechTranslationConfig.FromSubscription(subscriptionKeyTextBox.Text, serviceRegionComboBox.Text);

            translationConfig.SpeechRecognitionLanguage = fromLanguage;
            translationConfig.VoiceName = Properties.Resources.VoiceName;

            translationConfig.AddTargetLanguage(toLanguage);

            using (TranslationRecognizer recognizer = new TranslationRecognizer(translationConfig))
            {
                recognizer.Recognized += (s, e) =>
                {
                    if (e.Result.Reason == ResultReason.TranslatedSpeech)
                    {
                        fileStream = new FileStream(outputFileTextBox.Text, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);

                        using (StreamReader streamReader = new StreamReader(fileStream, Encoding.GetEncoding("utf-8")))
                        {
                            int character;
                            string line, translatedText;
                            List<string> readLines;

                            readLines = new List<string>();

                            readLines.Add(e.Result.Text);
                            readLines.Add(Environment.NewLine);

                            translatedText = "";
                            foreach (KeyValuePair<string, string> element in e.Result.Translations)
                            {
                                readLines.Add(element.Value);

                                translatedText += element.Value;
                            }
                            readLines.Add(Environment.NewLine);
                            readLines.Add(Environment.NewLine);

                            line = "";
                            do
                            {
                                character = streamReader.Read();

                                line += (char)character;
                                if (line.Contains(Environment.NewLine))
                                {
                                    readLines.Add(line);

                                    line = "";
                                }
                            }
                            while (character != -1);

                            fileStream.SetLength(0);

                            using (StreamWriter writer = new StreamWriter(fileStream, Encoding.GetEncoding("utf-8")))
                            {
                                foreach (string element in readLines)
                                {
                                    writer.Write(element);
                                }
                            }

                            if (enableTextToSpeechCheckBox.Checked)
                            {
                                int selectedIndex;

                                if (toLanguageComboBox.InvokeRequired)
                                {
                                    selectedIndex = (int)toLanguageComboBox.Invoke(new Func<int>(GetToLanguageComboBoxSelectedIndex));
                                }
                                else
                                {
                                    selectedIndex = toLanguageComboBox.SelectedIndex;
                                }
                                LanguageData languageData = languageSupport.language_data[selectedIndex];

                                string locale = languageData.text_to_speech_locale;

                                if (voiceNameComboBox.InvokeRequired)
                                {
                                    selectedIndex = (int)voiceNameComboBox.Invoke(new Func<int>(GetVoiceNameComboBoxSelectedIndex));
                                }
                                else
                                {
                                    selectedIndex = voiceNameComboBox.SelectedIndex;
                                }
                                VoiceName voiceName = languageData.voice_name[selectedIndex];

                                SpeakWithVoice(locale, voiceName, translatedText);
                            }
                        }
                    }
                };

                await recognizer.StartContinuousRecognitionAsync().ConfigureAwait(false);

                while (isHotKeyMatch) { }

                await recognizer.StopContinuousRecognitionAsync().ConfigureAwait(false);
            }

            canRecognizeTranslatio = true;

            if (timerInterval > 0)
            {
                hideAfterSecondsTimer.Start();
            }
        }

        private void OnHideAfterSecondsTimerElapsed(object sender, EventArgs e)
        {
            FileStream fileStream;

            fileStream = new FileStream(outputFileTextBox.Text, FileMode.Open, FileAccess.Write, FileShare.ReadWrite);

            fileStream.SetLength(0);

            fileStream.Close();

            if (hideAfterSecondsTimer != null)
            {
                hideAfterSecondsTimer.Stop();
                hideAfterSecondsTimer.Elapsed -= OnHideAfterSecondsTimerElapsed;
                hideAfterSecondsTimer = null;
            }
        }

        private string GetSubscriptionKeyTextBoxText()
        {
            return subscriptionKeyTextBox.Text;
        }

        private string GetServiceRegionComboBoxText()
        {
            return serviceRegionComboBox.Text;
        }

        private void SpeakWithVoice(string locale, VoiceName voiceName, string text, AudioOutputFormat format = AudioOutputFormat.Riff24Khz16BitMonoPcm)
        {
            string accessToken = string.Empty;

            Debug.WriteLine("Starting Authtentication");

            if (authentication == null)
            {
                string issueTokenUri = "https://";
                if (serviceRegionComboBox.InvokeRequired)
                {
                    issueTokenUri += (string)serviceRegionComboBox.Invoke(new Func<string>(GetServiceRegionComboBoxText));
                }
                else
                {
                    issueTokenUri += serviceRegionComboBox.Text;
                }
                issueTokenUri += ".api.cognitive.microsoft.com/sts/v1.0/issuetoken";

                string apiKey;
                if (subscriptionKeyTextBox.InvokeRequired)
                {
                    apiKey = (string)serviceRegionComboBox.Invoke(new Func<string>(GetSubscriptionKeyTextBoxText));
                }
                else
                {
                    apiKey = subscriptionKeyTextBox.Text;
                }
                authentication = new Authentication(issueTokenUri, apiKey);
            }

            try
            {
                accessToken = authentication.GetAccessToken();
                Debug.WriteLine("Token: {0}\n", accessToken);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Failed authentication.");
                Debug.WriteLine(ex.ToString());
                Debug.WriteLine(ex.Message);
                return;
            }

            Debug.WriteLine("Starting TTSSample request code execution.");

            string requestUri = "https://";
            if (serviceRegionComboBox.InvokeRequired)
            {
                requestUri += (string)serviceRegionComboBox.Invoke(new Func<string>(GetServiceRegionComboBoxText));
            }
            else
            {
                requestUri += serviceRegionComboBox.Text;
            }
            requestUri += ".tts.speech.microsoft.com/cognitiveservices/v1";

            Debug.WriteLine(requestUri);

            var cortana = new Synthesize();

            EventHandler<GenericEventArgs<Stream>> handler;

            handler = PlayAudio;

            cortana.OnAudioAvailable += handler;
            cortana.OnError += ErrorHandler;

            // Reuse Synthesize object to minimize latency
            cortana.Speak(CancellationToken.None, new Synthesize.InputOptions()
            {
                RequestUri = new Uri(requestUri),
                // Text to be spoken.
                Text = text,
                VoiceType = voiceName.gender,

                // Refer to the documentation for complete list of supported locales.
                // Please note locale must be matched with voice locales. 
                Locale = locale,
                VoiceName = voiceName.name,
                OutputFormat = format,

                // For onpremise container, auth token is optional 
                AuthorizationToken = "Bearer " + accessToken,
            }).Wait();

            cortana.OnAudioAvailable -= handler;
            cortana.OnError -= ErrorHandler;
        }

        private static void PlayAudio(object sender, GenericEventArgs<Stream> args)
        {
            // For SoundPlayer to be able to play the wav file, it has to be encoded in PCM.
            // Use output audio format AudioOutputFormat.Riff16Khz16BitMonoPcm to do that.
            SoundPlayer player = new SoundPlayer(args.EventData);
            player.PlaySync();
            args.EventData.Dispose();
        }

        /// <summary>
        /// Handler an error when a TTS request failed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="GenericEventArgs{Exception}"/> instance containing the event data.</param>
        private static void ErrorHandler(object sender, GenericEventArgs<Exception> e)
        {
            Debug.WriteLine("Unable to complete the TTS request: [{0}]", e.ToString());
        }
    }
}
