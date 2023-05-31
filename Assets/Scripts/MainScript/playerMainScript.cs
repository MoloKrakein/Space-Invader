using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMainScript : MonoBehaviour
{
    // [SerializeField] float speed;
    [SerializeField] float shootDelay;
    [SerializeField] int health;
    [SerializeField] int maxHealth;

    public GameObject bulletPrefab;
    private Rigidbody2D rb;

    private bool isShooting = false;
    Health healthScript;
    PlayerInput playerInput; // movement script
    IMoveable movement; // reference to IMoveable interface

    private void Awake()
    {
        healthScript = GetComponent<Health>();
        if (healthScript == null)
        {
            Debug.LogError("Health script not found on " + gameObject.name);
        }
        healthScript.SetCurrentHealth(health);
    }

    private void Start()
    {
        // initialize health
        healthScript = GetComponent<Health>();

        // initialize movement
        playerInput = GetComponent<PlayerInput>();
        if (playerInput == null)
        {
            Debug.LogError("PlayerInput script not found on " + gameObject.name);
        }
        else
        {
            movement = playerInput as IMoveable; // Cast PlayerInput to IMoveable
            if (movement == null)
            {
                Debug.LogError("PlayerInput does not implement IMoveable interface on " + gameObject.name);
            }
        }
    }

    private void Shoot()
    {
        // create bullet at player position + 1 unit up
        GameObject bullet = Instantiate(bulletPrefab, transform.position + Vector3.up, Quaternion.identity);
        // set bullet direction
        Bullet bulletScript = bullet.GetComponent<Bullet>();
        if (bulletScript == null)
        {
            Debug.LogError("Bullet script not found on " + bullet.name);
        }
        else
        {
            bulletScript.direction = Vector3.up;
        }
    }

    // shoot delay function
    IEnumerator ShootDelay()
    {
        yield return new WaitForSeconds(shootDelay);
        isShooting = false;
    }

    private void Update()
    {
        
        // press space to shoot only half a second after last shot
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!isShooting)
            {
                Shoot();
                isShooting = true;
                StartCoroutine(ShootDelay());
            }
        }
    }
}