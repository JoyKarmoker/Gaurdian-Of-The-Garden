using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalSceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Winner()
    {
        SceneManager.LoadScene(6);
    }

    public void Losser()
    {
        SceneManager.LoadScene(7);
    }
}
