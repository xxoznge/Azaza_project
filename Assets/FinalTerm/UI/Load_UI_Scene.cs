using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Load_UI_Scene : MonoBehaviour
{
    public Object SceneToLoad;
    public void OnReTry()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            SceneManager.LoadScene("UI");
        }
        else if (Input.GetKeyDown(KeyCode.U))
        {
            SceneManager.LoadScene("UnderGround");
        }
    }
}
