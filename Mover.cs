using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour{


    [SerializeField] float moveSpeed = 10f;
    
    // Start is called before the first frame update
    void Start(){
        PrintInstructions();
    }

    // Update is called once per frame
    void Update(){
        MovePlayer();
    }

    void PrintInstructions(){
        Debug.Log("Welcome to the game");  // This will print the follow input to the game
        Debug.Log("Move the human to it's goal while doggeing from obstcalse");
    }

    void MovePlayer(){ 
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue, 0, zValue);
    }
}
