using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioClip[] levelMusicChangeArray;
    private AudioSource audioSource;
    // Start is called before the first frame update
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        Debug.Log("Dont Destroy on load: " + name);
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
    }

    private void OnLevelWasLoaded(int level)
    {
        AudioClip  thisLevelMuisc = levelMusicChangeArray[level];
        Debug.Log("Playing : " + thisLevelMuisc);
        audioSource.clip = thisLevelMuisc;
        audioSource.loop = true;
        audioSource.Play();
    }

}
