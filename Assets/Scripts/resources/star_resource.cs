using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class star_resource : MonoBehaviour
{
    public void calling_add_star(int newStar)
    {
        FindObjectOfType<stardisplay>().add_star(newStar);
    }
}
