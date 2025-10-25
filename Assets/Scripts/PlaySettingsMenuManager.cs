using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaySettingsMenuManager : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            SceneManager.LoadScene(0);
        }
    }
}