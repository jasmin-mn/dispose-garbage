using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonPlayAgain : MonoBehaviour
{
     public void nextgame(string Level2 ){
        SceneManager.LoadScene(Level2);
    }
}
