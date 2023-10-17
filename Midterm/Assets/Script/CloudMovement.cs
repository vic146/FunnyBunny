using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMovement : MonoBehaviour
{

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -6){
            float randomX;
            float randomY;
            float speed;
            speed = Random.Range(1,15);
            randomX = Random.Range(-9,9); 
            randomY = Random.Range(7, 15); 
            Vector3 newY = new Vector3(randomX,randomY, 0); 
            transform.position = newY; 
            rb.MovePosition(transform.position*speed);
        }
        
    }
}
