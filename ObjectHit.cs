using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other){  // Other means the object that colide with me
        GetComponent<MeshRenderer>().material.color = Color.yellow;  // Change the color of the wall when the human bump into a wall
    }
}
