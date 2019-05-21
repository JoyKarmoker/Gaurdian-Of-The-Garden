using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuManager : MonoBehaviour
{
    public GameObject pauseMenuPanel;
    public static bool gameIsPaused = false;
    int sceneNumber;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenuPanel.SetActive(true);
            gameIsPaused = true;
            Pause();
        }
    }

    public void PauseButtonPressed()
    {
        Debug.Log("hdsf");
        pauseMenuPanel.SetActive(true);
        gameIsPaused = true;
        Pause();
    }

    public void Resume()
    {
        gameIsPaused = false;
        pauseMenuPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    void Pause()
    {
        Time.timeScale = 0f;
    }

    public void Restart()
    {
        sceneNumber = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void HomeButton()
    {
        SceneManager.LoadScene(1);
    }


}
