using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class DangerZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider o)
    {
        if (o.tag == "Player")
        {
            GetComponent<AICharacterControl>().target = o.transform;
        }
    }
    private void OnTriggerExit(Collider o)
    {
        if (o.tag == "Player")
        {
            GetComponent<AICharacterControl>().target = null;
        }
    }
}
