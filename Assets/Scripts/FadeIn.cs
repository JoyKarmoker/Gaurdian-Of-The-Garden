using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    public float fadeInTime;
    public Color currentcolor = Color.black;
    public Image fadePanel;
    // Start is called before the first frame update
    void Start()
    {
        fadePanel = GetComponent<Image>();
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
