using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionNotBio : MonoBehaviour
{

    public float maxfallspeed = 20f;

      void OnCollisionEnter(Collision other) {
          if (other.gameObject.tag == "ground")
        {

            Destroy(gameObject);

      
         
            

            // Destroy(collision.gameObject);
        } 
    }


    private Rigidbody rb;

//    int lifeTime = 3;
  void Start()
 {
       rb = GetComponent<Rigidbody>();
    //  StartCoroutine(WaitThenDie());
 }
//  IEnumerator WaitThenDie()
//  {
//      yield return new WaitForSeconds(lifeTime);
//      Destroy(gameObject);
//  }
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.magnitude > maxfallspeed)

            rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxfallspeed);
    }
}
