using UnityEngine;

public class PauseManager : MonoBehaviour
{
    private bool isPaused = false;
    public GameObject pauseMenuUI; // Reference to the pause menu UI

    void Update()
    {
        // Check if the Escape key is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                // If the game is paused, unpause it
                ResumeGame();
            }
            else
            {
                // If the game is not paused, pause it
                PauseGame();
            }
        }
    }

    void PauseGame()
    {
        // Set the game to paused
        Time.timeScale = 0f;
        isPaused = true;
        // Enable the pause menu UI
        pauseMenuUI.SetActive(true);
    }

    void ResumeGame()
    {
        // Set the game to unpaused
        Time.timeScale = 1f;
        isPaused = false;
        // Disable the pause menu UI
        pauseMenuUI.SetActive(false);
    }
}
