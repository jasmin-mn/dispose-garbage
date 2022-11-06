using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class repeat : MonoBehaviour
{
     

  public void nextgame(string BioGarbageLevel){
        SceneManager.LoadScene(BioGarbageLevel);
    }

    }

