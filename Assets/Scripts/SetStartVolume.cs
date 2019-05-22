using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetStartVolume : MonoBehaviour
{
    private MusicManager musicManger;
    float volume;
    // Start is called before the first frame update

    /*private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        musicManger = GameObject.FindObjectOfType<MusicManager>();
        volume = PlayerPrefsManager.GetMasterVolume();
        musicManger.SetVolume(volume);
    }*/

    void Awake()
    {
        Debug.Log("Loded again main Scene");
    }

    void Start()
    { 

        musicManger = GameObject.FindObjectOfType<MusicManager>();

        if(musicManger)
        {
            Debug.Log("Found xyz " + musicManger);
            volume = PlayerPrefsManager. GetMasterVolume();
            musicManger.SetVolume(volume);
            
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
