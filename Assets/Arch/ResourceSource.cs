using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceSource : MonoBehaviour
{
    public string resourceName;
    public float val;
    public void CollectResource(bool destroyObject)
    {
        PlayerResourses.Find(resourceName).ChangeValue(val);
        if(destroyObject)
        {
            Destroy(gameObject);
        }
    }
}
