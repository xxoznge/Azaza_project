using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door_LoadScene : MonoBehaviour
{
    public Object SceneToLoad;

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(SceneToLoad.name);
    }
}
