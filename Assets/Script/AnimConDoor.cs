using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimConDoor : MonoBehaviour
{
    private Animator a;
    void Start()
    {
        a = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void OpenDoor(string name)
    {
        a.SetBool(name, true);
    }
    public void CloseDoor(string name)
    {
        a.SetBool(name, false);
    }
}
