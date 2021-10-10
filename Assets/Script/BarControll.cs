using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarControll : MonoBehaviour
{
    // Start is called before the first frame update
    private Image i;
    public PlayerResourses p;
    public PlayerResourses Maxp;
    void Start()
    {
        i = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Maxp.GetValue == 0)
            return;
        i.fillAmount = p.GetValue / Maxp.GetValue;
    }
}
