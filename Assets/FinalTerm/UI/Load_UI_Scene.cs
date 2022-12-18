using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_UI_Scene : MonoBehaviour
{
    public Object SceneToLoad;

    void OnKeyDown()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            SceneManager.LoadScene(SceneToLoad.name);
        }
    }
}
