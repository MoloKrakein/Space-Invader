using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInput : MonoBehaviour
{
    Movement enemyMovement;
    private Rigidbody2D rb;
    private int movementDirection;

    // Start is called before the first frame update
    void Awake()
    {
        enemyMovement = GetComponent<Movement>();
        if (enemyMovement == null) {
            Debug.Log("Movement script not found on " + gameObject.name);
        }
        // set speed
    }

    public void setEnemySpeed(float newSpeed){
        enemyMovement.SetSpeed(newSpeed);
    }

    // public void updateMovementDirection(int modifer){
    //     movementDirection += modifer;
    //     if (movementDirection > 0) {
    //         enemyMovement.Right();
    //     } else if (movementDirection < 0) {
    //         enemyMovement.Left();
    //     } else {
    //         enemyMovement.Stop();
    //     }
    // }

    private void RandomizeMovement(){
        // randomize movement, when enemy done moving, randomize again
        // int randomNum = Random.Range(0, 2);
        // if (randomNum == 0) {
        //     updateMovementDirection(1);
        // } else {
        //     updateMovementDirection(-1);
        // }
    }
    

    // Update is called once per frame
    void Update()
    {
        // randomize movement, when enemy done moving, randomize again
        RandomizeMovement();
    }

}


