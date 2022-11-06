using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CountdownP : MonoBehaviour
{
 
float currenttime = 0f;
float startingTime= 15f;
     [SerializeField] TMP_Text  countdown;
    // Start is called before the first frame update
    void Start()
    {
        currenttime=startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currenttime -= 1*Time.deltaTime;

        countdown.text=currenttime.ToString("0");

       FindObjectOfType<GarbagebinP>().scorecount();

        if(currenttime <= 0){

            currenttime = 0;

        }

    }

  
}
