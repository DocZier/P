using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EBehavior : MonoBehaviour
{
    public float speed_y;
    private Rigidbody2D rb2d;
    public float time;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Vector2 v = rb2d.velocity;
        v.y = speed_y ;
        rb2d.velocity = v;
        InvokeRepeating("changeDirection", 0, time);
    }

    // Update is called once per frame
    void changeDirection()
    {
        Vector2 v = rb2d.velocity;
        v.y = -v.y;
        rb2d.velocity = v;
            
    }
}
