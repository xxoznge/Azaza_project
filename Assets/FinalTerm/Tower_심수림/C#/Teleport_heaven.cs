using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport_heaven : MonoBehaviour
{
    CharacterController characterController;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    private void OnTriggerEnter(Collider other)
    {
       characterController.transform.position = new Vector3 (36.64f, 85.2f, -25.42f); //Vector3.MoveTowards(transform.position, destination, 1);
    }
}
