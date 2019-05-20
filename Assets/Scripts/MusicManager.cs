using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour
{
    public AudioClip[] levelMusicChangeArray;
    private AudioSource audioSource;
    bool fuck = false;
    float volume;
    private OptionsController optionsController;
    
 
    // Start is called before the first frame update
    private void Awake()
    {
 
        DontDestroyOnLoad(gameObject);
      
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();

     }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeVolume(float volume)
    {
        audioSource.volume = volume;
        // PlayerPrefsManager.SetMasterVolume(volume);
    }

    public void SetVolume(float volume)
    {
        audioSource.volume = volume;
        
    }

    private void OnLevelWasLoaded(int level)
    {
        if (level == 2)
        {
            DontDestroyOnLoad(audioSource);

            fuck = true;
        }

        else if (level == 1 && fuck == true)
        {
            DontDestroyOnLoad(audioSource);


        }

        else
        {
            AudioClip thisLevelMuisc = levelMusicChangeArray[level];
            audioSource.clip = thisLevelMuisc;
            audioSource.loop = true;
            audioSource.Play();

        }


    }

}
