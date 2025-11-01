using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    
    [Header("Audio Sources")]
    public AudioSource musicSource;
    public AudioSource sfxSource;
    
    [Header("Audio Clips")]
    public AudioClip mainMenuMusic;
    public AudioClip gameMusic;
    public AudioClip selectSound;
    
    void Awake()
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
    }
    
    void Start()
    {
        ResetToDefaultVolumes();
        LoadVolumeSettings();
        PlayMainMenuMusic();
    }

    void ResetToDefaultVolumes()
    {
        PlayerPrefs.DeleteKey("MasterVolume");
        PlayerPrefs.DeleteKey("MusicVolume");
        PlayerPrefs.DeleteKey("SFXVolume");
    }
    
    public void PlayMainMenuMusic()
    {
        if (mainMenuMusic != null && musicSource != null)
        {
            musicSource.clip = mainMenuMusic;
            musicSource.loop = true;
            musicSource.Play();
        }
    }
    
    public void PlayGameMusic()
    {
        if (gameMusic != null && musicSource != null)
        {
            musicSource.clip = gameMusic;
            musicSource.loop = true;
            musicSource.Play();
        }
    }

    public void PlaySelectSound()
    {
        if (sfxSource != null && selectSound != null)
        {
            sfxSource.PlayOneShot(selectSound, 1.5f);
        }
    }
    
    public void SetMusicVolume(float volume)
    {
        if (musicSource != null)
        {
            musicSource.volume = volume;
            PlayerPrefs.SetFloat("MusicVolume", volume);
        }
    }
    
    public void SetSFXVolume(float volume)
    {
        if (sfxSource != null)
        {
            sfxSource.volume = volume;
            PlayerPrefs.SetFloat("SFXVolume", volume);
        }
    }
    
    public void SetMasterVolume(float volume)
    {
        AudioListener.volume = volume;
        PlayerPrefs.SetFloat("MasterVolume", volume);
    }
    
    void LoadVolumeSettings()
    {
        float masterVolume = PlayerPrefs.GetFloat("MasterVolume", 0.7f);
        float musicVolume = PlayerPrefs.GetFloat("MusicVolume", 0.7f);
        float sfxVolume = PlayerPrefs.GetFloat("SFXVolume", 0.7f);
        
        SetMasterVolume(masterVolume);
        SetMusicVolume(musicVolume);
        SetSFXVolume(sfxVolume);
    }
}