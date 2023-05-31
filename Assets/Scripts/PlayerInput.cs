using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour, IMoveable, IBoundsCheckable
{
    private IMoveable playerMovement;
    private float speed;

    
    private void Awake()
    {
        playerMovement = GetComponent<IMoveable>();
    }
    
    public void SetPlayerMovement(IMoveable movement)
    {
        playerMovement = movement;
    }

    void Update()
    {
        // get input
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        // move player
        Vector3 direction = new Vector3(horizontalInput, verticalInput, 0);
        playerMovement.Move(direction);
    }

    public void Move(Vector3 direction)
    {
        // call movescript from movement
        SetPlayerMovement(GetComponent<Movement>());

    }

    public void SetSpeed(float NewSpeed)
    {
        speed = NewSpeed;
    }

    public void SetVelocity(Vector3 velocity)
    {
        throw new System.NotImplementedException();
    }

    public void Stop()
    {
        throw new System.NotImplementedException();
    }

    public void OnOutOfBounds()
    {
        // if player is out of bounds, stop player
        playerMovement.Stop();
    }
}