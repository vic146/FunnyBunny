using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerText : MonoBehaviour
{
    Text timerText;
    int seconds = 0;

    // Start is called before the first frame update
    void Start()
    {
        timerText = GetComponent<Text>();
        StartCoroutine(TimerRoutine());
    }

    IEnumerator TimerRoutine(){
        while(true){
            yield return new WaitForSeconds(1);
            seconds += 1;
            timerText.text = seconds.ToString();
        }
        yield return null;

    }
}
