using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour, IMoveable
{
    // class movement
    // private float speed;
    private Rigidbody2D rb;
    // float defaultSpeed = 0.5f;

    private bool isMoving;
    private Vector3 originalPosition, targetPosition;
    private float timeToMove = 0.1f;

    #region Old movement
    // private Vector3 moveDirection;

    // private void Awake() {
    //     rb = GetComponent<Rigidbody2D>();


    //     if (speed == 0) {
    //         speed = defaultSpeed;
    //     }

    //     if (rb == null) {
    //         Debug.LogError("Rigidbody2D not found on " + gameObject.name);
    //     }
    // }
    // public void SetSpeed(float newSpeed) {
    //     // if newSpeed is not set in inspector, set it to default speed

    //     timeToMove = newSpeed;
    //     defaultSpeed = newSpeed;
        
    // }
#endregion
    #region Old movement

    // public void Left() {
    //     rb.velocity = new Vector2(-speed, 0);
    // }

    // public void Right() {
    //     rb.velocity = new Vector2(speed, 0);
    // }

    // public void Up() {
    //     rb.velocity = new Vector2(0, speed);
    // }

    // public void Down() {
    //     rb.velocity = new Vector2(0, -speed);
    // }

    // public void Stop() {
    //     rb.velocity = Vector2.zero;
    // }

    // public void SetDirection(Vector3 direction) {
    //     rb.velocity = direction * speed;
    // }

    // public Vector3 GetDirection() {
    //     return rb.velocity;
    // }

    // public void SetVelocity(Vector3 velocity) {

    // }

    // public Vector3 GetVelocity() {
    //     return rb.velocity;
    // }

    #endregion
    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
        //if speed is not set in inspector, set it to default speed
        if (rb == null) {
            Debug.LogError("Rigidbody2D not found on " + gameObject.name);
        }
    }

    public IEnumerator MoveScript(Vector3 direction) {
        // only move if not moving
        if (!isMoving) {
            isMoving = true;
            float elapsedTime = 0;
            originalPosition = transform.position;
            targetPosition = originalPosition + direction;

            while (elapsedTime < timeToMove) {
                transform.position = Vector3.Lerp(originalPosition, targetPosition, (elapsedTime / timeToMove));
                elapsedTime += Time.deltaTime;
                yield return null;
            }
            transform.position = targetPosition;
            isMoving = false;
        }
    }


    public void Stop() {
        rb.velocity = Vector2.zero;
    }


    public Vector3 GetVelocity()
    {
        return rb.velocity;
    }

    public void Move(Vector3 direction)
    {
        StartCoroutine(MoveScript(direction));
        Debug.Log("Hi im moving");
        Debug.Log("Speed is " + timeToMove);
    }

    public void SetSpeed(float speed)
    {
        timeToMove = speed;

    }
}
