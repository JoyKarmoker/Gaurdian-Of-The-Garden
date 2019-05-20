using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lizard_Spawn : MonoBehaviour
{
    public lizard_move lm_prefab;
    bool spwan = true;
    float min_time = 1f;
    float max_time = 5f;
  
    IEnumerator Start()
    {
        
        while (spwan)
        {
            yield return new WaitForSeconds(Random.Range(min_time, max_time));
            attack();
        }
    }
    void attack()
    {
        
        Instantiate(lm_prefab,transform.position,transform.rotation);
    }
}
