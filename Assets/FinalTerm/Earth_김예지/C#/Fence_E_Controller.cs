using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fence_E_Controller : MonoBehaviour
{
    public GameObject DoorPivot;

    private void OnTriggerEnter(Collider other)
    {
        DoorPivot.GetComponent<Animator>().SetInteger("Fence", 1);
    }

    private void OnTriggerExit(Collider other)
    {
        DoorPivot.GetComponent<Animator>().SetInteger("Fence", 2);
    }
}
