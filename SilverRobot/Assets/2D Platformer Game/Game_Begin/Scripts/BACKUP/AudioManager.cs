using System.Collections.Generic;
using UnityEngine;

namespace Udacity.GameDevelopment.PlatformerGame.Game_Begin
{
    
    /// <summary>
    /// Add this to an empty <see cref="GameObject"/>
    /// in your scene to play audio. 
    ///
    /// Or use the existing "AudioManager.prefab" in the project
    /// which uses this class and is already configured
    /// </summary>
    public class AudioManager : MonoBehaviour
    {
        //  Properties ------------------------------------
        public static AudioManager Instance
        {
            get
            {
                return _instance;
            }
            private set
            {
                _instance = value;
            }
        }
        
        
        //  Fields ----------------------------------------
        [SerializeField] 
        private List<AudioSource> _audioSources;
        
        [SerializeField] 
        private List<AudioClip> _audioClips;

        private static AudioManager _instance;
        
        
        //  Unity Methods ---------------------------------
        protected void Awake()
        {
            // Store reference to Game so
            // other classes can access it
            Instance = this;
        }
        
        
        //  Methods ---------------------------------------
        public void PlayAudioClip(string audioClipName)
        {
            
            // Pick default AudioSource
            AudioSource nextAudioSource = _audioSources[0];
            
            
            // Pick the next available AudioSource
            foreach (var audioSource in _audioSources)
            {
                if (!audioSource.isPlaying)
                {
                    nextAudioSource = audioSource;
                    continue;
                }
            }
            
            // Find the AudioClip by name
            foreach (var audioClip in _audioClips)
            {
                if (audioClip.name == audioClipName)
                {
                    nextAudioSource.clip = audioClip;
                    nextAudioSource.Play();
                    return;
                }
            }
            
            // If we get here, the audio clip wasn't found
            // Add the AudioClip in the scene on this GameObject
            Debug.LogError("Audio clip not found: " + audioClipName);
        }
    }
}