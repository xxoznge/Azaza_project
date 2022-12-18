using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Controller : MonoBehaviour
{
    public GameObject DoorPivot;

    private void OnTriggerEnter(Collider other)
    {
        DoorPivot.GetComponent<Animator>().SetInteger("Door_State", 1);
    }
   
    private void OnTriggerExit(Collider other)
    {
        DoorPivot.GetComponent<Animator>().SetInteger("Door_State", 2);
    }
}
