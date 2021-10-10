using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SaveATM : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private UnityEvent PressE;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            PressE.Invoke();
        }

    }
}
