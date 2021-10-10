using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PControl : MonoBehaviour
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
        Vector2 v;
        v.x = Input.GetAxis("Horizontal");
        v.y = Input.GetAxis("Vertical");
        rb2d.velocity = v*speed;
        if (Input.GetButtonDown("Cancel"))
        {
            Application.Quit();
        }
    }
}
