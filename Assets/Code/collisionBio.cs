using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class collisionBio : MonoBehaviour
{

    public float maxfallspeed = 10f;
 
    //  int score= 0;
    //  public TMP_Text scoreText ;

    
    private Rigidbody rb;



    //    void OnCollisionEnter(Collision collisionInfo)
    // {

    //     if (collisionInfo.gameObject.tag == "bio")
    //     {

    //         Destroy(collisionInfo.gameObject);

    //         Debug.Log("Bio");
    //         score++;

    //         scoreText.text = score.ToString() ;
            

    //         // Destroy(collision.gameObject);
    //     } 


         


      

    // }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (rb.velocity.magnitude > maxfallspeed)

            rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxfallspeed);
    }
}


