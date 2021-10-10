using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    // Start is called before the first frame update

   public void PauseOn()
    {
        Time.timeScale = 0;
    }
    public void PauseOff()
    {
        Time.timeScale = 1;
    }
}
