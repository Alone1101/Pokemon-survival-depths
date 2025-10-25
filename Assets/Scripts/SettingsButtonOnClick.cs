using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsButtonOnClick : MonoBehaviour
{  
    public void OnSettingsButton()
    {
        Debug.Log("Loading Settings Menu...");
        SceneManager.LoadScene(2);
    }
}