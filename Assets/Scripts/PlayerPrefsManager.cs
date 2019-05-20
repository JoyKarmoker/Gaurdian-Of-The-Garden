using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsManager : MonoBehaviour
{
    const string MASTER_VOLUME_KEY = "master_volume";
    const string DIFFICULTY_KEY = "difficulty";
    const string LEVEL_KEY = "Level_unlocked_";

    public static void SetMasterVolume(float volume)
    {
        if(volume >=0f && volume <=1f)
        {
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
        }
        else
        {
            Debug.LogError("Volume out of range");
        }
    }

    public static float GetMasterVolume()
    {
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
    }

    /*public static void UnlockLevel(int level)
    {
        if(level <= Application.levelCount - 1)
        {
            PlayerPrefs.SetInt(LEVEL_KEY + level.ToString() , 1);
        }
        else
        {
            Debug.LogError("Trying to unlock level outside build settings");
        }
    }*/

   /* public static bool IsLevelUnlocked(int level)
    {
        int levelvalue = PlayerPrefs.GetInt(LEVEL_KEY + level.ToString());
        bool IsLevelUnlocked = (levelvalue == 1);
        if (level <= Application.levelCount - 1)
        {

            return IsLevelUnlocked;
        }
        else
        {
            Debug.LogError("Trying to unlock level outside build settings");
            return false;
        }
    }*/

        public static void  SetDifficulty(float difficulty)
        {
            if(difficulty >=1f && difficulty <=3f)
            {
                PlayerPrefs.SetFloat(DIFFICULTY_KEY, difficulty);
            }

            else
            {
                Debug.LogError("Difficulty out of bound");
            }
        }

    public static float GetDifficulty()
    {
        return PlayerPrefs.GetFloat(DIFFICULTY_KEY);
    }


 }

