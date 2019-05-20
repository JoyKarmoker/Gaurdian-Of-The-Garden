using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionsController : MonoBehaviour
{
    public Slider volumeSlider, difficultySlider;
    public LevelLoaderForOptionScene levelLoader;
    private MusicManager musicManager;
   //private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        //audioSource = GetComponent<AudioSource>();
        musicManager = GameObject.FindObjectOfType<MusicManager>();
        // Debug.Log(musicManager);
        volumeSlider.value = PlayerPrefsManager.GetMasterVolume();
        difficultySlider.value = PlayerPrefsManager.GetDifficulty();
    }

    // Update is called once per frame
    void Update()
    {
        musicManager.ChangeVolume(volumeSlider.value);
    }

    public void SaveAndExit()
    {
        PlayerPrefsManager.SetMasterVolume(volumeSlider.value);
        
        PlayerPrefsManager.SetDifficulty(difficultySlider.value);

        levelLoader.BackButton();
    }

    public void SetDefaults()
    {
        volumeSlider.value = 0.5f;
        difficultySlider.value = 2f;
    }

}
