using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key_PickUp : MonoBehaviour
{

 
    public int Keys=0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Key") 
        {
            Keys = Keys + 1;
            other.gameObject.SetActive(false);
        
        }
        if (other.tag == "Door" && Keys>=1 )
        {
            Debug.Log("Player_knock");
            other.gameObject.SetActive(false);
            Keys= Keys-1;
        }
    }
}
