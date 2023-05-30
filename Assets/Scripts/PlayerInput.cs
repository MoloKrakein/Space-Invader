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
            Debug.LogError("Movement script not found on " + gameObject.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //get player input using unity's new input system

        //get horizontal input
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        //get vertical input
        float verticalInput = Input.GetAxisRaw("Vertical");

        if (horizontalInput > 0) {
            playerMovement.Right();
        } else if (horizontalInput < 0) {
            playerMovement.Left();
        } else if (verticalInput > 0) {
            playerMovement.Up();
        } else if (verticalInput < 0) {
            playerMovement.Down();
        } else {
            playerMovement.Stop();
        }
    }
}
