using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector2 board;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(transform.position.x) > board.x)
        {
            Vector2 v = transform.position;
            v.x = -board.x * (transform.position.x >= 0 ? 1 : -1);
            transform.position = v;
        }
        if (Mathf.Abs(transform.position.y) > board.x)
        {
            Vector2 v = transform.position;
            v.y = -board.y * (transform.position.y >= 0 ? 1 : -1);
            transform.position = v;
        }
    }
}
