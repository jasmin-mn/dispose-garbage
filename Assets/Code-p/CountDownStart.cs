using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CountDownStart : MonoBehaviour
{
   string plasticTag ="plastic";
string notplasticTag = "notplastic";
    public GameObject CountDown;

    public GameObject count15;
    // Start is called before the first frame update
   // Rigidbody rigidbody = GetComponent<Rigidbody>();
   void Plastic_Able(){
GameObject[]plastic=GameObject.FindGameObjectsWithTag(plasticTag);
foreach (var item in plastic)

{
item.GetComponent<Rigidbody>().isKinematic=true;
 
   
}
 }

  void Plastic_Disable(){
   GameObject[]plastic=GameObject.FindGameObjectsWithTag(plasticTag);
foreach (var item in plastic)

{
item.GetComponent<Rigidbody>().isKinematic=false;
 
   
}
      
   }

   //notBioTag

   void plastic_Able(){

       GameObject[]Notplastic=GameObject.FindGameObjectsWithTag(plasticTag);
foreach (var item in Notplastic)

{
item.GetComponent<Rigidbody>().isKinematic=true;
 
   
}


   }


   void Notplastic_Able(){

       GameObject[]Notplastic=GameObject.FindGameObjectsWithTag(notplasticTag);
foreach (var item in Notplastic)

{
item.GetComponent<Rigidbody>().isKinematic=true;
 
   
}


   }
     void Notplastic_Disable(){

       GameObject[]Notplastic=GameObject.FindGameObjectsWithTag(notplasticTag);
foreach (var item in Notplastic)

{
item.GetComponent<Rigidbody>().isKinematic=false;
 
   
}


   }

  

   void Start()
   {
    StartCoroutine (CountDownRoutine1());
    
plastic_Able();
Notplastic_Able();
   
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

    GameObject.Find("TrashbinYellow").GetComponent<movement>().enabled=true;
    GameObject.Find("TrashbinYellow").GetComponent<GarbagebinP>().enabled=true;
    Plastic_Disable();
    Notplastic_Disable();

   

 
   }

    
    
}
