using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinnerScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Playagainbutton()
    {
        SceneManager.LoadScene(1);
    }

    public void Quitbutton()
    {
        Application.Quit();
    }
}
