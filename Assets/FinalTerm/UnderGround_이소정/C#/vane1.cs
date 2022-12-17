using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vane1 : MonoBehaviour
{
    // Start is called before the first frame update
    Animator Anim;

    void Start()
    {
        Anim = GetComponent<Animator>();
        Anim.speed = 0;
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Anim.speed == 0)
            {
                Anim.speed = 1;
            }
            else
            {
                Anim.speed = 0;
            }
        }
    }
}
