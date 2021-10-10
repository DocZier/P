using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EControl : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    private Rigidbody2D rb2d;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 v = Vector2.left * speed;
        v.y = rb2d.velocity.y;
        rb2d.velocity = v;
    }
}
