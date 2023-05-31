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

    private bool isShooting = false;
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
        // create bullet at player position + 1 unit up
        GameObject bullet = Instantiate(bulletPrefab, transform.position + Vector3.up, Quaternion.identity);
        // set bullet direction
        // Bullet bulletScript = bullet.GetComponent<Bullet>();
        Bullet bulletScript = bullet.GetComponent<Bullet>();
        if (bulletScript == null) {
            Debug.LogError("Bullet script not found on " + bullet.name);
        }else{
            bulletScript.direction = Vector3.up;
        }
    }
    // shoot delay function
    IEnumerator ShootDelay() {
        yield return new WaitForSeconds(0.5f);
        isShooting = false;
    }
    private void Update() {
        // set speed
        playerInput.setPlayerSpeed(speed);
        // if(healthScript.IsDead()) {
        //     Destroy(gameObject);
        // }

        // press space to shoot only half a second after last shot
        if (Input.GetKeyDown(KeyCode.Space)) {
            if (!isShooting) {
                Shoot();
                isShooting = true;
                StartCoroutine(ShootDelay());
            }
        }
    }


}
