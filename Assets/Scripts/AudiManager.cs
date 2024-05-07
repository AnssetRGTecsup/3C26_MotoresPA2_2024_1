using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource backgroundMusicAudioSource; // AudioSource para la música de fondo
    [SerializeField] private AudioSource soundEffectAudioSource; // AudioSource para la música de fondo
    public static AudioManager Instance;

    private void Awake()
    {
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
    public void PlayBackgroundMusic(string musicTitle)
    {
        

    }

}
