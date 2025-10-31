using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingsManager : MonoBehaviour
{

    [Header("Volume Sliders")]
    public Slider masterVolumeSlider;
    public Slider musicVolumeSlider;
    public Slider sfxVolumeSlider;
    
    void Start()
    {
        LoadVolumeSettings();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            SceneManager.LoadScene(1);
        }
    }

     public void OnMasterVolumeChanged(float value)
    {
        if (AudioManager.Instance != null)
        {
            AudioManager.Instance.SetMasterVolume(value);
        }
    }
    
    /*public void OnMusicVolumeChanged(float value)
    {
        if (AudioManager.Instance != null)
        {
            AudioManager.Instance.SetMusicVolume(value);
        }
    }*/
    
    public void OnSFXVolumeChanged(float value)
    {
        if (AudioManager.Instance != null)
        {
            AudioManager.Instance.SetSFXVolume(value);
        }
    }

      void LoadVolumeSettings()
    {
        float masterVolume = PlayerPrefs.GetFloat("MasterVolume", 0.7f);
        float musicVolume = PlayerPrefs.GetFloat("MusicVolume", 0.7f);
        float sfxVolume = PlayerPrefs.GetFloat("SFXVolume", 0.7f);
        
        if (masterVolumeSlider != null) masterVolumeSlider.value = masterVolume;
        if (musicVolumeSlider != null) musicVolumeSlider.value = musicVolume;
        if (sfxVolumeSlider != null) sfxVolumeSlider.value = sfxVolume;
    }

    public void OnMusicVolumeChanged(float value)
    {
        Debug.Log("Music slider changed to: " + value);
        
        if (AudioManager.Instance != null)
        {
            Debug.Log("AudioManager found! Current music volume: " + AudioManager.Instance.musicSource.volume);
            AudioManager.Instance.SetMusicVolume(value);
            Debug.Log("After setting - music volume: " + AudioManager.Instance.musicSource.volume);
        }
        else
        {
            Debug.LogError("AudioManager.Instance is NULL!");
        }
    }
}