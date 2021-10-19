using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{

    float CurrentTime;
    public float StartingTimeInSeconds;
    [SerializeField] Text CountdownText;
    // Start is called before the first frame update
    void Start()
    {
        CurrentTime = StartingTimeInSeconds;
    }

    // Update is called once per frame
    void Update()
    {
        CurrentTime -= 1 * Time.deltaTime;
        CountdownText.text = CurrentTime.ToString("0");

        if(CurrentTime <= 0)
        {
            CurrentTime = 0;
            //Game Manager, say the game has ended. 
        }
    }
}
