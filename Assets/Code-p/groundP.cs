using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundP : MonoBehaviour
{
    public float maxfallspeed = 20f;

      void OnCollisionEnter(Collision other) {
          if (other.gameObject.tag == "ground")
        {

            Destroy(gameObject);

        } 
    }


    public Rigidbody rb;

//    int lifeTime = 3;
  void Start()
 {
       rb = GetComponent<Rigidbody>();
   
 }

    void Update()
    {
        if (rb.velocity.magnitude > maxfallspeed)

            rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxfallspeed);
    }
}
