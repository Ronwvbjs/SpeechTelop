using System.Collections.Generic;

namespace SpeechTelop
{
    public class VoiceName
    {
        public string gender { get; set; }
        public string name { get; set; }
    }

    public class LanguageData
    {
        public string speech_translation_from_language { get; set; }
        public string speech_translation_to_language { get; set; }
        public string text_to_speech_locale { get; set; }
        public List<VoiceName> voice_name { get; set; }
    }

    public class LanguageSupport
    {
        public List<LanguageData> language_data { get; set; }
    }
}
