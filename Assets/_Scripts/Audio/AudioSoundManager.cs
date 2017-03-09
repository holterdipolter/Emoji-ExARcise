﻿/*
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

		public void PlaySound(int index)
		{
			print ("klicksound");
			SoundAudioSources[index].PlayOneShotSoundManaged(SoundAudioSources[index].clip);

		}

		public void PlayMusic(int index)
		{
			print ("klickmusic");
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

		public void SoundVolumeChanged()
		{
			SoundManager.SoundVolume = SoundSlider.value;
		}

		public void MusicVolumeChanged()
		{
			SoundManager.MusicVolume = MusicSlider.value;
		}
	}
}