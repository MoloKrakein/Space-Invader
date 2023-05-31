using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInput : MonoBehaviour
{
    // Movement enemyMovement;
    private Rigidbody2D rb;
    private int movementDirection;

    // Start is called before the first frame update
    void Awake()
    {
        // enemyMovement = GetComponent<Movement>();
        // if (enemyMovement == null) {
        //     Debug.Log("Movement script not found on " + gameObject.name);
        // }

        // set speed
        
    }

    public void setEnemyDirection(int direction){
        movementDirection = direction;
    }

    public void setEnemySpeed(float newSpeed){
        // enemyMovement.SetSpeed(newSpeed);
    }
    // Update is called once per frame
    void Update()
    {
        // if (movementDirection == 1) {
        //     // enemyMovement.Up();
        //     enemyMovement.Move(Vector3.up);
        // }

        // if (movementDirection == 2) {
        //     // enemyMovement.Left();
        //     enemyMovement.Move(Vector3.left);
        // }

        // if (movementDirection == 3) {
        //     // enemyMovement.Down();
        //     enemyMovement.Move(Vector3.down);
        // }

        // if (movementDirection == 4) {
        //     // enemyMovement.Right();
        //     enemyMovement.Move(Vector3.right);
        // }

        // if (Input.GetKeyDown(KeyCode.W)||Input.GetKeyDown(KeyCode.UpArrow)) {
        //     // enemyMovement.Up();
        //     StartCoroutine(enemyMovement.Move(Vector3.up));
        // }
            
        // if (Input.GetKeyDown(KeyCode.A)||Input.GetKeyDown(KeyCode.LeftArrow)) {
        //     // enemyMovement.Left();
        //     StartCoroutine(enemyMovement.Move(Vector3.left));
        // }

        // // if (Input.GetKeyDown(KeyCode.S)||Input.GetKeyDown(KeyCode.DownArrow)) {
        // //     // enemyMovement.Down();
        // //     StartCoroutine(enemyMovement.Move(Vector3.down));
        // // }

        // if (Input.GetKeyDown(KeyCode.D)||Input.GetKeyDown(KeyCode.RightArrow)) {
        //     // enemyMovement.Right();
        //     StartCoroutine(enemyMovement.Move(Vector3.right));
        // }
        // update player speed
        // playerMovement.SetSpeed(float newSpeed);
    }
}
