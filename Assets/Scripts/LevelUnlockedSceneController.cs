using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelUnlockedSceneController : MonoBehaviour
{
    public GameObject[] coverPanel;
    int level = 2;
    // Start is called before the first frame update
    void Start()
    {

        //PlayerPrefsManager.UnlockLevel(3);
       //PlayerPrefsManager.Check();
        foreach (GameObject panel in coverPanel)
        {
            if (PlayerPrefsManager.IsLevelUnlocked(level))
            {
                panel.SetActive(false);
            }

            else
            {
                panel.SetActive(true);
            }

            level++;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(1);
        }
    }


    public void Level1Button()
    {
        SceneManager.LoadScene(4);
        Debug.Log("Level 1 Button Pressed");
    }

    public void Level2Button()
    {
        SceneManager.LoadScene(5);
        Debug.Log("Level 2 Button Pressed");
    }

    public void Level3Button()
    {
        SceneManager.LoadScene(6);
        Debug.Log("Level 3 Button Pressed");
    }
}
