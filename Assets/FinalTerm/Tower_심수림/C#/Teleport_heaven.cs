using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport_heaven : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        {
        Vector3 destination = new Vector3 (33, 85, -24);
        transform.position = Vector3.MoveTowards(transform.position, destination, 1);
        }
    }
}
