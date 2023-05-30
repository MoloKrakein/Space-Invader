using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float speed;
    private Rigidbody2D rb;
    float defaultSpeed = 5f;

    public Vector3 direction;

    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
        //if speed is not set in inspector, set it to default speed
        if (speed == 0) {
            speed = defaultSpeed;
        }

        if (rb == null) {
            Debug.LogError("Rigidbody2D not found on " + gameObject.name);
        }
    }

    private void Start() {
        rb.velocity = direction * speed;
    }

    private void Update() {
        if(transform.position.magnitude > 1000.0f) {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Enemy")) {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
