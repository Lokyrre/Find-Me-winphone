using FindMe.Services;
using FindMe.UWP.Services;
using System;
using Windows.Media.Core;
using Windows.Media.Playback;
using Xamarin.Forms;

[assembly: Dependency(typeof(AudioService))]

namespace FindMe.UWP.Services
{
    public class AudioService : IAudio
    {
        public AudioService() { }

        private MediaPlayer _mediaPlayer;

        public bool PlayMp3File(string fileName)
        {
            _mediaPlayer = new MediaPlayer();
            _mediaPlayer.Source = MediaSource.CreateFromUri(new Uri("ms-appx:///Assets/" + fileName + ".mp3"));
            _mediaPlayer.Play();

            return true;
        }

        public bool PlayWavFile(string fileName)
        {
            _mediaPlayer = new MediaPlayer();
            _mediaPlayer.Source = MediaSource.CreateFromUri(new Uri("ms-appx:///Assets/" + fileName + ".wav"));
            _mediaPlayer.Play();

            return true;
        }
    }
}
