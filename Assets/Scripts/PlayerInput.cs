using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private Movement playerMovement;

    // Start is called before the first frame update
    void Awake()
    {
        playerMovement = GetComponent<Movement>();
        if (playerMovement == null) {
            Debug.Log("Movement script not found on " + gameObject.name);
        }

        // set speed
        
    }


    public void setPlayerSpeed(float newSpeed){
        playerMovement.SetSpeed(newSpeed);
    }
    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.W)||Input.GetKeyDown(KeyCode.UpArrow)) {
        //     // playerMovement.Up();
        //     StartCoroutine(playerMovement.Move(Vector3.up));
        // }
            
        if (Input.GetKeyDown(KeyCode.A)||Input.GetKeyDown(KeyCode.LeftArrow)) {
            // playerMovement.Left();
            StartCoroutine(playerMovement.Move(Vector3.left));
        }

        // if (Input.GetKeyDown(KeyCode.S)||Input.GetKeyDown(KeyCode.DownArrow)) {
        //     // playerMovement.Down();
        //     StartCoroutine(playerMovement.Move(Vector3.down));
        // }

        if (Input.GetKeyDown(KeyCode.D)||Input.GetKeyDown(KeyCode.RightArrow)) {
            // playerMovement.Right();
            StartCoroutine(playerMovement.Move(Vector3.right));
        }
        // update player speed
        // playerMovement.SetSpeed(float newSpeed);
    }
}
