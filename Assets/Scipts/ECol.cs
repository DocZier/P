using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ECol : MonoBehaviour
{
    public GameObject e;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            Destroy(gameObject);
            GameObject g = Instantiate(e);
            g.transform.position = collision.gameObject.transform.position;
            Destroy(g, 0.5f);
        }
    }
}
