using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class defender_spawner : MonoBehaviour
{
    [SerializeField] Defender defender;
    private void OnMouseDown()
    {
        defender_spwaner(GetSquareClicked());
    }
    Vector2 GetSquareClicked()
    {
        Vector2 click_position = new Vector2(Input.mousePosition.x,Input.mousePosition.y);
        //Debug.Log(Camera.main);
        Vector2 world_position = Camera.main.ScreenToWorldPoint(click_position);
        Vector2 fixed_position = fixingGridPosition(world_position);
        
        return fixed_position;
    }
    Vector2 fixingGridPosition(Vector2 world_position)
    {
        float newX = Mathf.RoundToInt(world_position.x);
        float newY = Mathf.RoundToInt(world_position.y);
        return new Vector2(newX, newY+.2f);
    }
    void defender_spwaner(Vector2 final_position)
    {

        Defender new_defender = Instantiate(defender, final_position, Quaternion.identity) as Defender;

    }
    public void SelectDefender(Defender selected_defender)
    {
        defender = selected_defender;
    }
}
