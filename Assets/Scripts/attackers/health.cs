using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    [SerializeField] float Health = 100;
    [SerializeField] GameObject death_vfx;
    public void Shoot(float damage)
    {
        Health -= damage;
        if (Health <= 0)
        {
            TrigerDeathVFX();
            Destroy(gameObject);
            
        }
        
    }
    void TrigerDeathVFX()
    {
        if (!death_vfx)
            return;
        GameObject death_vfxobject = Instantiate(death_vfx,transform.position,Quaternion.identity);
        Destroy(death_vfxobject, 1f);
    }
}
