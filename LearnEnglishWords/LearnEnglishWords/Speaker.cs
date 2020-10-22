using System;
using System.Linq;
using System.Media;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace LearnEnglishWords
{

    public class Speaker
    {

        public static SoundPlayer somErrou = new SoundPlayer("erro.wav");
        public static void Speak(string sentence, int Velocidade)
        {

            try
            {
                using (SpeechSynthesizer synth = new SpeechSynthesizer())
                {
                    var a = synth.GetInstalledVoices().Where(x => x.VoiceInfo.Culture.Name.Contains("US"));

                    synth.SelectVoice(a.FirstOrDefault().VoiceInfo.Name);

                    // Configure the audio output.
                    synth.Rate = Velocidade;

                    synth.SetOutputToDefaultAudioDevice();

                    // Speak a string.  

                    synth.Speak(sentence);
                }
            }
            catch (Exception abc)
            {
                MessageBox.Show("Erro ao falar: " + abc.Message);
                
            }
           

        }

        internal static void Errou()
        {
            somErrou.Play();
        }

        internal static void Acertou()
        {
        }

    }
}
