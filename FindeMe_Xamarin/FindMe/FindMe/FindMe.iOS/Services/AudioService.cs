using AVFoundation;
using FindMe.iOS.Services;
using FindMe.Services;
using Foundation;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(AudioService))]

namespace FindMe.iOS.Services
{
    public class AudioService : IAudio
    {
        public AudioService() { }
        
        public bool PlayMp3File(string fileName)
        {
            return true;
        }
        
        public bool PlayWavFile(string fileName)
        {
			fileName = fileName + ".wav";
            string FilePath = NSBundle.MainBundle.PathForResource(Path.GetFileNameWithoutExtension(fileName),
                        Path.GetExtension(fileName));
            var url = NSUrl.FromString(fileName);
            AVAudioPlayer _player = AVAudioPlayer.FromUrl(url);
            _player.FinishedPlaying += (object sender, AVStatusEventArgs e) => { _player = null; };
            _player.Play();

            return true;
        }
    }
}