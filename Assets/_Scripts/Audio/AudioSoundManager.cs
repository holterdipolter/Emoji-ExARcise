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
		public Slider SoundSlider;
		public Slider MusicSlider;
		public InputField SoundCountTextBox;
		public Toggle PersistToggle;

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
			/*
			if (Input.GetMouseButtonUp(1)) {

				PlayMusic (0);
			}
			if (Input.GetMouseButtonDown(0)){
				PlaySound(0);
				PlayMusic(1);
			}
*/
		}

		private void Start()
		{

		}

		private void Update()
		{
			//CheckClick();
		}

		public void Mute()
		{
			SoundManager.SoundVolume = 0f;
			SoundManager.MusicVolume = 0f;
			other.MuteIt ();
		}

		public void UnMute()
		{
			SoundManager.SoundVolume = 1f;
			SoundManager.MusicVolume = 1f;
			other.UnMuteIt ();
		}
	}
}
