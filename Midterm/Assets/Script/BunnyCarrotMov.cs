using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnyCarrotMov : MonoBehaviour
{

    DiscreteMovement movement;
    ProjectileThrower projectileThrower; 

    float tim;
    int timerr;
    float randomX;
    float randomY; 

    void Awake()
        {
            movement = GetComponent<DiscreteMovement>();
            projectileThrower = GetComponent<ProjectileThrower>();
        }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        randomX = Random.Range(-9,9);
        randomY = Random.Range(6,10); 

        Vector3 vel = Vector3.zero;
        vel.x = randomX;
        vel.y = randomY;

        tim += 1* Time.deltaTime;
        timerr = Mathf.RoundToInt(tim);

        if(timerr%5 == 0 ){
            transform.position = vel;
        }

        if(timerr%5 == 0){
            projectileThrower.Throw();
            tim++;
        }
        
    }
}
