using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal_Door_Controller_Tower : MonoBehaviour
{
    public GameObject DoorPivot;

    private void OnTriggerEnter(Collider other)
    {
        DoorPivot.GetComponent<Animator>().SetInteger("Portal_tower", 1);
    }

    private void OnTriggerExit(Collider other)
    {
        DoorPivot.GetComponent<Animator>().SetInteger("Portal_tower", 2);
    }
}
