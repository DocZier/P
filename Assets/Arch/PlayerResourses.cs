using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerResourses : MonoBehaviour
{
    public static PlayerResourses Find(string name)
    {
        foreach (var res in FindObjectsOfType<PlayerResourses>())
        {
            if (res.resourceName == name)
            {
                return res;
            }
        }
        return null;
    }
    [SerializeField]
    private float val;
    public string resourceName;
    public void ChangeValue(float change)
    {
        val +=change;
        if (ValueChangeEvent != null)
        {
            ValueChangeEvent(change);
        }
    }
    public float GetValue
    {
        get 
        {
            return val;
        }
       
    }
    public event Action<float> ValueChangeEvent;
}
