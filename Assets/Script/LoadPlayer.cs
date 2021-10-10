using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class LoadPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        transform.transform.position =  new Vector3(
                           PlayerPrefs.GetFloat("player_x"),
                           PlayerPrefs.GetFloat("player_y"),
                           PlayerPrefs.GetFloat("player_z"));
       
        transform.rotation = Quaternion .Euler(new Vector3(0, PlayerPrefs.GetFloat("player_ry")+180,0));
    }
    // Update is called once per frame
    int i = 0;
    void Update()
    {

         i++;
         if(i>=1)
         {
             GetComponent<LoadPlayer>().enabled = false;
             GetComponent<FirstPersonController>().enabled = true;
         }

    }
}
