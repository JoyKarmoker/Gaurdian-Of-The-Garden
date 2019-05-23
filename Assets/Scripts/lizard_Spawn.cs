using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lizard_Spawn : MonoBehaviour
{
    public lizard_move lm_prefab;
    bool spwan = true;
    [SerializeField]float min_time = 1f;
    [SerializeField]float max_time = 5f;
  
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
        
        lizard_move newLizard = Instantiate(lm_prefab,transform.position,transform.rotation) as lizard_move;
        newLizard.transform.parent = transform;
    }
}
