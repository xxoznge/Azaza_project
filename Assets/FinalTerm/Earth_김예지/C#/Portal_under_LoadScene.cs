using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal_under_LoadScene : MonoBehaviour
{
    public Object SceneToLoad;
    private void OnMouseDown()
    {
        SceneManager.LoadScene(SceneToLoad.name);
    }
}
