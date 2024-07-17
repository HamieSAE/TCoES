using UnityEngine;
using UnityEngine.SceneManagement;

public class BTNManager : MonoBehaviour
{

    // Method to load a new scene
    public void LoadLevel()
    {
        // Replace "Level" with the name of your scene
        SceneManager.LoadScene("Level");
    }

    // Method to exit the game
    public void ExitGame()
    {
        // If running in the Unity editor, stop playing
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        // If running as a standalone build, quit the application
        Application.Quit();
#endif
    }
}
