using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnPlayerTrigger : MonoBehaviour
{
    [SerializeField]
    private UnityEvent playerEnterEvent;
    [SerializeField]
    private UnityEvent playerExitEvent;
    private void OnTriggerEnter(Collider o)
    {
        if (o.tag == "Player")
        {
            playerEnterEvent.Invoke();
        }
    }
    private void OnTriggerExit(Collider o)
    {
        if (o.tag == "Player")
        {
            playerExitEvent.Invoke();
        }
    }
}
