using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionsController : MonoBehaviour
{
    public Slider volumeSlider;
    public LevelLoaderForOptionScene levelLoader;
    private MusicManager musicManager;
    public 

    // Start is called before the first frame update
    void Start()
    {
        musicManager = GameObject.FindObjectOfType<MusicManager>();
        // Debug.Log(musicManager);
        volumeSlider.value = PlayerPrefsManager.GetMasterVolume();
    }

    // Update is called once per frame
    void Update()
    {
        musicManager.ChangeVolume(volumeSlider.value);
    }

    public void SaveAndExit()
    {
        PlayerPrefsManager.SetMasterVolume(volumeSlider.value);
        //public AudioClip = musicManager.levelMusicChangeArray[0];

        levelLoader.BackButton();
    }
}
