using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    }

    public void Level1Button()
    {
        Debug.Log("Level 1 Button Pressed");
    }

    public void Level2Button()
    {
        Debug.Log("Level 2 Button Pressed");
    }

    public void Level3Button()
    {
        Debug.Log("Level 3 Button Pressed");
    }
}
