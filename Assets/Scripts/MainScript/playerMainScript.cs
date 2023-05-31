using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMainScript : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] int health;
    [SerializeField] int maxHealth;

    public GameObject bulletPrefab;
    private Rigidbody2D rb;

    Health healthScript;
    PlayerInput playerInput; //movement script

    private void Awake() {
        Health healthScript = GetComponent<Health>();
        if (healthScript == null) {
            Debug.LogError("Health script not found on " + gameObject.name);
        }
            healthScript.SetCurrentHealth(health);
        
        
    }
    private void Start() {
        // initialize health
        healthScript = GetComponent<Health>();

        // initialize movement
        rb = GetComponent<Rigidbody2D>();
        if (rb == null) {
            Debug.LogError("Rigidbody2D not found on " + gameObject.name);
        }
        playerInput = GetComponent<PlayerInput>();
        if (playerInput == null) {
            Debug.LogError("PlayerInput script not found on " + gameObject.name);
        }

        // set speed
        playerInput.setPlayerSpeed(speed);
        
    }

    private void Shoot() {
        // create bullet
        GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        // set bullet direction
        // Bullet bulletScript = bullet.GetComponent<Bullet>();
        Bullet bulletScript = bullet.GetComponent<Bullet>();
        if (bulletScript == null) {
            Debug.LogError("Bullet script not found on " + bullet.name);
        }else{
            bulletScript.direction = Vector3.up;
        }
    }

    private void Update() {
        // set speed
        playerInput.setPlayerSpeed(speed);
        // if(healthScript.IsDead()) {
        //     Destroy(gameObject);
        // }

        // press space to shoot
        if (Input.GetKeyDown(KeyCode.Space)) {
            Shoot();
        }
    }


}
