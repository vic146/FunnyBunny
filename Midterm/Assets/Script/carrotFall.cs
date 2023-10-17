using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carrotFall : MonoBehaviour
{
  ScoreText scoreText; 
    // Start is called before the first frame update
    void Awake()
    {
     scoreText = GameObject.FindGameObjectWithTag("Text").GetComponent<ScoreText>();

    }

    [SerializeField] AudioClip clip;

    void OnTriggerEnter2D(Collider2D col){
        string tag = col.tag; 
       // GetComponent<AudioSource>().pitch = Random.Range(.9f,1.1f);
        //GetComponent<AudioSource>().Play();

        if(tag == "Bunny"){
        AudioSource.PlayClipAtPoint(clip, this.gameObject.transform.position);
        Destroy(this.gameObject);
        scoreText.scoreTracker();
        }

        
    }
    void OnTriggerEnterExit2D(Collider2D other){
        
    }
}
