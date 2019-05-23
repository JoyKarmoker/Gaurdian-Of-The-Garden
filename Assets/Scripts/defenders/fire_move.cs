using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire_move : MonoBehaviour
{
     [SerializeField]float speed = 4f;
    public float damage = 50;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var hlth = collision.GetComponent<health>();
        var colider = collision.GetComponent<lizard_move>();
        //Debug.Log(colider);
        if(hlth && colider)
        {
            hlth.Shoot(damage);
            Destroy(gameObject);
        }
        
        

    }
}
