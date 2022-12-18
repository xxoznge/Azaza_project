using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class SetActive : MonoBehaviour {
 
    private bool state;
    public Text TextComponent;
 
    // Use this for initialization
    void Start () {
        GetComponent<Text>().enabled = true;
    }
    
    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.M))
        {
            GetComponent<Text>().enabled = true;
        }
    }
}