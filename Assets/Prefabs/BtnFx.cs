using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnFx : MonoBehaviour
{

    public AudioSource buttonSound;
    public AudioClip clickFx;

    public void ClickSound()
    {
        buttonSound.PlayOneShot(clickFx);
    }

}
