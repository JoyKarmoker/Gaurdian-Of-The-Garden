using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject zucchini,fire;
    


    void Shoot()
    {
        Instantiate(zucchini, fire.transform.position, transform.rotation);
    }

}
