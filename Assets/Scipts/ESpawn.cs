using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ESpawn : MonoBehaviour
{
    public GameObject[] e;
    public float b;
    public float time;
    void Start()
    {
        InvokeRepeating("Spawn", 0, time);
    }
    void Update()
    {
      
    }
    void Spawn()
    {
        int r = Random.Range(0, e.Length);
        float y = Random.Range(-b, b);
        float x = transform.position.x;
        GameObject g = Instantiate(e[r]);
        g.transform.position = new Vector2(x, y);
    }
}
