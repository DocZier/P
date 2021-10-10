using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PCol : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.gameObject.tag=="enemy")
        {
            SceneManager.LoadScene("SampleScene");
        }
        if (collision.gameObject.tag == "weaponupgrater")
        {
            gameObject.GetComponentsInChildren<FireControl>()[0].b = collision.gameObject.GetComponent<WeaponUpgrader>().w;
            gameObject.GetComponentsInChildren<FireControl>()[1].b = collision.gameObject.GetComponent<WeaponUpgrader>().w;
        }
    }
}
