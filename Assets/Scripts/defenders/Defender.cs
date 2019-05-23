using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] int costOfStars = 100;

    public int GetCost()
    {
        return costOfStars;
    }
    public void calling_add_star(int newStar)
    {
        FindObjectOfType<stardisplay>().add_star(newStar);
    }
}
