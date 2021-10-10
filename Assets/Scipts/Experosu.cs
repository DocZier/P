using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Experosu : MonoBehaviour
{
    public GameObject s;
    public float time = 3;
    // Start is called before the first frame update
    void Start()
    {
        GameObject g = Instantiate(s);
        g.transform.position = transform.position;
        Destroy(g, time);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
