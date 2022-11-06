using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Buttonhandler : MonoBehaviour
{
    // [SerializeField]private string Level;
    public void nextgame(string Level2){
        SceneManager.LoadScene(Level2);
    }
}
