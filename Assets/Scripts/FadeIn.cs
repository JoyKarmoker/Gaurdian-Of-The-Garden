using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeIn : MonoBehaviour
{
     float fadeInTime = 2f;
    public Color currentcolor = Color.black;
    public Image fadePanel;
    // Start is called before the first frame update

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        fadePanel = GetComponent<Image>();
        gameObject.SetActive(true);
    }
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.timeSinceLevelLoad < fadeInTime)
        {
            // fade In
            float alphaChange = Time.deltaTime/fadeInTime;
            currentcolor.a = currentcolor.a - alphaChange;
            fadePanel.color = currentcolor;
            
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
