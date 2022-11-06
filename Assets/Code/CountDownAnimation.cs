using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountDownAnimation : MonoBehaviour
{
string bioTag ="bio";
string notbioTag = "notBio";
    public GameObject CountDown;
    // Start is called before the first frame update
   // Rigidbody rigidbody = GetComponent<Rigidbody>();
   void Bio_Able(){
GameObject[]bios=GameObject.FindGameObjectsWithTag(bioTag);
foreach (var item in bios)

{
item.GetComponent<Rigidbody>().isKinematic=true;
 
   
}
 }

  void Bio_Disable(){
   GameObject[]bios=GameObject.FindGameObjectsWithTag(bioTag);
foreach (var item in bios)

{
item.GetComponent<Rigidbody>().isKinematic=false;
 
   
}
      
   }

   //notBioTag

   void NotBio_Able(){

       GameObject[]Notbios=GameObject.FindGameObjectsWithTag(notbioTag);
foreach (var item in Notbios)

{
item.GetComponent<Rigidbody>().isKinematic=true;
 
   
}


   }

     void NotBio_Disable(){

       GameObject[]Notbios=GameObject.FindGameObjectsWithTag(notbioTag);
foreach (var item in Notbios)

{
item.GetComponent<Rigidbody>().isKinematic=false;
 
   
}


   }

  

   void Start()
   {
    StartCoroutine (CountDownRoutine1());
    
Bio_Able();
NotBio_Able();
   //  GameObject.FindWithTag("bio").GetComponent<Rigidbody>().detectCollisions=false;
   // GameObject.FindWithTag("bio").GetComponent<Rigidbody>().isKinematic=true;
   // GameObject.FindWithTag("notBio").GetComponent<Rigidbody>().isKinematic=true;
   // GameObject.FindGameObjectsWithTag("bio").GetComponents<Rigidbody>().isKinematic=true;
   // GameObject.Find("apple").GetComponent<Rigidbody>().isKinematic=true;
   // GameObject.Find("magic_fish").GetComponent<Rigidbody>().isKinematic=true;

   }

   IEnumerator CountDownRoutine1(){

    yield return new WaitForSeconds(1f)
;

   CountDown.GetComponent<TMP_Text>().text ="3";

   CountDown.SetActive(true);

     yield return new WaitForSeconds(1f)
;
      CountDown.SetActive(false);
   CountDown.GetComponent<TMP_Text>().text ="2";

   CountDown.SetActive(true);


        yield return new WaitForSeconds(1f)
;
      CountDown.SetActive(false);
   CountDown.GetComponent<TMP_Text>().text ="1";

   CountDown.SetActive(true);

    yield return new WaitForSeconds(1f)
;
      CountDown.SetActive(false);
   CountDown.GetComponent<TMP_Text>().text ="Go";

    CountDown.SetActive(true);

    GameObject.Find("TrashbinGreen").GetComponent<garbagebin>().enabled=true;
    Bio_Disable();
    NotBio_Disable();
   // GameObject.Find("Countdown").GetComponent<Countdown>().enabled=true;
  
   }
   }


   

