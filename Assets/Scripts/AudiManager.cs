using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class AudioManager : MonoBehaviour
{

    public AudioMixer audioMixer;

    public string masterVolumeParameter = "Master";
    public string musicVolumeParameter = "Music";
    public string sfxVolumeParameter = "SFX";

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Para que el objeto AudioManager no se destruya al cargar una nueva escena

        }
        else
        {
            Destroy(gameObject);
        }
        // Obtener el AudioSource de la música de fondo si no se ha configurado
        if (backgroundMusicAudioSource == null)
        {
            backgroundMusicAudioSource = GetComponent<AudioSource>();
        }

        if (soundEffectAudioSource == null)
        {
            soundEffectAudioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    public void SetMasterVolume(float volume)
    {
        audioMixer.SetFloat(masterVolumeParameter, volume);
    }
    public void SetMusicVolume(float volume)
    {
        audioMixer.SetFloat(musicVolumeParameter, volume);
    }
    public void SetSFXVolume(float volume)
    {
        audioMixer.SetFloat(sfxVolumeParameter, volume);
    }
    [SerializeField] private AudioSource backgroundMusicAudioSource; // AudioSource para la música de fondo
    [SerializeField] private AudioSource soundEffectAudioSource; // AudioSource para la música de fondo
    public static AudioManager Instance;

    
    public void PlayBackgroundMusic(string musicTitle)
    {
        

    }

}
