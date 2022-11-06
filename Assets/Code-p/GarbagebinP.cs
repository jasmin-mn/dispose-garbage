using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GarbagebinP : MonoBehaviour
{
  

     int score= 0;
       float currenttime =0f;

float startingTime=15f;
     [SerializeField] TMP_Text  countdown;
      public TMP_Text scoreText ;

       public  GameObject UILevelComplete;
     
    //  public GameObject CountDown;
  public GameObject  LevelLose;
     
    // Start is called before the first frame update
    void Start()
    {
         currenttime=startingTime;
          // rb = GetComponent<Rigidbody>();
    }


      void Update()
    {

         currenttime -= 1*Time.deltaTime;

        countdown.text=currenttime.ToString("0");

          if(currenttime <= 0){

            currenttime = 0;
         scorecount();

        }
    


       
        
    }

      void OnCollisionEnter(Collision collisionInfo)
    {

        if (collisionInfo.gameObject.tag == "plastic")
        {

            Destroy(collisionInfo.gameObject);

            Debug.Log("plastic");

             score++;

            scoreText.text = score.ToString() ;

          

            }
              else if (collisionInfo.gameObject.tag != "plastic")
        {

            Destroy(collisionInfo.gameObject);


             score--;

            scoreText.text = score.ToString() ;

          

            }
        } 

          public void scorecount(){
                 if(score>=3){
                  countdown.enabled=false;
              LevelWon();
              Application.Quit();
                 
              }
            
           else if(score<3 && currenttime==0){
                   LoseGame();
                 Application.Quit();
                
                  countdown.enabled=false;
             }


    }    

      void LoseGame() {
        Debug.Log("TEST");
       
  LevelLose.SetActive(true);

   Application.Quit();
   countdown.enabled=false;

//  UILevelComplete.SetActive(false);

  }
 void LevelWon()
            {

            //   SceneManager.LoadScene("Game1");

             UILevelComplete.SetActive(true);
            //  currenttime=0;
            Application.Quit();
            countdown.enabled=false;
 
            }


  
}
