using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patroll : MonoBehaviour
{
    public Transform[] points;
    private AIController c;
    public bool flagP;
    // Start is called before the first frame update
    void Start()
    {
        c = GetComponent<AIController>();
    }
    private int i = 0;
    // Update is called once per frame
    void Update()
    {
        var v = (transform.position - points[i].position);
        if (Mathf.Abs(v.x) < 1 && Mathf.Abs(v.z) < 1 && flagP) 
        {
            i++;
            if (points.Length != 0)
            {
                i %= points.Length;
            }
            c.tar = points[i];
        }
        else if (flagP)
        {
            c.tar = points[i];
        }
    }
}
