using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class Countdown : MonoBehaviour
{

   // public GameObject  Gamelose;
   // public GameObject win;
float currenttime =0f;

float startingTime=15f;
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

       FindObjectOfType<garbagebin>().scorecount();

        if(currenttime <= 0){

            currenttime = 0;

           // Gamelose.SetActive(true);
           // win.SetActive(false);
              
        }

    }

  
}
