using Xamarin.Forms;
using Android.Media;
using FindMe.Services;
using FindMe.Droid.Services;

[assembly: Dependency(typeof(AudioService))]

namespace FindMe.Droid.Services
{
    public class AudioService : IAudio
    {
        public AudioService() { }

        private MediaPlayer _mediaPlayer;

        public bool PlayMp3File(string fileName)
        {
            return true;
        }

        public bool PlayWavFile(string fileName)
        {
            _mediaPlayer = MediaPlayer.Create(global::Android.App.Application.Context, Resource.Raw.ding_persevy);
            _mediaPlayer.Start();

            return true;
        }
    }
}