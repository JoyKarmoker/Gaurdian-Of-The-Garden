using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lIZARD : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otherobject = collision.gameObject;
        if ( collision.GetComponent<Defender>())
        {
            GetComponent<lizard_move>().Attack(otherobject);
        }
    }
}
