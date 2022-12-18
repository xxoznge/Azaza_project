using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class To_Heaven : MonoBehaviour
{
    public Object SceneToLoad;
    Scene CurrentScene;

    void Start()
    {
        CurrentScene = gameObject.scene;
        print("CurrentScene = " + CurrentScene.name);
    }
    public void OnReTry()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            SceneManager.LoadScene("UI");
        }
        else if (Input.GetKeyDown(KeyCode.U))
        {
            SceneManager.LoadScene("Heaven");
        }
    }
}
