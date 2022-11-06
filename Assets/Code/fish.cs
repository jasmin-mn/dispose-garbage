using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fish : MonoBehaviour
{

    public float maxfallspeed = 20f;

     private Rigidbody rb;
    // Start is called before the first frame update

    void OnCollisionEnter(Collision other) {
          if (other.gameObject.tag == "ground")
        {

            Destroy(gameObject);

            Debug.Log("Bio");
         
            

            // Destroy(collision.gameObject);
        } 
    }
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
