using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{

    Text scoreText; 
    int score = 0; 
     public void scoreTracker(){
    
        score++ ;
        scoreText.text = score.ToString(); 
        }
     
     
    // Start is called before the first frame update
    void Start()
    {
 scoreText = GetComponent<Text>();

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
