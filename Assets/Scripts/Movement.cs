using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // class movement
    private float speed;
    private Rigidbody2D rb;
    float defaultSpeed = 5f;

    // private void Awake() {
    //     rb = GetComponent<Rigidbody2D>();


    //     if (speed == 0) {
    //         speed = defaultSpeed;
    //     }

    //     if (rb == null) {
    //         Debug.LogError("Rigidbody2D not found on " + gameObject.name);
    //     }
    // }

    public void SetSpeed(float newSpeed) {
        // if newSpeed is not set in inspector, set it to default speed
        if (newSpeed == 0) {
            newSpeed = defaultSpeed;
        }else{

        speed = newSpeed;
        }
    }

    public void Left() {
        rb.velocity = new Vector2(-speed, 0);
    }

    public void Right() {
        rb.velocity = new Vector2(speed, 0);
    }

    public void Up() {
        rb.velocity = new Vector2(0, speed);
    }

    public void Down() {
        rb.velocity = new Vector2(0, -speed);
    }

    public void Stop() {
        rb.velocity = Vector2.zero;
    }

    public void SetDirection(Vector3 direction) {
        rb.velocity = direction * speed;
    }

    public Vector3 GetDirection() {
        return rb.velocity.normalized;
    }

    public void SetVelocity(Vector3 velocity) {
        rb.velocity = velocity;
    }

    public Vector3 GetVelocity() {
        return rb.velocity;
    }

    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
        //if speed is not set in inspector, set it to default speed
        if (rb == null) {
            Debug.LogError("Rigidbody2D not found on " + gameObject.name);
        }
    }


}
