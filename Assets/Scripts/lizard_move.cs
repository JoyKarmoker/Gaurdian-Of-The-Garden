using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lizard_move : MonoBehaviour
{
     float speed =1f;
    GameObject currentTarget;
   
    void Update()
    {
        transform.Translate(Vector2.left*speed*Time.deltaTime);
    }
    void movespeed(float new_speed)
    {
        speed = new_speed;
    }
    public void Attack(GameObject target)
    {
        GetComponent<Animator>().SetBool("isAttacking", true);
        currentTarget = target;
    }
}
