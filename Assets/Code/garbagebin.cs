using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class garbagebin : MonoBehaviour
{

 int score= 0;
  public float speed = 70f;
     float currenttime =0f;

float startingTime=15f;
     [SerializeField] TMP_Text  countdown;


     public TMP_Text scoreText ;
     public  GameObject UILevelComplete;
    
     public GameObject AnimationObject;
      public GameObject  Gamelose;
      public GameObject count;


     

     
  
// Start is called before the first frame update
void Start()
    {
      
  
        currenttime=startingTime;
        
    }

    // Update is called once per frame
    
    void Update()
    {

      scorecount();

          
         currenttime -= 1*Time.deltaTime;

        countdown.text=currenttime.ToString("0");

          if(currenttime <= 0){

            currenttime = 0;
            

        }

         
         


        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        transform.Translate(horizontal, 0, vertical);

        

    }

    void OnCollisionEnter(Collision collisionInfo)
    {
 
        if (collisionInfo.gameObject.tag == "bio")
        {

          

         

            Destroy(collisionInfo.gameObject);
            Debug.Log(collisionInfo.gameObject);

            Debug.Log("Bio");

             score++;

            scoreText.text = score.ToString() ;

          

            }
              if (collisionInfo.gameObject.tag == "notBio")
        {

            Destroy(collisionInfo.gameObject);


             score--;

            scoreText.text = score.ToString() ;

          

            }
        } 



        public void scorecount(){
                 if(score>=3){

              LevelWon();
                 
              }
            
           else if(score<3 && currenttime==0){
                 LoseGame();
                 Debug.Log("TestLose");
                //  count.SetActive(false);
                //  Debug.Log(score);
             }
    }      

   void LoseGame() {
  Gamelose.SetActive(true);
   Application.Quit();
   countdown.enabled=false;

//  UILevelComplete.SetActive(false);

  }
 void LevelWon()
            {

             UILevelComplete.SetActive(true);

             
              currenttime=0f;
              // count.SetActive(false);
            Debug.Log("WON");

              Application.Quit();
              countdown.enabled=false;
              
            }


    

   
}
