/*
Simple Sound Manager (c) 2016 Digital Ruby, LLC
http://www.digitalruby.com

Source code may no longer be redistributed in source format. Using this in apps and games is fine.
*/

using UnityEngine;
using UnityEngine.UI;

using System.Collections;

using DigitalRuby.SoundManagerNamespace;

namespace DigitalRuby.SoundManagerNamespace
{
	public class AudioSoundManager : MonoBehaviour
	{
		public AudioSource[] SoundAudioSources;
		public AudioSource[] MusicAudioSources;
		public AudioMute other;

		public void PlaySound(int index)
		{
			SoundAudioSources[index].PlayOneShotSoundManaged(SoundAudioSources[index].clip);
		}

		public void PlayMusic(int index)
		{
			MusicAudioSources[index].PlayLoopingMusicManaged(1.0f, 1.0f, true);
		}


		private void CheckClick()
		{
			//not used anymore
		}

		private void Start()
		{

		}

		private void Update()
		{

		}
		//Alles lautlos
		public void Mute()
		{
			SoundManager.SoundVolume = 0f;
			SoundManager.MusicVolume = 0f;
			other.MuteIt ();
		}
		//alles wieder laut
		public void UnMute()
		{
			SoundManager.SoundVolume = 1f;
			SoundManager.MusicVolume = 1f;
			other.UnMuteIt ();
		}
	}
}
