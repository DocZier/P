using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MyGameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void Quit()
    {
        Application.Quit();
    }
    public void LoadScene(string name)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(name);
    }
    public void Save()
    {
        PlayerPrefs.SetString("Current_scene", SceneManager.GetActiveScene().name);
        GameObject p = GameObject.FindGameObjectWithTag("Player");
        if (p)
        {
            PlayerPrefs.SetFloat("player_x", p.transform.position.x);
            PlayerPrefs.SetFloat("player_y", p.transform.position.y);
            PlayerPrefs.SetFloat("player_z", p.transform.position.z);
            PlayerPrefs.SetFloat("player_rY", p.transform.rotation.y);
        }
    }
    public void Load()
    {
        LoadScene(PlayerPrefs.GetString("Current_scene"));
    }
    public void DropSave()
    {
        PlayerPrefs.DeleteAll();
    }
}
