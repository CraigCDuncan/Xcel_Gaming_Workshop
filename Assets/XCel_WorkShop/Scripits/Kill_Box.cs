using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill_Box : MonoBehaviour
{
    public Game_Master GM;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GM.Resart();
        }
 
    }
}
