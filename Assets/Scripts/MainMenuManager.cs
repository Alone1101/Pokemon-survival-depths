using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (AudioManager.Instance != null)
            {
                AudioManager.Instance.PlaySelectSound();
            }
            SceneManager.LoadScene(1);
        }
    }

    void Start()
    {
    Debug.Log("MainMenuManager Started");
    Debug.Log("AudioManager Instance: " + (AudioManager.Instance != null ? "EXISTS" : "NULL"));
    
    if (AudioManager.Instance != null)
    {
        Debug.Log("Music Source: " + (AudioManager.Instance.musicSource != null ? "EXISTS" : "NULL"));
        Debug.Log("SFX Source: " + (AudioManager.Instance.sfxSource != null ? "EXISTS" : "NULL"));
        Debug.Log("Main Menu Music: " + (AudioManager.Instance.mainMenuMusic != null ? AudioManager.Instance.mainMenuMusic.name : "NULL"));
        Debug.Log("Select Sound: " + (AudioManager.Instance.selectSound != null ? AudioManager.Instance.selectSound.name : "NULL"));
    }
    }
}