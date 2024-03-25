using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal_Pole : MonoBehaviour
{
    public Game_Master GM;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GM.Goal();
        }
    }

        
       
}
