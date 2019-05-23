using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class game_button_ui : MonoBehaviour
{
    [SerializeField] Defender defender_pref;
    private void OnMouseDown()
    {
        var buttons = FindObjectsOfType<game_button_ui>();
        foreach(game_button_ui button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(53,43,43,255); 
        }
        GetComponent<SpriteRenderer>().color = Color.white;
        FindObjectOfType<defender_spawner>().SelectDefender(defender_pref);
    }
}
