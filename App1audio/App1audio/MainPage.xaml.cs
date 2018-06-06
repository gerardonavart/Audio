using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarians.MediaPlayer;
using Xamarin.Forms;


namespace App1audio
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            btnPlay.Clicked += BtnPlay_Clicked;
		}

        private void BtnPlay_Clicked(object serder, EventArgs e)
        {
            EjecutarAudio("Audio.mp3");

        }

        private void EjecutarAudio(string v)
        {
            DependencyService.Get<IAudio>().PlayAudioFile("Audio.mp3");
        }
       
    }
}
