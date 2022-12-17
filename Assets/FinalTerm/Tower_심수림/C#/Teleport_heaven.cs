using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport_heaven : MonoBehaviour
{
    public GameObject PlayerMove;

    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
       PlayerMove.transform.position = new Vector3 (27.59f, 83.03f, -29.11f);
        //Vector3.MoveTowards(transform.position, destination, 1);
    }
}
