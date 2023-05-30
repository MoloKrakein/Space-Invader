using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMainScript : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] int health;

    private Rigidbody2D rb;

    Health healthScript;
    PlayerInput playerInput; //movement script

    private void Start() {
        // initialize health
        Health healthScript = GetComponent<Health>();
        if (healthScript != null) {
            healthScript.SetCurrentHealth(health);
        } else {
            Debug.LogError("Health script not found on " + gameObject.name);
        }

        // initialize movement
        rb = GetComponent<Rigidbody2D>();
        if (rb == null) {
            Debug.LogError("Rigidbody2D not found on " + gameObject.name);
        }
    }

    private void Awake() {
        playerInput = GetComponent<PlayerInput>();
        if (playerInput == null) {
            Debug.LogError("PlayerInput script not found on " + gameObject.name);
        }
    }

    
}
