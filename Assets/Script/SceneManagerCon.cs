using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SceneManagerCon : MonoBehaviour
{
    // Start is called before the first frame update
    public Pause p;
    private bool flagPause = false;

    [SerializeField]
    private UnityEvent PauseOn;
    [SerializeField]
    private UnityEvent PauseOff;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!flagPause)
            {
                PauseOn.Invoke();

            }
            else
            {
                PauseOff.Invoke();

            }
            flagPause = !flagPause;
        }

    }
}
