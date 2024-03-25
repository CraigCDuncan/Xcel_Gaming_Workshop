using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Master : MonoBehaviour
{

    public GameObject Goal_Reach_ScreenUI;
    bool ScreenCheck = false;
    
    public void Goal () 
    {
        Goal_Reach_ScreenUI.SetActive (true);
        ScreenCheck = true;

    }
   public void Resart() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.R)) {
            Resart();
        }
        if (ScreenCheck==true) {
            if (Input.GetKeyDown(KeyCode.R)) { 
            Resart();
            }
            if (Input.GetKeyDown(KeyCode.E)) { 
            Goal_Reach_ScreenUI.SetActive(false);
            }
        }
    }
}
