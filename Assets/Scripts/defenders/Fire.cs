using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject projectile,fire;
    lizard_Spawn myLaneSpawner;
    Animator animator;
    private void Start()
    {
        SetSpawner();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        //Debug.Log("update");
        if(IsAttakerInLane()==1)
        {
            animator.SetBool("isAttacking", true);
        }
        else
        {
            animator.SetBool("isAttacking", false);
        }
    }

    private int IsAttakerInLane()
    {
        //Debug.Log(myLaneSpawner.transform.childCount);
        if (myLaneSpawner.transform.childCount <= 0)
        {
            
            return 0;
        }
        else
            return 1;
    }

    void Shoot()
    {
        Instantiate(projectile, fire.transform.position, transform.rotation);
    }

    void SetSpawner()
    {
        lizard_Spawn[] spawners = FindObjectsOfType<lizard_Spawn>();
        foreach(lizard_Spawn spawner in spawners)
        {
            //Debug.Log("enemy= "+(int)spawner.transform.position.y);
            //Debug.Log("my pos= "+(int)transform.position.y);
            bool IsCloseEnough = (Mathf.Abs((int)spawner.transform.position.y - (int)transform.position.y) <= Mathf.Epsilon);
            

            if (IsCloseEnough)
            {
                myLaneSpawner = spawner;
            }
        }
    }
}
