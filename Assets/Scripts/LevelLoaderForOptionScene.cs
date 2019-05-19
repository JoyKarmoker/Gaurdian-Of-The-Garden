using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoaderForOptionScene : MonoBehaviour
{


    public void BackButton()
    {
        SceneManager.LoadScene(1);
    }
}
