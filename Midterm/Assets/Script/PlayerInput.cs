using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    DiscreteMovement movement;
    ProjectileThrower projectileThrower;

    void Awake(){
        movement = GetComponent<DiscreteMovement>();
        projectileThrower = GetComponent<ProjectileThrower>();
    }

    void FixedUpdate(){
        Vector3 vel = Vector3.zero;
        if(Input.GetKey(KeyCode.W)){
            vel.y = 1;
        }
        if(Input.GetKey(KeyCode.S)){
            vel.y = -1;
        }
        if(Input.GetKey(KeyCode.A)){
            vel.x = -1;
        }
        if(Input.GetKey(KeyCode.D)){
            vel.x = 1;
        }

        movement.MoveRB(vel);

        
    }

    // Update is called once per frame
    void Update(){
        if(Input.GetKeyDown(KeyCode.Q)){
            projectileThrower.Throw();
        }

    }
    

}
