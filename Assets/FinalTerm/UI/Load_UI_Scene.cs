using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_UI_Scene : MonoBehaviour
{
    public Object SceneToLoad;
    private void GetKeyDown()
    {
        //SceneManager.LoadScene("LoadSceneText02");
        SceneManager.LoadScene(SceneToLoad.name);
    }
}
