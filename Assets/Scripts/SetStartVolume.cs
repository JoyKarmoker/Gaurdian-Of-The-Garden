using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetStartVolume : MonoBehaviour
{
    private MusicManager musicManger;
    float volume;
    // Start is called before the first frame update
    void Start()
    {
        musicManger = GameObject.FindObjectOfType<MusicManager>();

        if(musicManger)
        {
            Debug.Log("Found " + musicManger);
           // volume = PlayerPrefsManager.GetMasterVolume();
            //musicManger.SetVolume(volume);
            
        }
        else
        {
            Debug.LogWarning("Not found the music manager");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
