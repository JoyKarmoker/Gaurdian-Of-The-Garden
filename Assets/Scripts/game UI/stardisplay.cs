using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stardisplay : MonoBehaviour
{
    [SerializeField] int stars = 0;
    [SerializeField]Text startxt;
    private void Start()
    {
        update_display();
    }
    void update_display()
    {
        startxt.text = stars.ToString();
    }
    public bool DoWeHaveStars(int star_amount)
    {
        return stars >= star_amount;
    }
    public void add_star(int newStar)
    {
        stars += newStar;
        update_display();
    }
    public void remove_star(int newStar)
    {
        if(stars >= newStar)
        {
            stars -= newStar;
            update_display();
        }
        
    }
}
